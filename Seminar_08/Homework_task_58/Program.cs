/*
** Задача 58: Задайте две матрицы. 
** Напишите программу, которая будет 
** находить произведение двух матриц.
*/

(int min, int max) Length = (2, 5);
(int min, int max) Range = (0, 10);

int[,] GetRandom2DArray(int rows = -1, int cols = -1)
{
    Random rand = new Random();
    rows = rows == -1 ? rand.Next(Length.min, Length.max) : rows;
    cols = cols == -1 ? rand.Next(Length.min, Length.max) : cols;
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
            Console.Write($"{data[row, col],5}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Multiply(int[,] array1, int[,] array2)
{

    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            //C[i,j] = Sum(A[i,r] * B[r,j]) --> 0...r...n
            for (int r = 0; r < array1.GetLength(1); r++)
            {
                result[i, j] += array1[i, r] * array2[r, j];
            }
        }
    }
    return result;
}

/////////////////////////////////////////////////////////////////////
var matrix1 = GetRandom2DArray();
var matrix2 = GetRandom2DArray(rows: matrix1.GetLength(1));
Print2DArray(data: matrix1, message: "Matrix 1: ");
Print2DArray(data: matrix2, message: "Matrix 2: ");
var resultMatrix = Multiply(array1: matrix1, array2: matrix2);
Print2DArray(data: resultMatrix, message: "Result matrix: ");

/*
    OUTPUT================================
    Matrix 1: 
    8    8    9    4
    3    4    3    8

    Matrix 2: 
    5    1    8    8
    2    4    9    4
    7    5    4    9
    9    2    0    2

    Result matrix: 
    155   93  172  185
    116   50   72   83

    Протестировал на реальных не рандомных примерах, результат совпадает.
*/