#region OldCode
    // string[] pallets = { "B14", "A11", "B12", "A13" };
    
    // Console.WriteLine("Sorted...");
    // Array.Sort(pallets);
    // foreach (var pallet in pallets)
    // {
    //     Console.WriteLine($"-- {pallet}");
    // }
    
    // Console.WriteLine("");
    // Console.WriteLine("Reversed...");
    // Array.Reverse(pallets);
    // foreach (var pallet in pallets)
    // {
    //     Console.WriteLine($"-- {pallet}");
    // }
    
    /* Array.Clear */
    
    // string[] pallets = { "B14", "A11", "B12", "A13" };
    // Console.WriteLine("");
    
    // Array.Clear(pallets, 0, 2);
    // Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    // foreach (var pallet in pallets)
    // {
    //     Console.WriteLine($"-- {pallet}");
    // }
    
    // Console.WriteLine("");
    // Array.Resize(ref pallets, 6);
    // Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
    
    // pallets[4] = "C01";
    // pallets[5] = "C02";
    
    // foreach (var pallet in pallets)
    // {
    //     Console.WriteLine($"-- {pallet}");
    // }
    
    // Console.WriteLine("");
    // Array.Resize(ref pallets, 3);
    // Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
    
    // foreach (var pallet in pallets)
    // {
    //     Console.WriteLine($"-- {pallet}");
    // }
    /* END */


// string value = "abc123";
// char[] valueArray = value.ToCharArray();

// Array.Reverse(valueArray);

// string result = string.Join(",", valueArray); //new string(valueArray);
// Console.WriteLine(result);

// var items = result.Split(",");

// foreach(var item in items) 
// {
//     Console.WriteLine(item);
// }

#endregion

// write code to reverse each word in a message

string pangram = "The quick brown fox jumps over the lazy dog";

var result = "";
const string standard = "ehT kciuq nworb xof spmuj revo eht yzal god";

var words = pangram.Split(" ");
for (var i = 0; i < words.Length; i++)
{

    var chars = words[i].ToCharArray();
    Array.Reverse(chars);
    words[i] = new string(chars);
}
result = string.Join(" ", words);

Console.WriteLine($"Result: {result}");
Console.WriteLine($"Expected: {standard}");

if (string.Compare(standard, result, true) != 0) 
{
    Console.WriteLine("FAIL");
}