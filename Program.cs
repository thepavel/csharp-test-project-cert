
string message = "(What if) I am (only interested) in the last (set of parentheses)";

const string openingSymbol = "(";
const string closingSymbol = ")";

int lastOpeningPosition = message.LastIndexOf(openingSymbol);
int lastclosingPosition = message.LastIndexOf(closingSymbol);

lastOpeningPosition += 1;

Console.WriteLine(message[lastOpeningPosition..lastclosingPosition]);

// string message = "What is the value <span>between the tags</span>?";

// const string openingSymbol = "<span>";
// const string closingSymbol = "</span>";

// int openingPosition = message.IndexOf(openingSymbol);
// int closingPosition = message.IndexOf(closingSymbol);

// openingPosition += openingSymbol.Length;

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// Console.WriteLine(message[openingPosition..closingPosition]);
