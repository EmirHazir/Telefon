using System.Collections.Generic;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.WebUI.Models
{
    public class EmployeeDetailsViewModel
    {
        public List<Departman> Departmans { get; set; }
        public Employee Employees { get; set; }
        public List<Role> Roles { get; set; }
    }
}