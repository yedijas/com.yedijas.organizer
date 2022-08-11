using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.yedijas.organizer.logic.Notes
{
    public class Note
    {
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
    }
}
