﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelefonRehberi.Entities.Concrete;

namespace TelefonRehberi.DataAccess.Concrete
{
   public class TelefonDBContext : IdentityDbContext<ApplicationUser>
    {
        public TelefonDBContext():base("TelefonDb")
        {

        }


        public DbSet<Employee> Employees { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Departman> Departmans { get; set; }



    }
}
