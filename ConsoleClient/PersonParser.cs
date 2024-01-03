using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class PersonParser
    {
        public List<Person> ParseFromCSV(List<string> lines)
        {
            var persons = lines
                .Select(l => l.Split(","))
                .Select(p => new Person
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    Age = int.Parse(p[2])
                }).ToList();
            return persons;
        }
    }
}