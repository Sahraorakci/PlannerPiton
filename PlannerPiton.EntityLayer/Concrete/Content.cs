using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        public string Description { get; set; }

        public ICollection<Event> Events { get; set; }
    }
}
