using DatabaseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLibrary
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DatabaseContext")
        {
        }
        public DbSet<FirstName> FirstNames { get; set; }
        public DbSet<SecondName> SecondNames { get; set; }
        public DbSet<FathersName> FathersNames { get; set; }
    }
}
