using Microsoft.EntityFrameworkCore;
using Students.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Models
{
    public class StudentContext :DbContext
    {
        public StudentContext(DbContextOptions<StudentContext>options):base(options)
        {

        }
        public DbSet<Student> Students{ get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
