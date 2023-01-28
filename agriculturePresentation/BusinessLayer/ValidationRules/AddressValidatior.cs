using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AddressValidatior : AbstractValidator<Adress>
    {
        public AddressValidatior()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Description 1 can not be empty");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Description 2 can not be empty");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Description 3 can not be empty");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Description 4 can not be empty");
            RuleFor(x => x.Mapinfo).NotEmpty().WithMessage("map info can not be empty");
            RuleFor(x => x.Description1).MaximumLength(30).WithMessage("please do not exceed 30 characters");
            RuleFor(x => x.Description2).MaximumLength(30).WithMessage("please do not exceed 30 characters");
            RuleFor(x => x.Description3).MaximumLength(30).WithMessage("please do not exceed 30 characters");
            RuleFor(x => x.Description4).MaximumLength(30).WithMessage("please do not exceed 30 characters");
        }
    }
}
