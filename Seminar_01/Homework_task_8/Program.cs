/************************************************************************
**  Задача 8: Напишите программу, которая на вход принимает число (N), ** 
**  а на выходе показывает все чётные числа от 1 до N.                 **     
**                                                                     **
**   5 -> 2, 4                                                         **
**   8 -> 2, 4, 6, 8                                                   **
*************************************************************************/

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

// more simple solution will be when use FOR, 
// but this WHILE-solution is not much larger and no less readable

int count = 1;
while(count <= number)
{
    if(count % 2 == 0) 
    {
        Console.Write($"{count}, "); 
    }
    count++;  
}
Console.Write($"\b\b ");

