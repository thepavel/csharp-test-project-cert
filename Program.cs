string input = "Pad this";
string padded = input.PadLeft(12);
var rightPad = input.PadRight(12);


Console.WriteLine(padded);
Console.WriteLine(rightPad.Length);

#region StringFormat
    
        // string first = "Hello";
        // string second = "World";
        // string result = string.Format("{0} {1}!", first, second);
        // Console.WriteLine(result);
    
        // // decimal price = 123.45m;
        // // int discount = 50;
        // // Console.WriteLine($"Price: {price:C} (Save {discount:C})");
    
        // decimal measurement = 123456.78912m;
        // Console.WriteLine($"Measurement: {measurement:N4} units"); 


        // decimal tax = .36785m;
        // Console.WriteLine($"Tax rate: {tax:P2}");
        // // Tax rate: 36.79 %

        // // combination

        // decimal price = 67.55m;
        // decimal salePrice = 59.99m;
        // decimal discount = price - salePrice;

        // string message = String.Format("You saved {0:C2} off the regular {1:C2} price. ", discount, price);

        // message += $"A discount of {discount / price:P2}!"; //inserted
        // Console.WriteLine(message);

        // int invoiceNumber = 1201;
        // decimal productShares = 25.4568m;
        // decimal subtotal = 2750.00m;
        // decimal taxPercentage = .15825m;
        // decimal total = 3185.19m;

        // Console.WriteLine($"Invoice Number: {invoiceNumber}");
        // Console.WriteLine($"   Shares: {productShares:N3} Product");
        // Console.WriteLine($"     Sub Total: {subtotal:C}");
        // Console.WriteLine($"           Tax: {taxPercentage:P2}");
        // Console.WriteLine($"     Total Billed: {total:C}");
    
#endregion