using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.BusinessLayer.Abstract
{
   public interface ITitleService
    {
        void AddTitle(Title title);
        void TitleDelete(Title title);
        void TitleUpdate(Title title);
        List<Title> GetList();
        Title GetByID(int id);
    }
}
