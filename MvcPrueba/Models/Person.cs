using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcPrueba.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SubName { get; set; }
        public string Email { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    public class PersonDBContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}