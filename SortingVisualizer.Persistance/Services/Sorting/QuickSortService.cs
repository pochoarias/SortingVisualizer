using System;

namespace SortingVisualizer.Persistance.Services.Sorting
{
    public class QuickSortService : IQuickSortService
    {
        private const string algorithm = "Quick Sort";
        private readonly ILogger _logger;
        private readonly IArrayGeneratorService _arrayGeneratorService;
        public QuickSortService(ILogger logger, IArrayGeneratorService arrayGeneratorService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _arrayGeneratorService = arrayGeneratorService ?? throw new ArgumentNullException(nameof(arrayGeneratorService));
        }

        public void Sort()
        {
            _arrayGeneratorService.RandomizeArray();
            _logger.Init(algorithm);
            QuickSort();
            _logger.Stop();

        }

        private void QuickSort()
        {
            int[] array = _arrayGeneratorService.GetArray();
            QuickSort(array, 0, array.Length - 1);
        }

        private int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        //TO-DO: Create utils/helpers
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }


    }
}
