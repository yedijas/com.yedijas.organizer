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
    }
}
