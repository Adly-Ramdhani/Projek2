using System;

public static class Case3
{
    public static void Run()
    {
        int[] numbers = { 1, 5, 8, 9 };
        int target = 2;
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
