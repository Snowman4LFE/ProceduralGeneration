public class PG_Arrays
{

    public static int[] GenerateRandomBinaryArray(int arrayLength)
    {
        int[] tempArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            tempArray[i] = new Random().Next(0, 2);
        }

        return tempArray;
    }

    public static int[,] GenerateRandomBinaryArray2D(int arrayLength, int arrayHeight)
    {
        int[,] tempArray = new int[arrayLength, arrayHeight];

        for (int i = 0; i < arrayLength; i++)
        {
            for (int j = 0; j < arrayHeight; j++)
            {
                tempArray[i, j] = new Random().Next(0, 2);
            }
        }

        return tempArray;
  
    }

    public static int[] GenerateRandomIntArray(int arrayLength, int minValue, int maxValue)
    {
        int[] tempArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            tempArray[i] = new Random().Next(minValue, maxValue + 1);
        }

        return tempArray;
    }

    public static int[,] GenerateRandomIntArray2D(int arrayLength, int arrayHeight, int minValue, int maxValue)
    {
        int[,] tempArray = new int[arrayHeight, arrayLength];
        for (int i = 0; i < arrayHeight; i++)
        {
            for (int j = 0; j < arrayLength; j++)
            {
                tempArray[i, j] = new Random().Next(minValue, maxValue + 1);
            }
        }
        return tempArray;
    }
    public static int[] GenerateSequencedArray(int sequenceStart, int arrayLength, int iterationGap = 1)
    {
        int[] tempArray = new int[arrayLength];

        for (int i = 0; i < arrayLength; i++)
        {
            tempArray[i] = sequenceStart + i * iterationGap;
        }

        return tempArray;
    }

    public static int[][] GenerateSequencedArray2D(int sequenceStart, int arrayLength, int arrayHeight, int iterationGap = 1)
    {
        int[][] tempArray = new int[arrayHeight][];
        int arrayStart = sequenceStart;
        for (int i = 0; i < arrayHeight; i++)
        {
            tempArray[i] = GenerateSequencedArray(sequenceStart + (i * arrayLength * iterationGap), arrayLength, iterationGap);
        }
        return tempArray;
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write(array[array.Length - 1]);
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write(array[i, array.GetLength(1) - 1]);
            Console.WriteLine();
        }

    }


}