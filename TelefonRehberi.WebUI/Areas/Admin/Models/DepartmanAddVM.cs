﻿using System.Collections.Generic;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.WebUI.Areas.Admin.Models
{
    public class DepartmanAddVM
    {
        public Departman Departmanlar { get; set; }
        public List<Employee> Employees { get; set; }
    }
}