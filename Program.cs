string message = "What is the value <span>between the tags</span>?";

const string openingSymbol = "<span>";
const string closingSymbol = "</span>";

int openingPosition = message.IndexOf(openingSymbol);
int closingPosition = message.IndexOf(closingSymbol);

openingPosition += openingSymbol.Length;

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

Console.WriteLine(message[openingPosition..closingPosition]);
