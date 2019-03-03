using Team07.Models;
using System;
using System.Linq;

namespace Team07.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {
                var degrees = new Degree[]
                {
                    new Degree{DegreeId = 1 , DegreeAbrrev =  "ACS+2", DegreeName = "MS ACS +2" },
new Degree{DegreeId = 2 , DegreeAbrrev =  "ACS+DB", DegreeName = "MS ACS + DB"},
new Degree{DegreeId = 3 , DegreeAbrrev =  "ACS+NF", DegreeName = "MS ACS+  NF"},
new Degree{DegreeId = 4 , DegreeAbrrev =  "ACS", DegreeName = "MS ACS"},

                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees.");
                foreach (Team07 d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }