using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core;

namespace TelefonRehberi.Entities.Concrete
{
   public class Employee : IEntity
    {
        public Employee()
        {
            this.Roles = new List<Role>();
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }

        public string TelephoneNo { get; set; }

        public bool IsActive { get; set; }

        public int DepartmanId { get; set; }

        public virtual Departman Departman { get; set; }

        public virtual List<Role> Roles { get; set; }



    }
}
