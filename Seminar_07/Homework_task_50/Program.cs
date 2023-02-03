/*************************************************************************************
** Задача 50. Напишите программу,                                                    *
** которая на вход принимает позиции элемента в двумерном массиве,                   *
** и возвращает значение этого элемента или же указание, что такого элемента нет.    *   
** Например, задан массив:                                                           *
** 1 4 7 2                                                                           *
** 5 9 2 3                                                                           *
** 8 4 2 4                                                                           *
** 1 7 -> такого числа в массиве нет                                                 *
** 1 1 -> 9                                                                          *
**************************************************************************************/

(int x, int y) GetInput(string message)
{
    int[] size = new int[0];
    do
    {
        Console.Write(message);
        size = Console.ReadLine()?.Split(',', ' ').Where(item => int.TryParse(item, out _)).Select(item => Convert.ToInt32(item)).ToArray() ?? new int[0];
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

void Print(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col],4}");
        }
        Console.WriteLine();
    }
}

bool Search(int[,] array, (int r, int c) pos, out int res)
{
    res = default(int); // must be assigned a value due to the modifier 'out'
    if (pos.r >= array.GetLength(0) || pos.r < 0) return false;
    if (pos.c >= array.GetLength(1) || pos.c < 0) return false;
    res = array[pos.r, pos.c];
    return true;
}

////////////////////////////////////////////////////////////////////////////////////////////////////
(int rows, int cols) size = GetInput(message: "Enter amount of rows and cols separated by space: ");
int[,] numbers = GetArray(size);
Print(numbers);
(int row, int col) position = GetInput(message: "Enter position (row col) separated by space: ");
if (Search(numbers, position, out int result))
    Console.WriteLine($"Result is: {result}");
else
    Console.WriteLine("There is no number in the array for this position");

/*
OUTPUT====================================================
Enter amount of rows and cols separated by space: 3 4
  30  15  97   6
  14  30  51  75
  92  85  66  96
Enter position (row col) separated by space: 2 2
Result is: 66
==========================================================
Enter amount of rows and cols separated by space: 7 10
   5  42  56  28  51  56  25  28  85  43
  98  99  41  90  67  37  74  41  35  16
  97   9  35  74  44  62  85  50  97  74
  37  13  76  52  42  11  79   3  88  65
  33  66   7   5  43  80  80  11  62  94
  14  19  55  46  35  65  33  59  18  18
  86  87  25  97  67  36   1  54  91  59
Enter position (row col) separated by space: 5 2
Result is: 55
==========================================================
Enter amount of rows and cols separated by space: 4 4
  58  38  33  48
   7  26  35  30
  89  83  21  82
  75  96  37   3
Enter position (row col) separated by space: 5 5
There is no number in the array for this position
*/
