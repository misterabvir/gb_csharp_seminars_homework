/********************************************************
** Задача 41: Пользователь вводит с клавиатуры M чисел. *
** Посчитайте, сколько чисел больше 0 ввёл пользователь.*
*********************************************************/

int[] GetArray()
{
    int[] data = {};
    do{
        data = Console.ReadLine()?.Split(' ', ',')
                .Where(item => int.TryParse(item, out _))
                .Select(item => Convert.ToInt32(item))
                .ToArray() ?? new int[0];
    }while(data.Length == 0);
    return data;
}

int GetAmountOfNatural(int[] data)
{
    int count = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if(data[i] > 0) count++;
    }
    return count;
}
////////////////////////////////////////////////////////
Console.WriteLine("Enter some numbers:");
int[] array = GetArray();
Console.Write($"[{string.Join(" ", array)}] --->");
int natural = GetAmountOfNatural(array);
Console.WriteLine(" amount of positive: {0}", natural);

/* 
OUTPUT====================================================
Enter some numbers:
23432 534 2 -3213,3 -9,,,213
[23432 534 2 -3213 3 -9 213] ---> amount of positive: 5
==========================================================
Enter some numbers:
-9 003 2,,,,,31123,4 3
[-9 3 2 31123 4 3] ---> amount of positive: 5
==========================================================
Enter some numbers:
34k5 1o01 1 -0
[1 0] ---> amount of positive: 1
==========================================================
*/
