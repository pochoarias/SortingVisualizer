using System;

namespace SortingVisualizer
{
    public class ArrayGeneratorService : IArrayGeneratorService
    {
        public int[] RandomArray { get; set; }

        private int _maxNumber;
        public int MaxNumber
        {
            get => _maxNumber;
            set
            {
                _maxNumber = value > IArrayGeneratorService.MAXALLOWEDNUMBER ? IArrayGeneratorService.MAXALLOWEDNUMBER : value;
            }
        }

        private int _minNumber;
        public int MinNumber
        {
            get => _minNumber;
            set
            {
                _minNumber = value < IArrayGeneratorService.MINALLOWEDNUMBER ? IArrayGeneratorService.MINALLOWEDNUMBER : value;
            }
        }


        public ArrayGeneratorService(uint defaultSize = IArrayGeneratorService.DEFAULTSIZE,
                                        int minNumber = IArrayGeneratorService.MINALLOWEDNUMBER,
                                        int maxNumber = IArrayGeneratorService.MAXALLOWEDNUMBER)
        {
            RandomArray = new int[defaultSize];
            MinNumber = minNumber;
            MaxNumber = maxNumber;
        }

        public void RandomizeArray()
        {
            var seed = Guid.NewGuid().GetHashCode();
            var randNum = new Random(seed);
            for (int i = 0; i <= GetArray().Length - 1; i++)
            {
                GetArray()[i] = randNum.Next(MinNumber, MaxNumber);
            }
        }

        public void PrintArray()
        {
            Console.WriteLine("[{0}]", string.Join(", ", GetArray()));
        }

        public int[] GetArray()
        {
            return RandomArray;
        }
    }
}
