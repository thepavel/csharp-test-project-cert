﻿/*
 * https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/4-exercise-create-reusable-methods
 *
 */
int[] times = {800, 1200, 1600, 2000};



int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

DisplayTimes(times);

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimeToWithin24Hours(times, diff);
} 
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimeToWithin24Hours(times, diff);
}

Console.WriteLine("New Medicine Schedule:");

DisplayTimes(times);

Console.WriteLine();

static void DisplayTimes(int[] times)
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}

static void AdjustTimeToWithin24Hours(int[] times, int diff)
{

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}