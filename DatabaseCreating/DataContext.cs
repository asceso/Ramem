using System;
using System.Collections.Generic;
using System.Data.Entity;
using DatabaseCreating.Entities;

namespace DatabaseCreating
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DatabaseConnection")
        {
        }
        public DbSet<FirstName> FirstNames { get; set; }
        public DbSet<SecondName> SecondNames { get; set; }
        public DbSet<FathersName> FathersNames { get; set; }
    }
}
