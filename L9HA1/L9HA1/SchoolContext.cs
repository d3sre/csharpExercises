using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L9HA1
{
    //DbContext allows to interact with DB
    class SchoolContext : DbContext
    {
        //public SchoolContext() : base("name=SchoolContext") { }

        public virtual DbSet<Person> People { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)  { }
    }
}
