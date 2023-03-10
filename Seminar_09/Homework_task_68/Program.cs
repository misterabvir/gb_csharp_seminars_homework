/*
 *   Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
 *   Даны два неотрицательных числа m и n.
 */

DemoAckermann();

void DemoAckermann()
{
    (int M, int N) max = (3, 11);
    for (int n = 0; n <= max.N; n++)
    {
        for (int m = 0; m <= max.M; m++)
        {
            Console.Write($"A({m,1}, {n,2:#0}) = {Ackermann(m, n),-5}");
        }
        Console.WriteLine();
    }
}

/*
 *  Ackermann–Péter  Fˉ¹
 *            _
 *           |   n + 1,                , m = 0
 *  A(m, n) <    A(m - 1, 1)           , m > 0, n = 0
 *           |_  A(m - 1, A (m, n - 1)), m > 0, n > 0
 *          
 */

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}

/*
 *  OUTPUT =========================================================
 *  A(0, 00) = 1    A(1, 00) = 2    A(2, 00) = 3    A(3, 00) = 5
 *  A(0, 01) = 2    A(1, 01) = 3    A(2, 01) = 5    A(3, 01) = 13
 *  A(0, 02) = 3    A(1, 02) = 4    A(2, 02) = 7    A(3, 02) = 29
 *  A(0, 03) = 4    A(1, 03) = 5    A(2, 03) = 9    A(3, 03) = 61
 *  A(0, 04) = 5    A(1, 04) = 6    A(2, 04) = 11   A(3, 04) = 125
 *  A(0, 05) = 6    A(1, 05) = 7    A(2, 05) = 13   A(3, 05) = 253
 *  A(0, 06) = 7    A(1, 06) = 8    A(2, 06) = 15   A(3, 06) = 509
 *  A(0, 07) = 8    A(1, 07) = 9    A(2, 07) = 17   A(3, 07) = 1021
 *  A(0, 08) = 9    A(1, 08) = 10   A(2, 08) = 19   A(3, 08) = 2045
 *  A(0, 09) = 10   A(1, 09) = 11   A(2, 09) = 21   A(3, 09) = 4093
 *  A(0, 10) = 11   A(1, 10) = 12   A(2, 10) = 23   A(3, 10) = 8189
 *
 *  - запуск функции со значениями m >= 4 приводят к немедленному stack overflow 
 *  
 *  - запуск функции со значениями n >= 11 при n < 3 работают, при n = 3 ->  stack overflow 
 *  
 *  - не помогает использование переменных типа ulong или double, stack overflow при тех же условиях
 *  
 *  - при использовании System.Numerics.BigInteger способного хранить целое число практически c без граничным количеством цифр
 *  https://learn.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=net-7.0
 *  stack overflow происходит уже при A(3, 9) -> что на самом деле не удивительно, внутри там крутятся переменные типов UInt32 и Int32
 *  [at System.Numerics.BigInteger.Add(System.ReadOnlySpan`1<UInt32>, Int32, System.ReadOnlySpan`1<UInt32>, Int32)] !!!!!!!!! -> вот этот вылет
 */
