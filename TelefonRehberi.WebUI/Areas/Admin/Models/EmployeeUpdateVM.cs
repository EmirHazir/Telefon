using System.Collections.Generic;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.WebUI.Areas.Admin.Models
{
    public class EmployeeUpdateVM
    {
        public List<Departman> Departmans { get; set; }
        public Employee Employees { get; set; }
    }
}