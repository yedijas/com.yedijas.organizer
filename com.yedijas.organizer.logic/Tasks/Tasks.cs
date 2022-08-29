using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.Tasks
{
    public class Tasks
    {
        public int ID { get; set; }
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

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Tasks n = (Tasks)obj;
                return n.ID == this.ID &&
                    n.Description.Equals(this.Description) &&
                    n.Deadline.Equals(this.Deadline) &&
                    n.Created.Equals(this.Created);
            }
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
