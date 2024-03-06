using DavidTielke.PersonManagerApp.CrossCutting.DataClasses;

namespace DavidTielke.PersonManagerApp.Backend.Data.DataAccess
{
    public class PersonParser : IPersonParser
    {
        public List<Person> ParseFromCSV(IEnumerable<string> lines)
        {
            ArgumentNullException.ThrowIfNull(lines);

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