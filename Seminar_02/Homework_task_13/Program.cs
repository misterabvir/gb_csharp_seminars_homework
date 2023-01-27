/*************************************************************
* Задача 13: Напишите программу, которая выводит третью цифру* 
* заданного числа или сообщает, что третьей цифры нет.       *
*   645 -> 5                                                 *
*    78 -> третьей цифры нет                                 *image.png
* 32679 -> 6                                                 *
**************************************************************/

//solution with string manipulation... cheating... but it's work
string GetThirdDigitFromString(string data) => data.Length >= 3 ? data[2].ToString() : "no third digit";

//solution with numbers
string GetThirdDigitFromInteger(int data)
{
    if(data < 100) return "no third digit";    
    while(data > 1000)                
        data /= 10;                   
    return (data % 10).ToString();
}

/*******************************************************************************************************/

Console.Write("Input your number: ");

//check first cheating way 
string? sNumber = Console.ReadLine();
Console.WriteLine($"1: {sNumber ?? ""} -> {GetThirdDigitFromString(sNumber ?? "")}"); //operator ?? to avoid throwing warnings

//check second way 
int iNumber = Convert.ToInt32(sNumber);
Console.WriteLine($"2: {iNumber} -> {GetThirdDigitFromInteger(iNumber)}");