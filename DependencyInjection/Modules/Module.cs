﻿using DependencyInjection.Models;
using DependencyInjection.Models.Contracts;
using SoftUniDI.Modules;

namespace DependencyInjection.Modules
{
    public class Module : AbstractModule
    {
        public override void Configure()
        {
            this.CreateMapping<IReader, ConsoleReader>();
            this.CreateMapping<IWriter, ConsoleWriter>();
            this.CreateMapping<IWriter, FileWriter>();
        }
    }
}
