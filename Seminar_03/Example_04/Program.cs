/**********************************************************
* Задача №22                                              *
* Напишите программу, которая принимает на вход число (N) *
* и выдаёт таблицу квадратов чисел                        * 
* от 1 до N.                                              *
*                                                         *              
* 5 -> 1, 4, 9, 16, 25.                                   * 
* 2 -> 1,4                                                *  
***********************************************************/

int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.Write(i * i + ", ");
}
Console.WriteLine("\b\b ");


Console.WriteLine(String.Join(", ", Enumerable.Range(start: 1, count: num).Select(s => s * s)));