namespace DependencyInjection.Core
{
    using DependencyInjection.Core.Contracts;
    using DependencyInjection.Models.Contracts;
    using SoftUniDI.Attributes;

    public class Engine : IEngine
    {
        //[Inject] //injection for fields doesnt work, needss fixing
        private IReader reader;

        //[Inject]
        //[Named("ConsoleWriter")]
        private IWriter consoleWriter;

        //[Inject]
        //[Named("FileWriter")]
        private IWriter fileWriter;

        [Inject]
        public Engine(IReader consoleReader, IWriter consoleWriter, [Named("FileWriter")] IWriter fileWriter)
        {
            this.reader = consoleReader;
            this.fileWriter = fileWriter;
            this.consoleWriter = consoleWriter;
        }

        public void Run()
        {
            var readInput = this.reader.Read();
            this.consoleWriter.Write(readInput);
            this.fileWriter.Write(readInput);
        }
    }
}
