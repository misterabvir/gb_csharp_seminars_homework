/*****************************************************
* Задача 29: Напишите программу, которая             *
* задаёт массив из 8 элементов и выводит их на экран.*
******************************************************/

int[] GetInput()
{
    int[] input = { };
    do
    {
        Console.Write("Enter several (more than one) numbers separated by a comma or space: ");
        input = (Console.ReadLine() ?? "")
                            .Split(',', ' ')
                            .Where(w => int.TryParse(w, out _))
                            .Select(s => Convert.ToInt32(s))
                            .ToArray();
    } while (input.Length < 2 || input[1] < 0);
    return input;
}

int[] array = GetInput();
Console.WriteLine($"RESULT: [{string.Join(", ", array)}]");

/*
OUTPUT=================================>
2,3 4, ,5,,12  52 , , , 0  8 ,,,,,, 7  5 
RESULT: [2, 3, 4, 5, 12, 52, 0, 8, 7, 5]
<=======================================
*/