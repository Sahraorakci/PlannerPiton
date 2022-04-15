using PlannerPiton.DataAccessLayer.Abstract;
using PlannerPiton.DataAccessLayer.Repositories;
using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.DataAccessLayer.EntityFramework
{
    public class EfEventRepository : GenericRepository<Event>, IEventDal
    {
    }
}
