using System;

namespace SortingVisualizer.Persistance.Services.Sorting
{
    public class BubbleSortService : IBubbleSortService
    {
        private const string algorithm = "Bubble Sort";
        private readonly ILogger _logger;
        private readonly IArrayGeneratorService _arrayGeneratorService;
        public BubbleSortService(ILogger logger, IArrayGeneratorService arrayGeneratorService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _arrayGeneratorService = arrayGeneratorService ?? throw new ArgumentNullException(nameof(arrayGeneratorService));
        }

        public void Sort()
        {
            _arrayGeneratorService.RandomizeArray();
            _logger.Init(algorithm);
            BubbleSort();
            _logger.Stop();
        }

        private void BubbleSort()
        {
            int[] array = _arrayGeneratorService.GetArray();
            int i, j;
            int N = array.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temporary;

                        temporary = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temporary;
                    }
                }
            }
        }


    }
}
