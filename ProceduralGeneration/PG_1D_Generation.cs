
public class PG_1D_Generation
{


    public static void RandomTerrainGeneration(int arrayLength = 125, int minValue = 0, int maxValue = 9)
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

    public static void ProceduralGeneration1D(int arrayLength = 125, int minValue = 0, int maxValue = 9)
    {
        Random random = new Random();

        int startingIndex = random.Next(0,arrayLength);
        int currentIndex = startingIndex;
        int startingValue = random.Next(minValue, maxValue + 1);
        int[] array = new int[arrayLength];
        int delta;
        int currentValue = startingValue;
        bool isLeftSideDone = false;

        array[currentIndex] = currentValue;

        while (currentIndex < arrayLength)
        {

            if (currentIndex == 0)
            {
                currentIndex = startingIndex + 1;
                isLeftSideDone = true;
            }

            if (currentIndex >= arrayLength  - 1)
            {
                break;
            }

            if (currentIndex <= startingIndex)
            {
                 currentIndex--;
            }
            else
            {
                if (isLeftSideDone)
                {
                    currentIndex--;
                    isLeftSideDone = false;
                }
                currentIndex++;
            }

            delta = random.Next(-1, 2);
            currentValue += delta;

            if (currentValue < minValue)
            {
                currentValue = minValue;
            }
            else if (currentValue > maxValue)
            {
                currentValue = maxValue;
            }

            array[currentIndex] = currentValue;

        }




        PG_Arrays.PrintArray(array);

        Console.WriteLine();
        Console.WriteLine();

        PrintAsTerrain(array, minValue, maxValue);

    }
}
