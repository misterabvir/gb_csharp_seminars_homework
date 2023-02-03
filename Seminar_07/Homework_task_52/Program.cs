/**************************************************************
** Задача 52. Задайте двумерный массив из целых чисел.        *
** Найдите среднее арифметическое элементов в каждом столбце. *
** Например, задан массив:                                    *
** 1 4 7 2                                                    *
** 5 9 2 3                                                    *
** 8 4 2 4                                                    *
** Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.  *
***************************************************************/

(int x, int y) GetInput()
{
    int[] size = new int[0];
    do
    {
        Console.Write("Enter amount of rows and cols separated by space: ");
        size = Console.ReadLine()?
            .Split(',', ' ')
            .Where(item => int.TryParse(item, out _))
            .Select(item => Convert.ToInt32(item))
            .ToArray() ?? new int[0];
    } while (size.Length < 2);
    return (size[0], size[1]);
}

int[,] GetArray((int rows, int cols) size)
{
    int[,] array = new int[size.rows, size.cols];

    for (int row = 0; row < size.rows; row++)
        for (int col = 0; col < size.cols; col++)
            array[row, col] = new Random().Next(0, 100);

    return array;
}

void Print2DArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],8}");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(new string('=', array.Length * 8));
    for (int cell = 0; cell < array.Length; cell++)
    {
        Console.Write($"{array[cell],8:#0.##}");
    }
    Console.ResetColor();
}

double[] GetColumnsAverages(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(1)];
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
               averages[col] += matrix[row, col];
        }
        averages[col] /= matrix.GetLength(0);
    }
    return averages;
}

///////////////////////////////////////////////////////////////////////////
(int rows, int cols) size = GetInput();
int[,] numbers = GetArray(size);
Print2DArray(numbers);
double[] columnsAverages = GetColumnsAverages(numbers);
PrintArray(columnsAverages);

/*
OUTPUT==========================================================================
Enter amount of rows and cols separated by space: 10 10
      67      79      80      29      23      85      94      96       7       9
      58      31      42      63      98      25      79      64      87       7
      20      25       3       1      36      75      10      67      70      35
      39       4      19      21      35       2      34      13      36      94
      77      79      25      60      47      17      39      82       6      92
      61      26       3      62      87      22      42      67      73      75
      65      46       7      23      11      30      47      90      71      89
      94      81      30      59      93      91       3      21      89      92
      43      22      10      12      94      18      49      94      72      61
      82      92      98      94      19      23      74      56      47       5
================================================================================
    60.6    48.5    31.7    42.4    54.3    38.8    47.1      65    55.8    55.9

--------------------------------------------------------------------------------
Enter amount of rows and cols separated by space: 2 2
      35       5
      68      86
================
    51.5    45.5
---------------------------------------------------------------------------------
*/