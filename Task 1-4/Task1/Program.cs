using System;

class Program
{
    static void PrintNaturalNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.Write($"{m} ");
            PrintNaturalNumbers(m + 1, n);
        }
    }

    static void Main()
    {
        // Пример использования
        int M = 1; // начальное значение
        int N = 10; // конечное значение

        PrintNaturalNumbers(M, N);
    }
}
