using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public static class DataConfigConstants
    {
        public const string FILEPATH = "FilePath";
    }

    public class PersonRepository : IPersonRepository
    {
        private IFileLoader _fileLoader;
        private IPersonParser _personParser;
        private readonly IConfigurator _config;

        public PersonRepository(IFileLoader fileLoader, IPersonParser personParser, IConfigurator config )
        {
            _fileLoader = fileLoader;
            _personParser = personParser;
            _config = config;
        }

        public List<Person> GetAllPersons()
        {
            var path = _config.Get<string>(DataConfigConstants.FILEPATH); // Config
            var lines = _fileLoader.LoadAllLines(path);
            var persons = _personParser.ParseFromCSV(lines);
            return persons;
        }
    }
}