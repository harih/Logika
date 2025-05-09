
using System;
using System.Reflection;

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


        foreach (var arr in listOfArrays)
        {
            int result = FindMaxDifferenceValue(arr);

            Console.Write("\nNilai saham: ");
            foreach (int n in arr) {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n ==> Nilai saham dengan keuntungan terbaik: " + result);
        }

    }

    public static int FindMaxDifferenceValue(int[] array)
    {
        if (array.Length < 2)
        {
            throw new ArgumentException("Array harus memiliki minimal dua elemen.");
        }

        int maxDiff = int.MinValue;
        int valueWithMaxDiff = array[0];

        for (int i = 0; i < array.Length - 1; i++)
        {
            int diff = array[i+1] - array[i];
            if (diff > maxDiff)
            {
                maxDiff = diff;
                valueWithMaxDiff = array[i];
            }
        }

        return valueWithMaxDiff;
    }
}