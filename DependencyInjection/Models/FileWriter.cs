using DependencyInjection.Models.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DependencyInjection.Models
{
    public class FileWriter : IWriter
    {
        private const string FilePath = "log.txt";

        public void Write(string content)
        {
            File.AppendAllText(FilePath, content);
        }
    }
}
