/****************************************************************
* Задача 25: Напишите цикл, который принимает на вход           *
* два числа (A и B) и возводит число A в натуральную степень B. *
****************************************************************/

int Pow(int number, int count)
{
    int result = 1;
    for (int i = 0; i < count; i++)
    {
        result *= number;
    }
    return result;
}

(int number, int pow) GetInput()
{
    int[] input = { };
    do
    {
        Console.Write("Enter two numbers separated by a comma or space: ");
        input = (Console.ReadLine() ?? "")
                            .Split(',', ' ')
                            .Where(w => int.TryParse(w, out _))
                            .Select(s => Convert.ToInt32(s))
                            .ToArray();
    } while (input.Length < 2 || input[1] < 0);
    return (input[0], input[1]);
}

////////////////////////////////////////////////////////////////
var data = GetInput();
Console.WriteLine($"{data.number} ^ {data.pow} = {Pow(data.number, data.pow)}");

/*
OUTPUT=========================================================>
Enter two numbers separated by a comma or space: 5 6
5 ^ 6 = 15625
OUTPUT=========================================================>
Enter two numbers separated by a comma or space: 2,3
2 ^ 3 = 8
OUTPUT=========================================================>
Enter two numbers separated by a comma or space: 4,,,,   ,,,,3
4 ^ 3 = 64
<===============================================================
*/