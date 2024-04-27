public class PG_2D_Generation
{

    // Using a 3D array to store the map data
    // First dimension is the y-axis
    // Second dimension is the x-axis
    // Third dimesion is a pair of values
    // The first value is displayed value
    // The second value is the entropy value
    //
    // The array is intialized with 0 for all displayed values
    // and all entropy values will be set to the total number of available tiles.
    //

   

    public static int[,,] GenerateEmptyMapData(int width, int height, int numTiles)
    {
        int[,,]? mapData;

        mapData = new int[height, width, 2];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                mapData[y, x, 0] = 0;
                mapData[y, x, 1] = numTiles;
            }
        }

        return mapData;
    }

    public static void PrintMapDisplayData(int[,,] mapData)
    {
        for (int y = 0; y < mapData.GetLength(0); y++)
        {
            for (int x = 0; x < mapData.GetLength(1); x++)
            {
                Console.Write(mapData[y, x, 0] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void PrintMapEntropyData(int[,,] mapData)
    {
        for (int y = 0; y < mapData.GetLength(0); y++)
        {
            for (int x = 0; x < mapData.GetLength(1); x++)
            {
                Console.Write(mapData[y, x, 1] + " ");
            }
            Console.WriteLine();
        }
    }


}


