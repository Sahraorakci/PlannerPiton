using PlannerPiton.BusinessLayer.Abstract;
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
        EfTitleRepository efTitleRepository;
        public TitleManager()
        {
            efTitleRepository = new EfTitleRepository();
        }
        public void AddTitle(Title title)
        {
            efTitleRepository.Insert(title);
        }

        public Title GetByID(int id)
        {
            return efTitleRepository.GetByID(id);
        }

        public List<Title> GetList()
        {
            return efTitleRepository.GetListAll();
        }

        public void TitleDelete(Title title)
        {
            efTitleRepository.Delete(title);
        }

        public void TitleUpdate(Title title)
        {
            efTitleRepository.Update(title);
        }
    }
}
