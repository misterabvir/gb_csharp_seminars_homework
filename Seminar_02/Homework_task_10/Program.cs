/********************************************************************
* Задача 10: Напишите программу, которая принимает на вход          * 
* трёхзначное число и на выходе показывает вторую цифру этого числа.*
*                                                                   *
* 456 -> 5                                                          *
* 782 -> 8                                                          *
* 918 -> 1                                                          *
********************************************************************/

int number = 0;
do{
    Console.Clear();
    Console.WriteLine("Please enter a 3 digit number: ");
}while(!int.TryParse(Console.ReadLine(), out number) || number < 100 || number >= 1000);

Console.WriteLine("Second digit in number {0} is {1}", number, (number / 10) % 10);
