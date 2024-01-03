using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class FileLoader : IFileLoader
    {
        public List<string> LoadAllLines()
        {
            return File.ReadAllLines("data.csv").ToList();
        }
    }
}