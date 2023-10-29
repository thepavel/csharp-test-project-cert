
//string message = "(What if) I am (only interested) in the last (set of parentheses)";
string message = "(What if) there are (more than) one (set of parentheses)?";

//retrieve all instances

const string openingSymbol = "(";
const string closingSymbol = ")";

while (true)
{

    int openingPosition = message.IndexOf(openingSymbol);
    int closingPosition = message.IndexOf(closingSymbol);

    if(openingPosition == -1) break;

    openingPosition += 1;

    Console.WriteLine(message[openingPosition..closingPosition]);
    message = message[(closingPosition + 1)..];
}



// string message = "What is the value <span>between the tags</span>?";

// const string openingSymbol = "<span>";
// const string closingSymbol = "</span>";

// int openingPosition = message.IndexOf(openingSymbol);
// int closingPosition = message.IndexOf(closingSymbol);

// openingPosition += openingSymbol.Length;

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

// Console.WriteLine(message[openingPosition..closingPosition]);
