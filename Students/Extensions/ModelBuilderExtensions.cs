using Microsoft.EntityFrameworkCore;
using Students.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Students.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student() { id = 1, fullname = "sara abboudi", code = "A11", Niveau = 4 },
                 new Student() { id = 2, fullname = "Mohammed abboudi", code = "A22", Niveau = 1 },
                   new Student() { id = 3, fullname = "Brahim abboudi", code = "A33", Niveau = 3 }

                );
        }
    }
}
