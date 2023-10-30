string data = "12345John Smith          5000  3  ";

string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);


//string message = "(What if) I am (only interested) in the last (set of parentheses)";
//string message = "(What if) there are (more than) one (set of parentheses)?";
//string message = "Help (find) the {opening symbols}";
// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = { '[', '{', '(' };
// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
//     if(openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);
//     char closingSymbol = GetClosingSymbol(currentSymbol);

//     openingPosition += 1;
//     closingPosition = message.IndexOf(closingSymbol, openingPosition);

//     Console.WriteLine(message[openingPosition..closingPosition]);
// }

// static char GetClosingSymbol(string symbol) {

//     // Now  find the matching closing symbol

//     switch (symbol)
//     {
//         case "[":
//             return ']';
//         case "{":
//             return '}';
//         case "(":
//             return ')';
//         default:
//             return ' ';
//     }

// }

// int startPosition = 6;

// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");



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
