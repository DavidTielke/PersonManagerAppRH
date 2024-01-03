using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class PersonRepository : IPersonRepository
    {
        private IFileLoader _fileLoader;
        private IPersonParser _personParser;

        public PersonRepository(IFileLoader fileLoader, IPersonParser personParser)
        {
            _fileLoader = fileLoader;
            _personParser = personParser;
        }

        public List<Person> GetAllPersons()
        {
            var lines = _fileLoader.LoadAllLines();
            var persons = _personParser.ParseFromCSV(lines);
            return persons;
        }
    }
}