using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using ConsoleClient.CrossCutting.Configuration;
using ConsoleClient.CrossCutting.DataClasses;
using ConsoleClient.Data.DataAccess;

namespace ConsoleClient.Logic.PersonManagement
{
    public class PersonManager : IPersonManager
    {
        private IPersonRepository _personRepository;
        private readonly IPersonLogicValidator _validator;
        private readonly int AGE_TRESHOLD;

        public PersonManager(IPersonRepository personRepository,
            IConfigurator config,
            IPersonLogicValidator validator)
        {
            _personRepository = personRepository;
            _validator = validator;
            AGE_TRESHOLD = config.Get<int>("AgeTreshold");
        }

        public void Add(Person person)
        {
            _validator.AssertForAdd(person);

            _personRepository.Insert(person);
        }

        public List<Person> GetAllAdults()
        {
            var adults = _personRepository
                .GetAllPersons()
                .Where(p => p.Age >= AGE_TRESHOLD) // Config
                .ToList();
            return adults;
        }

        public List<Person> GetAllChildren()
        {
            var children = _personRepository
                .GetAllPersons()
                .Where(p => p.Age < AGE_TRESHOLD)
                .ToList();
            return children;
        }
    }
}