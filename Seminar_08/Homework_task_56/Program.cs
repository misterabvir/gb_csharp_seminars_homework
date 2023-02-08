/*
** Задача 56: Задайте прямоугольный двумерный массив. 
** Напишите программу, которая будет находить строку 
** с наименьшей суммой элементов.
*/


(int min, int max) Length = (3, 7);
(int min, int max) Range = (0, 10);

int[,] GetRandom2DArray()
{
    Random rand = new Random();
    int rows = rand.Next(Length.min, Length.max);
    int cols = 0;
    do
    {
        cols = rand.Next(Length.min, Length.max);
    } while (rows == cols);    
    int[,] array = new int[rows, cols];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            array[row, col] = rand.Next(Range.min, Range.max);
    return array;
}

void Print2DArray(int[,] data)
{
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
            Console.Write($"{data[row, col],3}");
        Console.WriteLine();
    }
}

int GetIndexRowWithLowestSum(int[,] data)
{
    int lowest = 0;
    int indexRow = 0;
    int sum = 0;
    for (int row = 0; row < data.GetLength(0); row++)
    {
        for (int col = 0; col < data.GetLength(1); col++)
        {
            sum += data[row, col];
        }
        if (row == 0) lowest = sum;
        if (sum < lowest)
        {
            lowest = sum;
            indexRow = row;
        }
        sum = 0;
    }
    return indexRow;
}


/////////////////////////////////////////////////////////////////////
int[,] array = GetRandom2DArray();
Print2DArray(data: array);
int lowSum = GetIndexRowWithLowestSum(data: array);
Console.WriteLine($"Lowest sum in row with index {lowSum}");

/*
    OUTPUT====================================
    4  7  0
    7  2  1
    Lowest sum in row with index 1
    ==========================================
    7  5  0  0
    5  5  9  4
    6  0  7  2
    Lowest sum in row with index 0
    ==========================================
    6  8  5  9  1
    2  0  7  3  7
    8  2  4  7  2
    Lowest sum in row with index 1
*/
