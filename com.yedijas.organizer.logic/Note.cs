using System;

namespace com.yedijas.organizer.logic
{
    public class Note
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public Note()
        {
            Description = "";
            Created = DateTime.Now;
        }

        public Note(string _description)
        {
            Description = _description;
            Created = DateTime.Now;
        }

        public Note(string _description, DateTime _created)
        {
            Description = _description;
            Created = _created;
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Note n = (Note) obj;
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
