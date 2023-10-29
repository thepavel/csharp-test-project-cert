string message = "Find what is (inside the parentheses)";

const string openingSymbol = "(";
const string closingSymbol = ")";

int openingPosition = message.IndexOf(openingSymbol);
int closingPosition = message.IndexOf(closingSymbol);

openingPosition += openingSymbol.Length;

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

Console.WriteLine(message[openingPosition..closingPosition]);