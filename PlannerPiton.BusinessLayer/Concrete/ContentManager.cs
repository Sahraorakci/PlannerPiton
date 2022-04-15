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
   
    public class ContentManager : IContentService

    {

        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }
        public ContentManager()
        {
            _contentDal = new EfContentRepository();
        }

        

        public void AddContent(Content content)
        {

            _contentDal.Insert(content);

        }

        public void ContentDelete(Content content)
        {
            _contentDal.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            _contentDal.Update(content);
        }

        public Content GetByID(int id)
        {
            return _contentDal.GetByID(id);
        }

        public List<Content> GetList()
        {
            return _contentDal.GetListAll();
        }
    }
}
