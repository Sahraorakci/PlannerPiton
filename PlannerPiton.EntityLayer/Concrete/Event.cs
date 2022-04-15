using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.EntityLayer.Concrete
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BackgroundColor { get; set; }
        public string BorderColor { get; set; }
        public bool AllDay { get; set; }

        public int TitleID { get; set; }
        public virtual Title Title { get; set; }

        public int ContentID { get; set; }
        public virtual Content Content { get; set; }

      

    }
}
