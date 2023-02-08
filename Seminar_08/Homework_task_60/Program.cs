/*
** Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
** Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/

(int min, int max) Length = (2, 5);
(int min, int max) Range = (0, 10);

int[,,] GetRandom3DArray()
{
    Random rand = new Random();
    int rows = rand.Next(Length.min, Length.max);
    int cols = rand.Next(Length.min, Length.max);
    int levels = rand.Next(Length.min, Length.max);
    int[,,] array = new int[rows, cols, levels];
    for (int row = 0; row < rows; row++)
        for (int col = 0; col < cols; col++)
            for (int level = 0; level < levels; level++)
                array[row, col, level] = rand.Next(Range.min, Range.max);
    return array;
}

void Print(int[,,] matrix3)
{
    for (int row = 0; row < matrix3.GetLength(0); row++)
    {
        for (int col = 0; col < matrix3.GetLength(1); col++)
        {
            for (int level = 0; level < matrix3.GetLength(2); level++)
            {
                Console.Write($"M[{row},{col},{level}] = {matrix3[row, col, level], -3}");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}


int[,,] array3D = GetRandom3DArray();
Print(array3D);

/*
    OUTPUT================================================
    M[0,0,0] = 7  M[0,0,1] = 0  M[0,0,2] = 2  M[0,0,3] = 6  
    M[0,1,0] = 9  M[0,1,1] = 7  M[0,1,2] = 0  M[0,1,3] = 5
    M[0,2,0] = 1  M[0,2,1] = 9  M[0,2,2] = 5  M[0,2,3] = 2
    M[0,3,0] = 6  M[0,3,1] = 9  M[0,3,2] = 5  M[0,3,3] = 7

    M[1,0,0] = 2  M[1,0,1] = 2  M[1,0,2] = 7  M[1,0,3] = 9
    M[1,1,0] = 8  M[1,1,1] = 3  M[1,1,2] = 9  M[1,1,3] = 0
    M[1,2,0] = 7  M[1,2,1] = 3  M[1,2,2] = 1  M[1,2,3] = 4
    M[1,3,0] = 7  M[1,3,1] = 2  M[1,3,2] = 1  M[1,3,3] = 9

    M[2,0,0] = 5  M[2,0,1] = 5  M[2,0,2] = 3  M[2,0,3] = 6
    M[2,1,0] = 4  M[2,1,1] = 8  M[2,1,2] = 6  M[2,1,3] = 0
    M[2,2,0] = 9  M[2,2,1] = 2  M[2,2,2] = 8  M[2,2,3] = 6
    M[2,3,0] = 0  M[2,3,1] = 3  M[2,3,2] = 2  M[2,3,3] = 3
    ======================================================

    M[0,0,0] = 7  M[0,0,1] = 9  M[0,0,2] = 5  
    M[0,1,0] = 3  M[0,1,1] = 9  M[0,1,2] = 9

    M[1,0,0] = 7  M[1,0,1] = 4  M[1,0,2] = 6
    M[1,1,0] = 5  M[1,1,1] = 7  M[1,1,2] = 8

*/