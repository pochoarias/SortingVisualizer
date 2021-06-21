using SortingVisualizer.Persistance.Auditing;
using SortingVisualizer.Persistance.Services.Sorting;
using StructureMap;
using StructureMap.Graph;

namespace SortingVisualizer.UI.DependencyResolution
{
    public class CommonRegistry : Registry
    {
        public CommonRegistry()
        {
            Scan(scan =>
            {
                //AddAssemblies(scan);
                //scan.TheCallingAssembly();
                //scan.WithDefaultConventions();
                scan.TheCallingAssembly();
                scan.AssembliesAndExecutablesFromApplicationBaseDirectory(asm => asm.FullName.StartsWith("SortingVisualizer."));
                scan.WithDefaultConventions();
            });
        }

        private static void AddAssemblies(IAssemblyScanner assemblyScanner)
        {
            //assemblyScanner.AssemblyContainingType<IArrayGeneratorService>();
            //assemblyScanner.AssemblyContainingType<IBubbleSortService>();
            //assemblyScanner.AssemblyContainingType<IInsertionSortService>();
            //assemblyScanner.AssemblyContainingType<IQuickSortService>();
            //assemblyScanner.AssemblyContainingType<ISelectionSortService>();
            assemblyScanner.AssemblyContainingType<ISortableService>();
            //assemblyScanner.AssemblyContainingType<ITimer>();
            //assemblyScanner.AssemblyContainingType<ILogger>();
        }
    }
}
