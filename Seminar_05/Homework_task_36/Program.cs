/*************************************************************************
** Задача 36: Задайте одномерный массив, заполненный случайными числами. *
** Найдите сумму элементов, стоящих на нечётных позициях.                *
**************************************************************************/

int[] GetRandomArray()
{
    Random rand = new Random();
    int[] data = new int[rand.Next(5, 10)];
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = rand.Next(1, 10);
    }
    return data;
}

int GetSumOfNumbersInOddPosition(int[] data)
{
    int sum = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (i % 2 == 1) sum += data[i];
    }
    return sum;
}

///////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Sum of numbers in odd positions: ");

//first
int[] array = GetRandomArray();
int quantity = GetSumOfNumbersInOddPosition(array);
Console.WriteLine($"[{string.Join(", ", array)}] --> {quantity}");

//second (linq sugar)
int[] array2 = (new int[new Random().Next(5, 10)]).Select(item => new Random().Next(1, 10)).ToArray();
int quantity2 = array2.Where((item, index) => index % 2 == 1).Sum();
Console.WriteLine($"[{string.Join(", ", array2)}] --> {quantity2}");

/*
OUTPUT====================================================
Sum of numbers in odd positions: 
[9, 8, 5, 9, 6, 5] --> 22
[5, 2, 3, 3, 7] --> 2
==========================================================
Sum of numbers in odd positions: 
[2, 7, 1, 6, 1, 8] --> 21
[5, 7, 8, 1, 5, 8, 7, 8] --> 24
==========================================================
*/