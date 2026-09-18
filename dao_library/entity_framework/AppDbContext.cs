using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity_library;

namespace dao_library.entity_framework
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { } // No tiene que ir nada dentro de las llaves

        public DbSet<Activity> Activities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
