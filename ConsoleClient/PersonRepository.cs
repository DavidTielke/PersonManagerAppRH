using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class PersonRepository : IPersonRepository
    {
        private IFileStorer _fileStorer;
        private IPersonParser _personParser;
        private readonly IConfigurator _config;
        private readonly IPersonConverter _converter;

        public PersonRepository(IFileStorer fileStorer, 
            IPersonParser personParser, 
            IConfigurator config,
            IPersonConverter converter)
        {
            _fileStorer = fileStorer;
            _personParser = personParser;
            _config = config;
            _converter = converter;
        }

        private string Path
        {
            get
            {
                return _config.Get<string>(DataConfigConstants.FILEPATH);
            }
        }

        public void Insert(Person person)
        {
            var csvData = _converter.ToCsv(person);
            var allLines = _fileStorer.LoadAllLines(Path);
            allLines.Add(csvData);
            _fileStorer.WriteAllLines(Path, allLines);
        }

        public List<Person> GetAllPersons()
        {
            var lines = _fileStorer.LoadAllLines(Path);
            var persons = _personParser.ParseFromCSV(lines);
            return persons;
        }
    }
}