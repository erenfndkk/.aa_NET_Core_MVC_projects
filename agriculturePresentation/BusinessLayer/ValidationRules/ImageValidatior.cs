using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidatior : AbstractValidator<Image>
    {
        public ImageValidatior()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Image title can not be empty");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Image description can not be empty");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Image imageurl can not be empty");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("please do not exceed 20 characters");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("please do not exceed 50 characters");
        }
    }
}
