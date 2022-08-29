using System;

namespace com.yedijas.organizer.logic
{
    public class ToDo
    {
        public int ID { get; set; }
        public bool Completed { get; set; }
        public DateTime Created { get; set; }
        public string Description { get; set; }

        public ToDo()
        {
            Completed = false;
            Created = DateTime.Now;
            Description = "";
        }

        public ToDo(string _desc)
        {
            Completed = false;
            Created = DateTime.Now;
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
                ToDo n = (ToDo)obj;
                return n.ID == this.ID &&
                    n.Description.Equals(this.Description) &&
                    n.Created.Equals(this.Created);
            }
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
    }
}
