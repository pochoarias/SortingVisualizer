namespace SortingVisualizer
{
    public interface IArrayGeneratorService
    {
        const int DEFAULTSIZE = 1000;
        const int MAXALLOWEDNUMBER = 1000;
        const int MINALLOWEDNUMBER = 0;
        //TO-DO: Check if it's a good idea to have properties in the interface

        int[]  RandomArray { get; } 
        int MaxNumber { get; set; }
        int MinNumber { get; set; }

        int[] GetArray();
        void RandomizeArray();
        void PrintArray();
    }
}
