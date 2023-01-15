/************************************************************************
**  Задача 8: Напишите программу, которая на вход принимает число (N), ** 
**  а на выходе показывает все чётные числа от 1 до N.                 **     
**                                                                     **
**   5 -> 2, 4                                                         **
**   8 -> 2, 4, 6, 8                                                   **
*************************************************************************/

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
while(number > 0 ? count <= number : count >= number) // if the number is greater than zero and if less
{
    if(count % 2 == 0) 
    {
        Console.Write($"{count}, "); 
    }
    count = number > 0 ? count + 1 : count - 1;  
}
Console.Write($"\b\b ");

