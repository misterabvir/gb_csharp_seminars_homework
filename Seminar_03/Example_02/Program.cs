/**************************************************************************
* Задача №18                                                              *
* Напишите программу, которая по заданному номеру четверти,               *
* показывает диапазон возможных координат точек в этой четверти (x и y).  *
***************************************************************************/

Console.WriteLine("Input number of quarter:");
int quarter = Convert.ToInt32(Console.ReadLine());

switch(quarter)
{
    case 1: Console.WriteLine("X > 0 and Y > 0"); break;
    case 2: Console.WriteLine("X < 0 and Y > 0"); break;
    case 3: Console.WriteLine("X < 0 and Y < 0"); break;
    case 4: Console.WriteLine("X > 0 and Y < 0"); break;
    default: Console.WriteLine("wrong input"); break;
}

