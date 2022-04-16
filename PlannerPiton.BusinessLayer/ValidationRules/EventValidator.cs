using FluentValidation;
using PlannerPiton.EntityLayer.Concrete;

namespace PlannerPiton.BusinessLayer.ValidationRules
{

    public class EventValidator : AbstractValidator<Event>
    {
        public EventValidator()
        {
            RuleFor(x => x.StartDate).NotEmpty().WithMessage("Başlangıç tarihini boş geçemezsiniz");
            RuleFor(x => x.EndDate).NotEmpty().WithMessage("Bitiş tarihini boş geçemezsiniz");
          

        }
    }
}
