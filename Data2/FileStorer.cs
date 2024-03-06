using DavidTielke.PersonManagerApp.Backend.Data.FileStorage;

namespace Data2
{
    // T-System
    public class FileStorer : IFileStorer
    {
        public List<string> LoadAllLines(string path)
        {
            return File.ReadAllLines(path).ToList();
        }

        public void WriteAllLines(string path, List<string> lines)
        {
            File.WriteAllLines(path, lines);
        }
    }
}