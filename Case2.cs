using System;

public static class Case2
{
    public static void Run()
    {
        int[] numbers = { 2, 4, 3 };
        int target = 4;
        bool isFound = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                Console.WriteLine($"Target has been reached in index number {i}");
                isFound = true;
                break;
            }
        }

        if (!isFound)
            Console.WriteLine("Target not found in array data");
    }
}
