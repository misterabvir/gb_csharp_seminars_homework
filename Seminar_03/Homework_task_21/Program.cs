/*************************************************************************
* Напишите программу, которая принимает на вход координаты двух точек    *
* и находит расстояние между ними в 3D пространстве.                     *
* A(3,  6, 8); B(2,  1, -7)  -> 15.84                                    *
* A(7, -5, 0); B(1, -1,  9)  -> 11.53                                    *
**************************************************************************/
int GetInput(string message)
{
    int input;
    do{
        Console.Write(message);
    }while(!int.TryParse(Console.ReadLine(), out input));
    return input;
}

int[] GetPoint(int count)
{
    int[] point = new int[3];  
    point[0] = GetInput($"Point{count}: enter coordinate X: ");
    point[1] = GetInput($"Point{count}: enter coordinate Y: ");
    point[2] = GetInput($"Point{count}: enter coordinate Z: ");
    Console.WriteLine($"Your {count} point: ({point[0]}, {point[1]}, {point[2]})");
    return point;
}

int[] point1 = GetPoint(1);
int[] point2 = GetPoint(2);

double distance = Math.Sqrt(Math.Pow(point1[0] - point2[0], 2) + 
                            Math.Pow(point1[1] - point2[1], 2) + 
                            Math.Pow(point1[2] - point2[2], 2));

Console.WriteLine("Distance between points: {0:#.000}", distance); 
// #.000 -> #sharp is anything up to a dot, and 000 is 3 digits after
// 1 -> 1.000
// 5.1924 -> 5.192
// 5.19 -> 5.190


