using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Core;

namespace TelefonRehberi.Entities.Concrete
{
    public class Role : IEntity
    {
        public Role()
        {
            this.Employees = new List<Employee>();
        }

        public int Id { get; set; }

        public string RoleName { get; set; }

        public virtual List<Employee> Employees { get; set; }
        
    }
}
