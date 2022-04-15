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
   
    public class ContentManager : IContentService

    {
        EfContentRepository efContentRepository;
        public ContentManager()
        {
            efContentRepository = new EfContentRepository();
        }
        

        public void AddContent(Content content)
        {

            efContentRepository.Insert(content);

        }

        public void ContentDelete(Content content)
        {
            efContentRepository.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            efContentRepository.Update(content);
        }

        public Content GetByID(int id)
        {
            return efContentRepository.GetByID(id);
        }

        public List<Content> GetList()
        {
            return efContentRepository.GetListAll();
        }
    }
}
