using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.EntityLayer.Concrete
{
    public class Title
    {
        [Key]
        public int TitleID { get; set; }
        public string TitleText { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
