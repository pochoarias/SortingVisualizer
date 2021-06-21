using System;

namespace SortingVisualizer.Persistance.Services.Sorting
{
    public class InsertionSortService : IInsertionSortService
    {
        private const string algorithm = "Insertion Sort";
        private readonly ILogger _logger;
        private readonly IArrayGeneratorService _arrayGeneratorService;
        public InsertionSortService(ILogger logger, IArrayGeneratorService arrayGeneratorService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _arrayGeneratorService = arrayGeneratorService ?? throw new ArgumentNullException(nameof(arrayGeneratorService));
        }


        public void Sort()
        {
            _arrayGeneratorService.RandomizeArray();
            _logger.Init(algorithm);
            InsertionSort();
            _logger.Stop();
        }


        private void InsertionSort()
        {
            int[] array = _arrayGeneratorService.GetArray();

            for (int i = 0; i < array.Length; i++)
            {
                var item = array[i];
                var currentIndex = i;

                while (currentIndex > 0 && array[currentIndex - 1] > item)
                {
                    array[currentIndex] = array[currentIndex - 1];
                    currentIndex--;
                }

                array[currentIndex] = item;
            }
        }
    }
}
