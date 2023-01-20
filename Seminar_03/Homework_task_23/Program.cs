/*********************************************************
* Задача 23 Напишите программу, которая принимает на вход* 
* число (N) и выдаёт таблицу кубов чисел от 1 до N.      *
* 3 -> 1, 8, 27                                          *
* 5 -> 1, 8, 27, 64, 125                                 *
**********************************************************/
int GetInput()
{
    int input;
    do
    {
        Console.Clear();
        Console.Write("Enter your positive number: ");
    } while (!int.TryParse(Console.ReadLine(), out input) || input < 1);
    return input;
}


int number = GetInput();
Console.Write("First solution:  ");
for (int i = 1; i <= number; i++)
{
    Console.Write(Math.Pow(i, 3) + ", ");
}
Console.WriteLine("\b\b ");

Console.Write("Second solution: ");
Console.WriteLine(String.Join(", ", Enumerable.Range(start: 1, count: number).Select(s => s * s * s)));