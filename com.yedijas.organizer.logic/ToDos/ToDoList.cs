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

        public void RemoveItem(int index)
        {
            DaftarToDo.RemoveAt(index);
        }

        public void RemoveAllItems(ToDo singleTDL)
        {
            DaftarToDo.RemoveAll(
                stdl => stdl.Description.Equals(singleTDL.Description)
                );
        }
    }
}
