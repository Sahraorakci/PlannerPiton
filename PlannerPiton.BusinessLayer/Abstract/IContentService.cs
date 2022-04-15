using PlannerPiton.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerPiton.BusinessLayer.Abstract
{
    public interface IContentService
    {
        void AddContent(Content content);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
        List<Content> GetList();
        Content GetByID(int id);

    }
}
