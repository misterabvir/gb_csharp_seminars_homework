/*************************************************************************                       
** Задача 4: Напишите программу, которая принимает на вход три числа    **                            
** и выдаёт максимальное из этих чисел.                                 **                            
**                                                                      **                          
**  2, 3,  7 -> 7                                                       **
** 44, 5, 78 -> 78                                                      **
** 22, 3,  9 -> 22                                                      **
**************************************************************************/

Console.Write("Input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

 
// simplest solution in oneline
// with blessed LINQ
Console.WriteLine("Maximum is {0}", new int[] {number1, number2, number3}.Max());

//more readable solution
if (number1 < number2) number1 = number2;
if (number1 < number3) number1 = number3;

Console.WriteLine($"Maximum is {number1}");


