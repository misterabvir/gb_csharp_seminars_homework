/*************************************************************
* Напишите программу, которая принимает на вход              *
* пятизначное число и проверяет, является ли оно палиндромом.*
* 14212 -> нет                                               *
* 12821 -> да                                                *
* 23432 -> да                                                *
**************************************************************/

int GetInput()
{
    int input;
    do{
        Console.Clear();
        Console.WriteLine("Input 5 digits number: ");
    }while(!int.TryParse(Console.ReadLine(), out input) || input < 10000 || input >= 100000);
    return input;
}


int number = GetInput();
int[] array = new int[5]; // this is better than using 4 variables
for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 10;
    number /= 10; 
}

if(array[0] == array[4] && array[1] == array[3]) Console.WriteLine("This is palindrome");
else Console.WriteLine("It's not a palindrome");

