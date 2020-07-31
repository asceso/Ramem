using System.Data.Entity;

namespace DatabaseCreating.Entities
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DefaultConnection")
        { }
        public DataContext(string connectionString) : base(connectionString)
        { }
        public DbSet<FirstName> FirstNames { get; set; }
        public DbSet<SecondName> SecondNames { get; set; }
    }
}
