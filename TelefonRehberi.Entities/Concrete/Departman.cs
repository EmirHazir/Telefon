using System.Collections.Generic;
using TelefonRehberi.Core;

namespace TelefonRehberi.Entities.Concrete
{
    public class Departman : IEntity
    {
        public Departman()
        {
            this.Employees = new List<Employee>();
        }

        public int Id { get; set; }

        public string DepartmanName { get; set; }

        public string DepartmanManager { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}