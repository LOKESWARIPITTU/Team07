﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team07.Data;

namespace Team07.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Team07.Models.Degree", b =>
                {
                    b.Property<int>("DegreeId");

                    b.Property<string>("DegreeAbrrev")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("DegreeName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("DegreeId");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("Team07.Models.DegreePlan", b =>
                {
                    b.Property<int>("DegreePlanId");

                    b.Property<int>("DegreeID");

                    b.Property<string>("DegreePlanAbbrev")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("DegreePlanName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<bool>("Done");

                    b.Property<int>("StudentID");

                    b.HasKey("DegreePlanId");

                    b.HasIndex("DegreeID");

                    b.HasIndex("StudentID");

                    b.ToTable("DegreePlan");
                });

            modelBuilder.Entity("Team07.Models.DegreePlanTermRequirement", b =>
                {
                    b.Property<int>("DegreePlanTermRequirementId");

                    b.Property<int>("DegreePlanID");

                    b.Property<int>("RequirementID");

                    b.Property<int>("TermID");

                    b.HasKey("DegreePlanTermRequirementId");

                    b.HasIndex("DegreePlanID");

                    b.HasIndex("RequirementID");

                    b.ToTable("DegreeplanTermRequirement");
                });

            modelBuilder.Entity("Team07.Models.DegreeRequirement", b =>
                {
                    b.Property<int>("DegreeRequirementId");

                    b.Property<int>("DegreeId");

                    b.Property<int>("RequirementId");

                    b.Property<int?>("StudentTermId");

                    b.HasKey("DegreeRequirementId");

                    b.HasIndex("DegreeId");

                    b.HasIndex("RequirementId");

                    b.HasIndex("StudentTermId");

                    b.ToTable("DegreeRequirement");
                });

            modelBuilder.Entity("Team07.Models.Requirement", b =>
                {
                    b.Property<int>("RequirementID");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("RequirementAbbrev")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("RequirementID");

                    b.ToTable("Requirement");
                });

            modelBuilder.Entity("Team07.Models.Student", b =>
                {
                    b.Property<int>("StudentId");

                    b.Property<bool>("Done");

                    b.Property<string>("First")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Last")
                        .IsRequired()
                        .HasMaxLength(40);

                    b.Property<string>("Snumber");

                    b.Property<int>("catpawsnum");

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("Team07.Models.StudentTerm", b =>
                {
                    b.Property<int>("StudentTermId");

                    b.Property<int>("DegreePlanId");

                    b.Property<bool>("Done");

                    b.Property<int?>("StudentId");

                    b.Property<int>("Term");

                    b.Property<string>("TermLabel")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("StudentTermId");

                    b.HasIndex("DegreePlanId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentTerm");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Team07.Models.DegreePlan", b =>
                {
                    b.HasOne("Team07.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Team07.Models.Student", "Student")
                        .WithMany("DegreePlans")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Team07.Models.DegreePlanTermRequirement", b =>
                {
                    b.HasOne("Team07.Models.DegreePlan", "DegreePlan")
                        .WithMany("degreePlanTermRequirements")
                        .HasForeignKey("DegreePlanID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Team07.Models.Requirement", "Requirement")
                        .WithMany()
                        .HasForeignKey("RequirementID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Team07.Models.DegreeRequirement", b =>
                {
                    b.HasOne("Team07.Models.Degree", "Degree")
                        .WithMany("DegreeRequirements")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Team07.Models.Requirement", "Requirement")
                        .WithMany()
                        .HasForeignKey("RequirementId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Team07.Models.StudentTerm")
                        .WithMany("DegreeRequirements")
                        .HasForeignKey("StudentTermId");
                });

            modelBuilder.Entity("Team07.Models.StudentTerm", b =>
                {
                    b.HasOne("Team07.Models.DegreePlan", "DegreePlan")
                        .WithMany("StudentTerms")
                        .HasForeignKey("DegreePlanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Team07.Models.Student")
                        .WithMany("StudentTerms")
                        .HasForeignKey("StudentId");
                });
#pragma warning restore 612, 618
        }
    }
}
