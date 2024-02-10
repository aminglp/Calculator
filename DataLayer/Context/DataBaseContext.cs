using DataLayer.Entities;
using DataLayer.Entities.NewRelation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
             : base("name=DataBaseContext")
        {        
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<Permission> Permissions { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
