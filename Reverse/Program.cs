
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> inputList = new List<string> { "italem irad irigayaj", "iadab itsap ulalreb", "nalub kusutret gnalali", "IA detareneg margorp" };
        List<string> reversedList = ReverseWordsInList(inputList);

        Console.WriteLine("\nINPUT: ");
        foreach (var item in inputList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\n\nHASIL: ");
        foreach (var item in reversedList)
        {
            Console.WriteLine(item);
        }

        Console.ReadKey();
    }

    public static List<string> ReverseWordsInList(List<string> inputList)
    {
        return inputList.Select(str =>
            string.Join(" ", str.Split(' ').Select(word => new string(word.Reverse().ToArray())))
        ).ToList();
    }
}
