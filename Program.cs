// https://learn.microsoft.com/en-us/training/modules/write-first-c-sharp-method/3-exercise-create-your-first-method

Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

static void DisplayRandomNumbers() {
    Random random = new Random();

    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"{random.Next(1,100)} ");
    }
    Console.WriteLine();
}
