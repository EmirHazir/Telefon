﻿using System.Collections.Generic;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.WebUI.Areas.Admin.Models
{
    public class RoleDeleteVM
    {
        public List<Employee> Employees { get; set; }
        public Role Roles { get; set; }
    }
}