public class PG_2D_Generation
{
    public static void RandomTerrainGeneration(int arrayLength = 50, int arrayHeight = 50, int minValue = 0, int maxValue = 9)
    {

        int[,] array = PG_Arrays.GenerateRandomIntArray2D(arrayLength, arrayHeight, minValue, maxValue);

        PG_Arrays.PrintArray(array);

        Console.WriteLine();
        Console.WriteLine();

    }

    public static void ProceduralGeneration2D(int arrayLength = 50, int arrayHeight = 50, int minValue = 1, int maxValue = 9)
    {
        Random random = new Random();

        int startingIndex = random.Next(0, arrayLength);
        int startingHeight = random.Next(0, arrayHeight);
        int startingValue = random.Next(minValue, maxValue + 1);
        int[,] array = new int[arrayLength, arrayHeight];

        int currentIndex = startingIndex;
        int currentHeight = startingHeight;
        int currentValue = startingValue;
        int delta;


        array[currentIndex, currentHeight] = currentValue;

        //Check if neighbors are empty
        //Choose a random empty direction
        //Move to that direction
        //Set the value of the new position to the current value





        PG_Arrays.PrintArray(array);


    }


    }

