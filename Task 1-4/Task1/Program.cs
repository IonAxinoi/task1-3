using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
        else
        {
            // В этом случае можно выбрать подходящее значение (например, -1) в зависимости от задачи.
            return -1;
        }
    }

    static void Main()
    {
        // Пример использования
        int m = 2;
        int n = 1;

        int result = Ackermann(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
}
