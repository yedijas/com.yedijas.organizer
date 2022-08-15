using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.Tasks
{
    public class TaskList
    {
        public List<Tasks> DaftarTask { get; set; }

        public TaskList()
        {
            DaftarTask = new List<Tasks>();
        }

        public TaskList(List<Tasks> _daftar)
        {
            DaftarTask = _daftar;
        }

        public void AddItem(Tasks singleTask)
        {
            DaftarTask.Add(singleTask);
        }

        public void MarkItemCompleted(int index)
        {
            DaftarTask[index].MarkCompleted();
        }

        public void RemoveItem(int index)
        {
            if (DaftarTask[index].Completed == true)
            {
                DaftarTask.RemoveAt(index);
            }
            else
            {
                throw new TaskNotCompletedException("Task is not completed, yet!");
            }
        }

        public string GetDescription(int index)
        {
            return DaftarTask[index].Description;
        }

        public void RemoveAllItems(Tasks singleTask)
        {
            DaftarTask.RemoveAll(
                st => st.Description.Equals(singleTask.Description)
                && st.Completed == true
                );
        }

        public DataTable ExportToDataTable()
        {
            Type elementType = typeof(Tasks);
            DataTable t = new DataTable();

            t.Columns.Add("Index", typeof(int));
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            int index = 0;
            foreach (Tasks item in DaftarTask)
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
