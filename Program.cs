

#region OldCode
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");


// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

/**** performing data conversions *****/

/* int -> string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);
 */

/* string -> int */
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

#endregion

/* Convert class usage, string -> int */

//      string value1 = "5";
//      string value2 = "7";
//      int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
//      Console.WriteLine(result);
// Use Convert for downcasting to int because it rounds as expected rather than truncating 

/* Compare casting and converting a decimal into an int */

//      int value = (int)1.5m; // casting truncates
//      Console.WriteLine(value);
//      int value2 = Convert.ToInt32(1.5m); // converting rounds up correctly
//      Console.WriteLine(value2);

/* Int.Parse */

// string name = "Bob";
// Console.WriteLine(int.Parse(name));

// // ^^ throws exception

// 
/* int.TryParse */
//

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
{
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
}