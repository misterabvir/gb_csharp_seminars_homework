/**************************************************************************
* Задача 15: Напишите программу, которая принимает на вход цифру,         *
* обозначающую день недели, и проверяет, является ли этот день выходным.  *
*                                                                         *
* 6 -> да                                                                 *                    
* 7 -> да                                                                 *                    
* 1 -> нет                                                                *                    
**************************************************************************/
Console.OutputEncoding = System.Text.Encoding.UTF8; //I have a problem with cyrillic fonts

string[] dayOfWeek = //little cheating 
{
    "(づ ◕‿◕ )づ",
    "Понедельник", //1
    "Вторник",     //2
    "Среда",       //3
    "Четверг",     //4
    "Пятница",     //5
    "Суббота",     //6
    "Воскресенье", //7
};

//Tuple stuff 
(bool, string) IsDayOff(int numberDayOfWeek) 
{
    bool res = numberDayOfWeek == 7 || numberDayOfWeek == 6;
    return (res, res ? "выходной" : "рабочий день");
}

// amazing animation print
void CoolPrint(string str, ConsoleColor color)
{
    var f_color = Console.ForegroundColor;
    Console.ForegroundColor = color;
    for (int i = 0; i < str.Length; i++)
    {
        Thread.Sleep(50);
        Console.Write(str[i]);
    }
    Console.ForegroundColor = f_color;
}

// validated user input
int GetInput()
{
    int num = 0;
    do{
        Console.Clear();
        Console.Write("Введите число от 1 до 7 включительно: ");
    }while(!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 7);
    return num;
}

/***************************************************************************************/

int number = GetInput();

Console.WriteLine("Посмотрим...");

var whatIsDay = IsDayOff(number);

CoolPrint(dayOfWeek[number], whatIsDay.Item1 ? ConsoleColor.Green : ConsoleColor.Red);
CoolPrint($" это {whatIsDay.Item2}\n", whatIsDay.Item1 ? ConsoleColor.Green : ConsoleColor.Red);

//emoji
Console.WriteLine(dayOfWeek[0]);