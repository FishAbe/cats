﻿
using System.Data.Entity;
using Cats.Models.Security;
using Cats.Models.Security.Mapping;

namespace Cats.Data.Security
{
    public class SecurityContext : DbContext
    {
        static SecurityContext()
        {
            Database.SetInitializer<SecurityContext>(null);
        }

        public SecurityContext() : base("Name=CatsSecurityContext") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UsersInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Configurations.Add(new UserMap());
           modelBuilder.Configurations.Add(new UserInfoMap());
        }
    }
}
