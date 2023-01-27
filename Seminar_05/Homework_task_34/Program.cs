/***************************************************
** Задача 34: Задайте массив заполненный          **
** случайными положительными трёхзначными числами.**
** Напишите программу, которая покажет            **
** количество чётных чисел в массиве.             **
***************************************************/
int[] GetRandom3DigitsArray()
{
    Random rand = new Random();
    int[] data = new int[rand.Next(5, 10)];
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = rand.Next(100, 1000);
    }
    return data;
}

int GetAmountOfEvenNumbers(int[] data)
{
    int count = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i] % 2 == 0) count++;
    }
    return count;
}


///////////////////////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Amount of even numbers: ");

//first
int[] array = GetRandom3DigitsArray();
int amount = GetAmountOfEvenNumbers(array);
Console.WriteLine($"[{string.Join(", ", array)}] --> {amount}");

//second (linq sugar)
int[] array2 = (new int[new Random().Next(5, 10)]).Select(item => new Random().Next(100, 1000)).ToArray();
int amount2 = array2.Where(item => item % 2 == 0).Count();
Console.WriteLine($"[{string.Join(", ", array2)}] --> {amount2}");

/*
OUTPUT====================================================
Amount of even numbers: 
[947, 488, 695, 117, 960] --> 2
[475, 111, 814, 220, 150] --> 3
==========================================================
Amount of even numbers: 
[321, 230, 531, 689, 949, 758, 342, 174, 393] --> 4
[564, 768, 260, 111, 104, 648, 337, 644] --> 6
==========================================================
*/