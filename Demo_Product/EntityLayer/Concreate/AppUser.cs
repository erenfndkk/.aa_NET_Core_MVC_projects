using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string surname { get; set; }
        public string Gender { get; set; }
    }
}
