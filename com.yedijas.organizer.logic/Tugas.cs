using System;

namespace com.yedijas.organizer.logic
{
    public class Tugas
    {
        public int ID { get; set; }
        public bool Completed { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public Tugas()
        {
            Completed = false;
            Created = DateTime.Now;
            Deadline = Created.AddHours(1);
            Description = "";
        }

        public Tugas(DateTime _deadline, string _desc)
        {
            Completed = false;
            Created = DateTime.Now;
            Deadline = _deadline;
            Description = _desc;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Tugas n = (Tugas)obj;
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
