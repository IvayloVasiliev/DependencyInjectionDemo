using DependencyInjection.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Models
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
