using System;

public class task1
{
    static void Main(string[] args)
    {
        Console.Write("Введите кол-во строк для матрицы: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите кол-во столбцов для матрицы: ");
        int b = int.Parse(Console.ReadLine());
 
        int[,] arr = new int[a, b];
        Random rnd = new Random();
 
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                arr[i, j] = rnd.Next(0, 100);
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
            
        int max = int.MinValue;
            
        for (int j = 0; j < b; j++)
        {
            int min = arr[0, j];
            for (int i = 1; i < a; i++)
            {
                if (arr[i, j] < min)
                    min = arr[i, j];
            }
 
            Console.WriteLine("Минимальный элемент в столбце {0}: {1}", j, min);
            if (min > max)
                max = min;
        }
 
        Console.WriteLine("максимальный среди минимальных элементов столбцов: " + max);
    }
}









