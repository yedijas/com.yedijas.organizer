using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.Tasks
{
    public class Tasks
    {
        public bool Completed { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Tasks()
        {
            Completed = false;
            Created = DateTime.Now;
            Deadline = Created.AddHours(1);
            Description = "";
        }

        public Tasks(DateTime _deadline, string _desc)
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
    }
}
