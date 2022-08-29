using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LiteDB;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace com.yedijas.organizer.logic.Helper
{
    public static class DBHelper
    {
        static LiteDatabase mydb;

        public static void InitDB()
        {
            mydb = new LiteDatabase(System.AppDomain.CurrentDomain.BaseDirectory + "YedijasOrganizer.db");
        }

        public static DataTable AllToDataTable<T>(IEnumerable<T> data, bool addIndex = false)
        {
            Type elementType = typeof(T);
            DataTable t = new DataTable();

            if (addIndex)
                t.Columns.Add("Index", typeof(int));

            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            int index = 0;
            foreach (T item in data)
            {
                DataRow row = t.NewRow();

                if (addIndex)
                    row["Index"] = index;

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
                index++;
            }

            return t;
        }

        public static DataTable AllToDataTable<T>(bool addIndex = false)
        {
            Type elementType = typeof(T);
            var col = mydb.GetCollection<T>(elementType.Name);
            return AllToDataTable<T>(col.Query().ToList(), addIndex);
        }

        public static void AddItem<T>(T item)
        {
            Type elementType = typeof(T);
            var col = mydb.GetCollection<T>(elementType.Name);
            col.Insert(item);
        }

        public static List<T> GetDataInList<T>()
        {
            Type elementType = typeof(T);
            var col = mydb.GetCollection<T>(elementType.Name);
            return col.Query().ToList();
        }

        public static T ToObject<T>(this DataRow dataRow)
        where T : new()
        {
            T item = new T();

            foreach (DataColumn column in dataRow.Table.Columns)
            {
                PropertyInfo property = GetProperty(typeof(T), column.ColumnName);

                if (property != null && dataRow[column] != DBNull.Value && dataRow[column].ToString() != "NULL")
                {
                    property.SetValue(item, ChangeType(dataRow[column], property.PropertyType), null);
                }
            }

            return item;
        }

        private static PropertyInfo GetProperty(Type type, string attributeName)
        {
            PropertyInfo property = type.GetProperty(attributeName);

            if (property != null)
            {
                return property;
            }

            return type.GetProperties()
                 .Where(p => p.IsDefined(typeof(DisplayAttribute), false) && p.GetCustomAttributes(typeof(DisplayAttribute), false).Cast<DisplayAttribute>().Single().Name == attributeName)
                 .FirstOrDefault();
        }

        public static object ChangeType(object value, Type type)
        {
            if (type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }

                return Convert.ChangeType(value, Nullable.GetUnderlyingType(type));
            }

            return Convert.ChangeType(value, type);
        }

        public static bool DeleteItemByID<T>(int ID)
        {
            bool success = false;
            Type elementType = typeof(T);
            var col = mydb.GetCollection<T>(elementType.Name);
            col.Delete(ID);

            return success;
        }

        public static bool DeleteItems<T>(T item)
        {
            bool success = false;
            Type elementType = typeof(T);
            var col = mydb.GetCollection<T>(elementType.Name);
            col.DeleteMany(t => t.Equals(item));

            return success;
        }
    }
}
