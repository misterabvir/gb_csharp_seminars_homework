/*****************************************************
* Задача 29: Напишите программу, которая             *
* задаёт массив из 8 элементов и выводит их на экран.*
******************************************************/
void Print(int[] data)
{
    Console.Write("RESULT: [");
    for (int i = 0; i < data.Length; i++)
    {
        Console.Write($"{data[i]}, ");
    }
    Console.WriteLine("\b\b]");
}

//FIRST solution
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

//SECOND solution
int[] GetInput2()
{
    int quantity = 0;
    do{
        Console.Write("Enter quantity of elements in array: ");
    }while(!int.TryParse(Console.ReadLine(), out quantity) || quantity < 1);

    int[] input = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        int number = 0;
        do{
            Console.Write($"Enter value for {i + 1}: ");
        }while(!int.TryParse(Console.ReadLine(), out number));
        input[i] = number;
    }
    return input;
}

//////////////////////////////////////////////////////////////////
Console.WriteLine("FIRST sln:");
int[] array1 = GetInput();
Print(array1);
/*
OUTPUT=================================>
2,3 4, ,5,,12  52 , , , 0  8 ,,,,,, 7  5 
RESULT: [2, 3, 4, 5, 12, 52, 0, 8, 7, 5]
<=======================================
*/

//////////////////////////////////////////////////////////////////
Console.WriteLine("SECOND sln:");
int[] array2 = GetInput2();
Print(array2);
/*
OUTPUT=================================>
Enter quantity of elements in array: 8
Enter value for 1: 1
Enter value for 2: 2
Enter value for 3: 3
Enter value for 4: 4
Enter value for 5: 5
Enter value for 6: 6
Enter value for 7: 7
Enter value for 8: 8
RESULT: [1, 2, 3, 4, 5, 6, 7, 8]
<=======================================
*/