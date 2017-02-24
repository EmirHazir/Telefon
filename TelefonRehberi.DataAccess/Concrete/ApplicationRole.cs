using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberi.DataAccess.Concrete
{
   public class ApplicationRole : IdentityRole
    {
        public ApplicationRole()
        {

        }
        public string Aciklama { get; set; }
        public ApplicationRole(string rolName, string aciklama) : base(rolName)
        {
            this.Aciklama = aciklama;
        }
    }
}
