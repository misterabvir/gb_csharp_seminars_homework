/*
 * Задача 66: Задайте значения M и N. 
 * Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
 */

int min = new Random().Next(1, 6);              
int max = new Random().Next(min + 1, 21);
Console.WriteLine($"M = {min}; N = {max} -> {AmountOfRange(min, max)}");

int AmountOfRange(int min, int max)
{
    if (min == max) return max;
    return min + AmountOfRange(min + 1, max);
}

/*
 * OUTPUT=============================
 * M = 3; N = 13 -> 88
 * ===================================
 * M = 1; N = 3 -> 6
 */