
public class PG_1D_Generation
{


    public static void RandomTerrainGeneration(int arrayLength = 125, int minValue = 0, int maxValue = 50)
    {

        int[] array = PG_Arrays.GenerateRandomIntArray(arrayLength, minValue, maxValue);

        PG_Arrays.PrintArray(array);

        Console.WriteLine();
        Console.WriteLine();

        PrintAsTerrain(array, minValue, maxValue);

    }

    public static void PrintAsTerrain(int[] array, int minValue, int maxValue)
    {
        for (int i = maxValue; i >= minValue; i--)
        {
            for(int j = 0; j < array.Length - 1; j++)
            {
                if (array[j] >= i)
                {
                    Console.Write("# ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            if (array[array.Length - 1] >= i)
            {
                Console.Write("#");
            }
            else
            {
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }   
}
