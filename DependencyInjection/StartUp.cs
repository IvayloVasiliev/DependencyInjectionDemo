using DependencyInjection.Core;
using SoftUniDI;
using DependencyInjection.Modules;

namespace DependencyInjection
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var injector = DependencyInjector.CreateInjector(new Module());
            var engine = injector.Inject<Engine>();
            engine.Run();
        }
    }
}
