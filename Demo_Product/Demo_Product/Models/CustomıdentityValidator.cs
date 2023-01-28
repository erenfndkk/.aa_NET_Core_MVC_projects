using Microsoft.AspNetCore.Identity;

namespace Demo_Product.Models
{
    public class CustomıdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "paralo en az 6 karakter olmalı"
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "paralo en az 1 büyük harf içermeli"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "paralo en az bir küçük harf içermeli"
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "paralo en az 1 alphanumeric karakter içermeli (*,?,=,&,+,%,^, gibi) "
            };
        }
    }
}
