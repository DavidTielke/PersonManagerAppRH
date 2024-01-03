using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class PersonRepository
    {
        private FileLoader _fileLoader;
        private PersonParser _personParser;

        public PersonRepository()
        {
            _fileLoader = new FileLoader();
            _personParser = new PersonParser();
        }

        public List<Person> GetAllPersons()
        {
            var lines = _fileLoader.LoadAllLines();
            var persons = _personParser.ParseFromCSV(lines);
            return persons;
        }
    }
}