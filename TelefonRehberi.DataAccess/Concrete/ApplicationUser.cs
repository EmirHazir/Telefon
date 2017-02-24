using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.DataAccess.Concrete
{
    public class ApplicationUser : IdentityUser
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }

        public string Telefon { get; set; }
    }
}
