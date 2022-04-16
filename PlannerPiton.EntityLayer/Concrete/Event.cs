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
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string BackgroundColor { get; set; } ="#0000FF";
        public string BorderColor { get; set; } = "#00FFFF";
        public bool AllDay { get; set; }
        public int TitleID { get; set; } = 1;
        public virtual Title Title { get; set; }

        public int ContentID { get; set; } = 1;
        public virtual Content Content { get; set; }

      

    }
}
