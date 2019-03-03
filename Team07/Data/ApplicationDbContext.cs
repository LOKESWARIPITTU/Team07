using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Team07.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    public DBSet<Degree> Degrees { get; set; }
        public DBSet<Requirement> Requirements {get; set;}
        public DBSet<DegreeRequirement> Requirements {get; set;}
        public DBSet<DegreeplanTermRequirement> DegreeplanTermRequirements {get; set;}
        public DBSet<DegreePlan> DegreePlans {get; set;}
        public DBSet<Student> Students {get; set;}
        public DBSet<StudentTerm> StudentTerms {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Requirement>().ToTable("Requirement");
            modelBuilder.Entity<DegreeRequirement>().ToTable("DegreeRequirement");
            modelBuilder.Entity<DegreeplanTermRequirement>().ToTable("DegreeplanTermRequirement");
            modelBuilder.Entity<DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<StudentTerm>().ToTable("StudentTerm");
        }
    }
}
