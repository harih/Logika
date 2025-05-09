
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        List<int> fibonacciSeries = GenerateFibonacci(100);

        Console.Write("HASIL \n ( ");
        foreach (var number in fibonacciSeries)
        {
            Console.Write (number + ", ");
        }
        Console.Write(")\n");
    }

    public static List<int> GenerateFibonacci(int limit)
    {
        List<int> series = new List<int> { 0, 1 };

        while (true)
        {
            int nextNumber = series[series.Count - 1] + series[series.Count - 2];
            if (nextNumber > limit)
                break;

            series.Add(nextNumber);
        }

        return series;
    }
}