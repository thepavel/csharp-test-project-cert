string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

Console.WriteLine(message.Substring(openingPosition, closingPosition - openingPosition));