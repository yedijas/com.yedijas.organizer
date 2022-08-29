using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LiteDB;

namespace com.yedijas.organizer.logic.Helper
{
    public class DBHelper
    {
        LiteDatabase mydb;

        public DBHelper()
        {
            InitDB();
        }

        public void InitDB()
        {
            mydb = new LiteDatabase(System.AppDomain.CurrentDomain.BaseDirectory + "YedijasOrganizer.db");
        }

        public DataTable ToDataTable<T>(IList<T> data, bool addIndex = true)
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
    }
}
