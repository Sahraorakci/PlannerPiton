using PlannerPiton.BusinessLayer.Abstract;
using PlannerPiton.DataAccessLayer.Abstract;
using PlannerPiton.DataAccessLayer.EntityFramework;
using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.BusinessLayer.Concrete
{
    public class TitleManager : ITitleService
    {
        ITitleDal _titleDal;
        public TitleManager(ITitleDal titleDal)
        {
            _titleDal = titleDal;
        }
        public TitleManager()
        {
            _titleDal = new EfTitleRepository();
        }

        

        public void AddTitle(Title title)
        {
            _titleDal.Insert(title);
        }

        public Title GetByID(int id)
        {
            return _titleDal.GetByID(id);
        }

        public List<Title> GetList()
        {
            return _titleDal.GetListAll();
        }

        public void TitleDelete(Title title)
        {
            _titleDal.Delete(title);
        }

        public void TitleUpdate(Title title)
        {
            _titleDal.Update(title);
        }
    }
}
