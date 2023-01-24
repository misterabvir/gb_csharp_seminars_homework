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
        Console.WriteLine($"Enter some number (between {int.MinValue} and {int.MaxValue}): ");
    }while(!int.TryParse(Console.ReadLine(), out input));
    return input;
}

/////////////////////////////////////////////////////////////////////////////////////////
int number = GetInput();
Console.WriteLine($"The sum of the digits in number {number} is {SumOfDigits(number)}"); 

