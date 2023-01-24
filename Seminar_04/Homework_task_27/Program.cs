/***************************************************
* Задача 27: Напишите программу, которая принимает *
* на вход число и выдаёт сумму цифр в числе.       *
****************************************************/
int SumOfDigits(int data)
{
    int sum = 0;
    while(data > 0)
    {
        sum += data % 10;
        data /= 10;
    }
    return sum;
}

int GetInput()
{
    int input = 0;   
    do{
        Console.Write($"Enter some number (between {int.MinValue} and {int.MaxValue}): ");
    }while(!int.TryParse(Console.ReadLine(), out input));
    return input;
}

/////////////////////////////////////////////////////////////////////////////////////////
int number = GetInput();
Console.WriteLine($"The sum of the digits in number {number} is {SumOfDigits(number)}"); 

/*
OUTPUT==========================================================>
Enter some number (between -2147483648 and 2147483647): 123456789
The sum of the digits in number 123456789 is 45
<================================================================
*/