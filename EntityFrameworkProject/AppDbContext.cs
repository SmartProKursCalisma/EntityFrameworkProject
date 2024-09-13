using EntityFrameworkProject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkProject
{
    public class AppDbContext : DbContext
    {


        public AppDbContext() : base("Server=202-00;Database=CourseProjectDb;User Id=sa;Password=1234;")
        {
            
        }
        //public AppDbContext() : base("name=defaultDbConnection")
        //{

        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<User>().HasKey(x=> x.Id)
        //    //    .ToTable("Tbl_Users")
        //    //    .Property(x => x.Username).HasColumnName("kullanicilar");

        //    //modelBuilder.Entity<Student>()
        //    //    .HasKey(x => x.Id)
        //    //    .Property(x => x.NameSurname)
        //    //    .IsRequired()
        //    //    .HasMaxLength(50);

        //    base.OnModelCreating(modelBuilder);
        //}
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students{ get; set; }
    }
}
