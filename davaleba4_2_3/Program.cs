using System;
using System.Collections.Generic;

class FindSumPairsExample
{
    static void Main()
    {
        int[] numbersArray = { 1, 6, 8, -4, 11, 5, 2, -1, 3, 9 };

        Console.Write("Enter a number: ");
        int targetSum = int.Parse(Console.ReadLine());

        List<int[]> pairs = new List<int[]>();

        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            for (int j = i + 1; j < numbersArray.Length; j++)
            {
                if (numbersArray[i] + numbersArray[j] == targetSum)
                {
                    pairs.Add(new int[] { numbersArray[i], numbersArray[j] });
                }
            }
        }

        Console.WriteLine("Pairs:");
        foreach (int[] pair in pairs)
        {
            Console.WriteLine($"[{pair[0]}, {pair[1]}]");
        }
    }

    
}
