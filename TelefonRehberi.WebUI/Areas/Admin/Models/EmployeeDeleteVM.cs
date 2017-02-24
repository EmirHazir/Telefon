using System.Collections.Generic;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.WebUI.Areas.Admin.Models
{
   public class EmployeeDeleteVM
    {
        public List<Departman> Departmans { get; set; }
        public Employee Employes { get; internal set; }
    }
}