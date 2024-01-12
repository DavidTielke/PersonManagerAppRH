﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    public class FileLoader : IFileLoader
    {
        public List<string> LoadAllLines(string path)
        {
            return File.ReadAllLines(path).ToList();
        }
    }
}