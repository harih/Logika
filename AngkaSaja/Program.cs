

using System;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        List<string[]> listOfArrays = new List<string[]>
        {
            new string[] { "2", "h", "6", "u", "y", "t", "7", "j", "y", "h", "8" },
            new string[] { "b", "7", "h", "6", "h", "k", "i", "5", "g", "7", "8" },
            new string[] { "7", "b", "8", "5", "6", "9", "n", "f", "y", "6", "9" },
            new string[] { "u", "h", "b", "n", "7", "6", "5", "1", "g", "7", "9" }
        };


        foreach (string[] arr in listOfArrays)
        {
            int cnt = GetIntegerCount(arr);

            Console.Write("Data : ( ");
            foreach (string s in arr)
            {
                Console.Write(s + " ");
            } 
            Console.WriteLine(") ==> Jumlah nilai integer dalam array: " + cnt);
        }
    }

    public static int GetIntegerCount(string[] array)
    {
        int cnt = 0;

        foreach (string item in array)
        {
            if (int.TryParse(item, out int number))
            {
                cnt++;
            }
        }

        return cnt;
    }
}

