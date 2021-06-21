using CommandLine;
namespace SortingVisualizer.UI.UI
{
    public class Options
    {
        [Option(shortName:'b', longName:"bubblesort", Required = false, Default = false, HelpText = "Bubble Sort Algorith")]
        public bool BubbleSort { get; set; }

        [Option(shortName: 'i', longName: "insertionsort", Required = false, Default = false, HelpText = "Insertion Sort Algorith")]
        public bool InsertionSort { get; set; }

        [Option(shortName: 'q', longName: "quicksort", Required = false, Default = false, HelpText = "Quick Sort Algorith")]
        public bool QuickSort { get; set; }

        [Option(shortName: 's', longName: "selectionsort", Required = false, Default = false, HelpText = "Selection Sort Algorith")]
        public bool SelectionSort { get; set; }
    }
}
