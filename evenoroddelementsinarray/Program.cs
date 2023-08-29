using System;

class Program
{
    static void Main()
    {
        int[] array = { 2, 3, 4, 5, 6 };
        int evenCount = 0, oddCount = 0;

        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }

        Console.WriteLine("Even elements: " + evenCount);
        Console.WriteLine("Odd elements: " + oddCount);
    }
}
