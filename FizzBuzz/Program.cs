
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("\nHASIL: ");
        for (int i = 1; i <= 100; i++)
        {
            string output = i.ToString();

            if (i % 3 == 0 && i % 5 == 0)
            {
                output += " FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                output += " Fizz";
            }
            else if (i % 5 == 0)
            {
                output += " Buzz";
            }

            Console.WriteLine(output);
        }


        Console.ReadKey();
    }
}
