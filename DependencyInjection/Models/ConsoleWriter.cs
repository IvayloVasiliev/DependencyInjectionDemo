﻿using DependencyInjection.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Models
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string content)
        {
            Console.WriteLine(content);
        }
    }
}
