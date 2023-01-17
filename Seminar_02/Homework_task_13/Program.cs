/*************************************************************
* Задача 13: Напишите программу, которая выводит третью цифру* 
* заданного числа или сообщает, что третьей цифры нет.       *
*   645 -> 5                                                 *
*    78 -> третьей цифры нет                                 *
* 32679 -> 6                                                 *
**************************************************************/

//solution with string manipulation... cheating... but it's work
string GetThirdStringDigit(string data) => data.Length >= 3 ? data[2].ToString() : "no third digit";

//solution with numbers
string GetThirdIntDigit(int data)
{
    int lim = 100;
    if(data < lim) return "no third digit";    
    while(lim < data)               // for 3 digit number -> 1000, for 4 -> 10000, for 5 -> 100000 .... 
        lim *= 10;    
    lim /= 1000;                    // for 3 digit number -> 1,    for 4 -> 10,    for 5 -> 100 ....   
    return ((data / lim) % 10).ToString();
}


Console.Write("Input your number: ");
string? sNumber = Console.ReadLine();
int iNumber = Convert.ToInt32(sNumber);

//check first cheating way 
Console.WriteLine($"{sNumber ?? ""} -> {GetThirdStringDigit(sNumber ?? "")}"); //operator ?? to avoid throwing warnings
//check second way 
Console.WriteLine($"{iNumber} -> {GetThirdIntDigit(iNumber)}");