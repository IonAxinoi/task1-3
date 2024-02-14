using System;

class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{array[index]} ");
            PrintArrayReverse(array, index - 1);
        }
    }

    static void Main()
    {
        // Пример использования
        int[] myArray = { 1, 2, 3, 4, 5 };
        
        Console.WriteLine("Исходный массив:");
        foreach (var item in myArray)
        {
            Console.Write($"{item} ");
        }

        Console.WriteLine("\nМассив в обратном порядке:");
        PrintArrayReverse(myArray, myArray.Length - 1);
    }
}
