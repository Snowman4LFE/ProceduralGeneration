
//int[][] array = PG_Arrays.GenerateSequencedArray2D(1, 100, 50, 50);

//int[] array = PG_Arrays.GenerateRandomIntArray(50, 0, 9);

//PG_Arrays.PrintArray(array);


int[,,] emptyMap = PG_2D_Generation.GenerateEmptyMapData(50, 50, 9);

PG_2D_Generation.PrintMapDisplayData(emptyMap);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

PG_2D_Generation.PrintMapEntropyData(emptyMap);


