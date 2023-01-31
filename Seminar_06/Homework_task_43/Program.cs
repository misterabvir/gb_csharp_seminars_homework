/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

(double K, double B) GetCoefficients(string description)
{
    double K;
    double B;
    do{
        Console.Clear();
        Console.Write($"{description} Enter K: ");
    }while(!double.TryParse(Console.ReadLine(), out K));

    do{
        Console.Clear();
        Console.Write($"{description} Enter B: ");
    }while(!double.TryParse(Console.ReadLine(), out B));    
    return (K, B);
}

(double k, double b) factor1 = GetCoefficients("FIRST  EQUATION");
(double k, double b) factor2 = GetCoefficients("SECOND EQUATION");

Console.Clear();
Console.WriteLine("EQUATIONS");
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"y = {factor1.k} * x + {factor1.b}");
Console.WriteLine($"y = {factor2.k} * x + {factor2.b}");
Console.ResetColor();

if(factor1.k == factor2.k) 
    Console.WriteLine("the equation has no solutions or has an infinite number of solutions");
else
{
    /*
    if y1 == y2 && x1 == x2   =>
    k1 * x + b1 = k2 * x + b2 =>
    x = (b2 - b1)/(k1 - k2) 
    */        
    double x = (factor2.b - factor1.b) / (factor1.k - factor2.k);
    double y1 = factor1.k * x + factor1.b; 
    double y2 = factor2.k * x + factor2.b;
    if(y1 == y2) Console.WriteLine($"Result: ({x:0.00}, {y1:0.00})");
    else Console.WriteLine("calculation error"); // возможно не достижимая строка?!??
}

/*
OUTPUT====================================================
EQUATIONS
y = 34 * x + 53
y = 66 * x + 22
Result: (0.97, 85.94)
==========================================================
EQUATIONS
y = 5 * x + 2
y = 9 * x + 4
Result: (-0.50, -0.50)
==========================================================
EQUATIONS
y = 12.3 * x + 124.3
y = 4.7 * x + 1
Result: (-16.22, -75.25)
==========================================================
EQUATIONS
y = 1 * x + 4
y = 1 * x + 7
the equation has no solutions or has an infinite number of solutions
==========================================================
*/