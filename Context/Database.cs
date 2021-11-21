using Microsoft.EntityFrameworkCore;
using MinimalApiTest.Models;

namespace MinimalApiTest.Context
{
    public class Database: DbContext
    {
        public Database(DbContextOptions<Database> options)
            : base(options)
        {
            FillPersonTable();
        }
        public DbSet<Person> Persons { get; set; }

        private void FillPersonTable()
        {
            Persons.Add(new Person(){ FirstName="Teus", LastName="van Arkel"});
            Persons.Add(new Person(){ FirstName="Joeri", LastName="van Arkel"});
            Persons.Add(new Person(){ FirstName="Josien", LastName="term Maten"});
            this.SaveChanges();

        }
    }
}