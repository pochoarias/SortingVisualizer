using System;

namespace SortingVisualizer.Persistance.Services.Sorting
{
    public class SelectionSortService : ISelectionSortService
    {
        private const string algorithm = "Selection Sort";
        private readonly ILogger _logger;
        private readonly IArrayGeneratorService _arrayGeneratorService;
        public SelectionSortService(ILogger logger, IArrayGeneratorService arrayGeneratorService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _arrayGeneratorService = arrayGeneratorService ?? throw new ArgumentNullException(nameof(arrayGeneratorService));
        }

        public void Sort()
        {
            _arrayGeneratorService.RandomizeArray();
            _logger.Init(algorithm);
            SelectionSort();
            _logger.Stop();
        }

        private void SelectionSort()
        {
            int[] array = _arrayGeneratorService.GetArray();
            for (var i = 0; i < array.Length; i++)
            {
                var min = i;
                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var lowerValue = array[min];
                    array[min] = array[i];
                    array[i] = lowerValue;
                }
            }
        }
    }
}
