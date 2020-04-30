using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace SUDS
{
    class SudsDb : DbContext
    {
        public SudsDb()
            :base("DBConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<KindOfSport> KindsOfSport { get; set; }
        public DbSet<Sportsman> Sportsmen { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<Competition> Competitions { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}
