using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.DBContext
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> Students { set; get; }
        public DbSet<Course> Courses { set; get; }
        //public StudentContext (DbContextOptions option):base(option)
        //{ }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{ }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\LTHIENDUC\SQLEXPRESS;Database=SchoolDB1;Trusted_Connection=True;");
        }
    }
}
