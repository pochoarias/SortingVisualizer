using SortingVisualizer.Persistance.Services.Sorting;
using SortingVisualizer.UI.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualizer.UI
{
    public class Application
    {
        private readonly IBubbleSortService _bubbleSortService;
        private readonly IQuickSortService _quickSortService;
        private readonly ISelectionSortService _selectionSortService;
        private readonly IInsertionSortService _insertionSortService;

        //TOD-DO: How to avoid injecting all the services. Use ISortableService only
        public Application(IBubbleSortService bubbleSortService,
                           IQuickSortService quickSortService,
                           ISelectionSortService selectionSortService,
                           IInsertionSortService insertionSortService)
        {
            _bubbleSortService = bubbleSortService;
            _quickSortService = quickSortService;
            _selectionSortService = selectionSortService;
            _insertionSortService = insertionSortService;
        }


        public void Run(Options options)
        {

            if (options.BubbleSort)
            {
                _bubbleSortService.Sort();
            }
            if (options.QuickSort)
            {
                _quickSortService.Sort();
            }
            if (options.SelectionSort)
            {
                _selectionSortService.Sort();
            }
            if (options.InsertionSort)
            {
                _insertionSortService.Sort();
            }
        }


    }
}
