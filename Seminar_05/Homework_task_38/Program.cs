/***************************************************************************
**   Задача 38: Задайте массив целых чисел.                                *
**   Найдите разницу между максимальным и минимальным элементов массива.   *
****************************************************************************/

int[] GetRandomArray()
{
    Random rand = new Random();
    int[] data = new int[rand.Next(5, 10)];
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = rand.Next(10, 100);
    }
    return data;
}

int GetDifferenceBetweenMaxAndMin(int[] data)
{
    int max = data[0];
    int min = data[0];
    for (int i = 1; i < data.Length; i++)
    {
        if (max < data[i]) max = data[i];
        if (min > data[i]) min = data[i];
    }
    return max - min;
}

///////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Difference between minimum and maximum number in an array: ");

//first
int[] array = GetRandomArray();
int difference = GetDifferenceBetweenMaxAndMin(array);
Console.WriteLine($"[{string.Join(", ", array)}] --> {difference}");

//second (linq sugar)
int[] array2 = (new int[new Random().Next(5, 10)]).Select(s => new Random().Next(10, 100)).ToArray();
int difference2 = array2.Max() - array2.Min();
Console.WriteLine($"[{string.Join(", ", array2)}] --> {difference2}");

/*
OUTPUT====================================================
Difference between minimum and maximum number in an array: 
[91, 68, 16, 96, 48, 55, 28, 61, 46] --> 80
[58, 97, 78, 43, 10, 22, 16] --> 87
==========================================================
Difference between minimum and maximum number in an array: 
[97, 46, 39, 81, 36, 14, 37, 59, 76] --> 83
[20, 51, 91, 45, 55] --> 71
==========================================================
*/