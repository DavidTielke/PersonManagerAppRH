using DavidTielke.PersonManagerApp.Backend.Data.FileStorage;
using DavidTielke.PersonManagerApp.CrossCutting.Configuration;
using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess
{
    public class PersonRepository : IPersonRepository
    {
        private IFileStorer _fileStorer;
        private IPersonParser _personParser;
        private readonly IConfigurator _config;
        private readonly IPersonConverter _converter;
        private readonly IPersonDataValidator _validator;

        public PersonRepository(IFileStorer fileStorer,
            IPersonParser personParser,
            IConfigurator config,
            IPersonConverter converter,
            IPersonDataValidator validator)
        {
            _fileStorer = fileStorer;
            _personParser = personParser;
            _config = config;
            _converter = converter;
            _validator = validator;
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
            _validator.AssertForInsert(person);

            var allLines = _fileStorer.LoadAllLines(Path);

            var allPersons = _personParser.ParseFromCSV(allLines);
            var nextIndex = allPersons.Max(p => p.Id) + 1;
            person.Id = nextIndex;

            var csvData = _converter.ToCsv(person);
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