using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.Notes
{
    public class NoteList
    {
        public List<Note> DaftarNote { get; set; }

        public NoteList()
        {
            DaftarNote = new List<Note>();
        }

        public NoteList(List<Note> _daftar)
        {
            DaftarNote = _daftar;
        }

        public void AddItem(Note singleNote)
        {
            DaftarNote.Add(singleNote);
        }

        public void RemoveItem(int index)
        {
            DaftarNote.RemoveAt(index);
        }

        public void RemoveAllItems(Note singleNote)
        {
            DaftarNote.RemoveAll(
                sn => sn.Description.Equals(singleNote.Description) 
                );
        }

        public DataTable ExportToDataTable()
        {
            Type elementType = typeof(Note);
            DataTable t = new DataTable();

            t.Columns.Add("Index", typeof(int));
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            int index = 0;
            foreach (Note item in DaftarNote)
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
