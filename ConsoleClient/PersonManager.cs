using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class PersonManager
    {
        private PersonRepository _personRepository;

        public PersonManager()
        {
            _personRepository = new PersonRepository();
        }

        public List<Person> GetAllAdults()
        {
            var adults = _personRepository
                .GetAllPersons()
                .Where(p => p.Age >= 18)
                .ToList();
            return adults;
        }

        public List<Person> GetAllChildren()
        {
            var children = _personRepository
                .GetAllPersons()
                .Where(p => p.Age < 18)
                .ToList();
            return children;
        }
    }
}