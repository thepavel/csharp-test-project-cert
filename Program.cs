
//string message = "(What if) I am (only interested) in the last (set of parentheses)";
//string message = "(What if) there are (more than) one (set of parentheses)?";

//retrieve all instances
string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS message {message}");

char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;

int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

// while (true)
// {

//     int openingPosition = message.IndexOf(openingSymbol);
//     int closingPosition = message.IndexOf(closingSymbol);

//     if(openingPosition == -1) break;

//     openingPosition += 1;

//     Console.WriteLine(message[openingPosition..closingPosition]);
//     message = message[(closingPosition + 1)..];
// }



// string message = "What is the value <span>between the tags</span>?";

// const string openingSymbol = "<span>";
// const string closingSymbol = "</span>";

// int openingPosition = message.IndexOf(openingSymbol);
// int closingPosition = message.IndexOf(closingSymbol);

// openingPosition += openingSymbol.Length;

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// Console.WriteLine(message[openingPosition..closingPosition]);
