using DatabaseLibrary.Entities;
using System;
using System.Data.Entity;

namespace DatabaseLibrary
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
