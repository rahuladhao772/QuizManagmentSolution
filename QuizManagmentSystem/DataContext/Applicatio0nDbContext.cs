using Microsoft.EntityFrameworkCore;
using QuizManagmentSystem.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace QuizManagmentSystem.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<UserData> userEntities { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserData>().HasData(new UserData()
            {
                Id = 1,
                FName = "Rahul",
                LName = "Adhao",
                MName = "Sheshrao",
                Gender = "Male",
                Depatment = "Mechanical",
                Email = "rahul@gmail.com",
                Phone = "7499458965",
                ConfirmPassword = "rahul123",
                Password = "rahul123"
            });
            modelBuilder.Entity<UserData>().HasData(new UserData()
            {
                Id = 2,
                FName = "Neha",
                LName = "Ahire",
                MName = "Bhaskar",
                Gender = "Female",
                Depatment = "CS",
                Email = "neha@gmail.com",
                Phone = "9605000860",
                ConfirmPassword = "neha123",
                Password = "neha123"
            });
            modelBuilder.Entity<UserData>().HasData(new UserData()
            {
                Id = 3,
                FName = "Mansi",
                LName = "Goavkar",
                MName = "Vithaldas",
                Gender = "Female",
                Depatment = "CS",
                Email = "Mansi@gmail.com",
                Phone = "9604086056",
                ConfirmPassword = "Mansi123",
                Password = "Mansi123"
            });
            modelBuilder.Entity<UserData>().HasData(new UserData()
            {
                Id = 4,
                FName = "Nirnjan",
                LName = "Khatave",
                MName = "Anil",
                Gender = "Male",
                Depatment = "Mechanical",
                Email = "Nirnjan@gmail.com",
                Phone = "7499458965",
                ConfirmPassword = "Niraj123",
                Password = "Niraj123"
            });
        }

    }
}
