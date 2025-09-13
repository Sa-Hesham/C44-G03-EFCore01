using Add_ITI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_ITI.Data
{
    internal class ItiDbContext :DbContext
    {
        public ItiDbContext() : base()
        {
            
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=ITI02 ;Trusted_Connection=True ;TrustServerCertificate=True;");
        }



       public DbSet<Students>Students { get; set; }
       public DbSet<Departments> Departments { get; set; }

        public DbSet<Instructors>instructors { get; set; }

        public DbSet<Courses>Courses { get; set; }

        public DbSet<Topics>Topics { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }

        public DbSet<CourseInstructor> course_Instructors { get; set; }

    }
}
