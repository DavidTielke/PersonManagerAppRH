using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class PersonParser : IPersonParser
    {
        private readonly IConfigurator _config;

        public PersonParser(IConfigurator config)
        {
            _config = config;
        }

        public List<Person> ParseFromCSV(List<string> lines)
        {
            var persons = lines
                .Select(l =>
                {
                    var separator = _config.Get<string>("Separator"); // Config
                    return l.Split(separator);
                })
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