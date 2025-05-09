
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program
{
    public static void Main()
    {
        List<int[]> listOfArrays = new List<int[]>
        {
            new int[] { 7, 8, 3, 10, 8 },
            new int[] { 5, 12, 11, 12, 10},
            new int[] { 7, 18, 27, 10, 29 },
            new int[] { 20, 17, 15, 14, 10 }
        };

        List<int> minValues = GetMinValues(listOfArrays);

        Console.WriteLine("\n\nNilai terkecil dari setiap array:");
        foreach (var min in minValues)
        {
            Console.WriteLine( min);
        }
    }

    public static List<int> GetMinValues(List<int[]> listOfArrays)
    {
        //return listOfArrays.Select(arr => arr.Min()).ToList();

        Console.WriteLine("Debug : ");
        foreach (var arr in listOfArrays)
        {
            Console.Write("Array ( ");
            foreach (int n in arr)
            {
                Console.Write ( n + " ");
            }

            int m = arr.Min();
            Console.WriteLine(" ) ==> minimun " + m);
        }

        return listOfArrays.Select(arr => arr.Min()).ToList();

    }

}
