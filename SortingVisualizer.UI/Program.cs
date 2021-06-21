using CommandLine;
using SortingVisualizer.UI.DependencyResolution;
using SortingVisualizer.UI.UI;
using StructureMap;
using System;
using System.Threading.Tasks;

namespace SortingVisualizer.UI
{
    class Program
    {
        private static IContainer _container;
        static async Task Main(string[] args)
        {
            Console.WriteLine("****** Sorting Visualizer ******");
            _container = Bootstrapper.GetContainer();

            await Parser.Default.ParseArguments<Options>(args)
                .MapResult(async (Options opts) =>
                {
                     await SortingVisualizer(opts);
                },
                errs => Task.FromResult(-1) //Invalid Arguments
                );

            Console.WriteLine("****** Sorting Visualizer ******");
        }
        
        private static Task SortingVisualizer(Options options)
        {
            try
            {
                var app = _container.GetInstance<Application>();
                app.Run(options);
                return Task.CompletedTask;
            }catch(Exception exc)
            {
                return Task.FromException(exc);
            }
        }
    }
}
