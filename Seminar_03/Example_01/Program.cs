/****************************************************************************************
* Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),   *
* причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*
*****************************************************************************************/

Console.Write("Input X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y: ");
int y = Convert.ToInt32(Console.ReadLine());

     if(x > 0 && y > 0) Console.WriteLine("First quarter");
else if(x < 0 && y > 0) Console.WriteLine("Second quarter");
else if(x < 0 && y < 0) Console.WriteLine("Third quarter");
else                    Console.WriteLine("Fourth quarter");
