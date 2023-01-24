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
    int[] input = {};
    do{
        Console.Write("Enter two numbers separated by a comma or space: ");
        input = (Console.ReadLine() ?? "")
                            .Split(',', ' ')
                            .Where(w=>int.TryParse(w, out _))
                            .Select(s=>Convert.ToInt32(s))
                            .ToArray();  
    }while(input.Length < 2 || input[1] < 0);
    return (input[0], input[1]);
}
 
/*******************************************************************
    FORMAT: 
    1) |5, 3| - без скобок конечно)) преобразуется в 5 ^ 3 = 125
    2) между числами может быть любое количество запятых или пробелов
    3) степень больше либо равно нолю
********************************************************************/

var data = GetInput();
Console.WriteLine($"{data.number} ^ {data.pow} = {Pow(data.number, data.pow)}");