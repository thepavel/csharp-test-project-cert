/*
 * https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/4-exercise-create-reusable-methods
 *
 */
int[] times = { 800, 1200, 1600, 2000 };


Console.WriteLine("Enter current GMT Offset");
int currentGMT = Convert.ToInt32(Console.ReadLine());
bool isValid = ValidateOffset(currentGMT);

const string CurrentMedSchedule = "Current Medicine Schedule:";
DisplayTimes(times, CurrentMedSchedule);

Console.WriteLine("Enter new GMT Offset");
int newGMT = Convert.ToInt32(Console.ReadLine());

isValid = isValid && ValidateOffset(newGMT);
if(isValid) 
{
    var diff = Math.Abs(newGMT - currentGMT)*100;
    AdjustTimeToWithin24Hours(times, diff);
}

const string NewMedSchedule = "New Medicine Schedule:";
DisplayTimes(times, NewMedSchedule);

static void DisplayTimes(int[] times, string message)
{
    Console.WriteLine(message);
    /* Format and display medicine times */
    foreach (int val in times)
    {
        var militaryTime = $"{val:0000}";
        string thyme = $"{militaryTime[..2]}:{militaryTime.Substring(2, 2)}";
        Console.WriteLine(thyme);
    }

    Console.WriteLine();
}

static void AdjustTimeToWithin24Hours(int[] times, int diff)
{

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

static bool ValidateOffset(int offset)
{

    if (Math.Abs(offset) <= 12)
    {
        return true;
    }

    Console.WriteLine("Invalid Offset");
    return false;
}