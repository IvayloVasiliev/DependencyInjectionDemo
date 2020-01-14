using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection.Models.Contracts
{
    public interface IWriter
    {
        void Write(string content);
    }
}
