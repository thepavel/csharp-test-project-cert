
Console.WriteLine("Fizz Buzz");

/*
 * ✓ Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
 * ✓ When the current value is divisible by 3, print the term Fizz next to the number.
 * ✓ When the current value is divisible by 5, print the term Buzz next to the number.
 * ✓ When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
 *
 */


int exit = RunFizzBuzz();

int RunFizzBuzz()
{
    int min = 1;
    int max = 100;

    for (int i = min; i <= max; i++)
    {
        string output = $"{i}";
        string suffix = "";

        if (i % 3 == 0)
            suffix += "Fizz";
        if (i % 5 == 0)
            suffix += "Buzz";

        if (suffix.Length > 0)
            output += $" - {suffix}";
        
        Console.WriteLine(output);
    }
    
    return 0;
}