using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.ToDos
{
    public class ToDoList
    {
        public List<ToDo> DaftarToDo { get; set; }

        public ToDoList()
        {
            DaftarToDo = new List<ToDo>();
        }

        public ToDoList(List<ToDo> _daftar)
        {
            DaftarToDo = _daftar;
        }

        public void AddItem(ToDo singleItem)
        {
            DaftarToDo.Add(singleItem);
        }

        public void MarkItemCompleted(int index)
        {
            DaftarToDo[index].MarkCompleted();
        }

        public void MarkItemPending(int index)
        {
            DaftarToDo[index].MarkPending();
        }

        public DataTable ExportToDataTable()
        {
            Type elementType = typeof(ToDo);
            DataTable t = new DataTable();

            t.Columns.Add("Index", typeof(int));
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            int index = 0;
            foreach (ToDo item in DaftarToDo)
            {
                DataRow row = t.NewRow();

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
