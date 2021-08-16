using Microsoft.EntityFrameworkCore;
using blazorwasmretainingsearchconditions.Shared.Models;
using blazorwasmretainingsearchconditions.Shared;

namespace blazorwasmretainingsearchconditions.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData
            (
                new Student { Id = 1, FirstName = "Avril", LastName = "Lavigne", Age = 36, Gender = Gender.WOMEN, Email = "avril@avril.com" },
                new Student { Id = 2, FirstName = "Bruno", LastName = "Mars", Age = 35, Gender = Gender.MEN, Email = "bruno@bruno.com" },
                new Student { Id = 3, FirstName = "Charlie", LastName = "Puth", Age = 29, Gender = Gender.MEN, Email = "charlie@charlie.com" },
                new Student { Id = 4, FirstName = "Ed", LastName = "Sheeran", Age = 30, Gender = Gender.MEN, Email = "ed@ed.com" },
                new Student { Id = 5, FirstName = "James", LastName = "Bay", Age = 30, Gender = Gender.MEN, Email = "james@james.com" },
                new Student { Id = 6, FirstName = "Jess", LastName = "Glynne", Age = 31, Gender = Gender.WOMEN, Email = "jess@jess.com" },
                new Student { Id = 7, FirstName = "Katy", LastName = "Perry", Age = 36, Gender = Gender.WOMEN, Email = "katy@katy.com" },
                new Student { Id = 8, FirstName = "Lady", LastName = "Gaga", Age = 35, Gender = Gender.WOMEN, Email = "gaga@gaga.com" },
                new Student { Id = 9, FirstName = "Michael", LastName = "Jackson", Age = 50, Gender = Gender.MEN, Email = "michael@michael.com" },
                new Student { Id = 10, FirstName = "Sam", LastName = "Smith", Age = 29, Gender = Gender.MEN, Email = "sam@sam.com" }
            );
        }
    }
}