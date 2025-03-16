using System;
using System.Collections.Generic;

namespace TryJenkins
{
    public class Data
    {
        public List<Person> People { get; }

        public Data()
        {
            People = new List<Person>
            {
                new Person { FirstName = "Enosh", LastName = "Zur", Age = 34, Id = 1 },
                new Person { FirstName = "Matanel", LastName = "Vatkin", Age = 24, Id = 2 },
                new Person { FirstName = "Alef", LastName = "Bet", Age = 100, Id = 3 }
            };
        }

        public List<Person> GetPeople()
        {
            return People;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public void Print()
        {
            Console.WriteLine($"{{\n  id: {Id},\n  full name: {FirstName} {LastName},\n  age: {Age},\n}}");
        }
    }
}
