using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeopleSearch.Models;

namespace PeopleSearch.Data
{
    public class DbInitializer
    {
        public static void Initialize(PeopleContext context)
        {
            context.Database.EnsureCreated();

            if (context.People.Any())
            {
                return;   // DB has been seeded
            }

            var people = new Person[]
            {
               new Person{PersonID = 1,Name = "Joey Despain", Age=23,Address="10420 Silver Mountain Drive",Interest="Food"},
               new Person{PersonID = 2,Name = "Kyra Bowman", Age=22,Address="10420 Silver Mountain Drive",Interest="Hair"}
            };

            foreach (Person p in people)
            {
                context.People.Add(p);
            }
            context.SaveChanges();
        }
    }
}
