using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.ToDos
{
    public class ToDo
    {
        public bool Completed { get; set; }
        public DateTime Created { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }

        public ToDo()
        {
            Completed = false;
            Created = DateTime.Now;
            Deadline = Created.AddHours(1);
            Description = "";
        }

        public ToDo(DateTime _deadline, string _desc)
        {
            Completed = false;
            Created = DateTime.Now;
            Deadline = _deadline;
            Description = _desc;
        }

        public void MarkCompleted()
        {
            Completed = true;
        }

        public void MarkPending()
        {
            Completed = false;
        }
    }
}
