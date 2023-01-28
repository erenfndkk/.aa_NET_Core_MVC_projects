using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidatior : AbstractValidator<Team>
    {
        public TeamValidatior()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("teammate name can not null");
            RuleFor(x => x.Title).NotEmpty().WithMessage("task can not null");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("ImageUrl can not null");
            RuleFor(x => x.PersonName).MaximumLength(35).WithMessage("please do not exceed 35 characters");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("please enter at least 5 characters");
            RuleFor(x=>x.Title).MaximumLength(50).WithMessage("please do not exceed 50 characters");
            RuleFor(x=>x.Title).MinimumLength(5).WithMessage("please enter at least 5 characters");
        }
    }
}
