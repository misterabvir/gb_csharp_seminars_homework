/*
** Задача 54: Задайте двумерный массив. 
** Напишите программу, которая упорядочит по убыванию 
** элементы каждой строки двумерного массива.
*/

(int min, int max) Length = (5, 10);
(int min, int max) Range = (10, 100);

int[,] GetRandom2DArray()
{
    Random rand = new Random();
    int rows = rand.Next(Length.min, Length.max);
    int cols = rand.Next(Length.min, Length.max);
    int[,] array = new int[rows, cols];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            array[row, col] = rand.Next(Range.min, Range.max);
    return array;
}

void Print2DArray(int[,] data, string message)
{
    Console.WriteLine(message);
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
            Console.Write($"{data[row, col],3}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] RowSorter(int[,] data)
{
    for (int row = 0; row < data.GetLength(0); row++)
        for (int col = 0; col < data.GetLength(1); col++)
            for (int i = 0; i < data.GetLength(1) - 1 - col; i++) 
                if (data[row, i] < data[row, i + 1])
                    Swap(ref data[row, i], ref data[row, i + 1]);
    return data;
}

void Swap(ref int num1, ref int num2) => (num1, num2) = (num2, num1);

////////////////////////////////////////////////////////////////////////
int[,] array = GetRandom2DArray();
Print2DArray(data: array, message: "Unsorted:");
array = RowSorter(array);
Print2DArray(data: array, message: "Sorted:");


/*
    OUTPUT=================================
    Unsorted:
    50 95 53 28 60 56 54 86
    90 93 66 42 18 90 16 69
    32 44 51 75 35 53 53 81
    83 56 89 57 25 11 86 72
    99 63 54 68 90 16 20 12
    74 95 24 54 19 29 65 15
    79 22 26 74 17 16 24 90
    39 21 29 73 89 84 75 82

    Sorted:
    95 86 60 56 54 53 50 28
    93 90 90 69 66 42 18 16
    81 75 53 53 51 44 35 32
    89 86 83 72 57 56 25 11
    99 90 68 63 54 20 16 12
    95 74 65 54 29 24 19 15
    90 79 74 26 24 22 17 16
    89 84 82 75 73 39 29 21
    =========================================
    Unsorted:
    73 37 77 12 52 38 94
    58 55 80 21 28 43 19
    89 54 63 87 65 37 68
    43 75 35 49 14 92 97
    45 58 56 43 89 63 68
    94 10 67 99 88 73 86

    Sorted:
    94 77 73 52 38 37 12
    80 58 55 43 28 21 19
    89 87 68 65 63 54 37
    97 92 75 49 43 35 14
    89 68 63 58 56 45 43
    99 94 88 86 73 67 10
*/