/*Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");*/

string pangram = "The quick brown fox jumps over the lazy dog"; //original message, should be reversed

string[] words = pangram.Split(' '); //array with words from original message

string[] reversed = new string[words.Length]; //array for holding reversed words

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray(); // each words into char array
    Array.Reverse(letters); //reverse char array with separate word
    reversed[i] = new string(letters); //assign reversed string into new array

}

string result = String.Join(" ", reversed); //join reversed words from array into new string
Console.WriteLine(result); //print out new string

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";//original string

string[] ordersArray = orderStream.Split(","); //array of orders IDs
Array.Sort(ordersArray);// sorting of array

for (int i = 0;i < ordersArray.Length; i++)
{
    if (ordersArray[i].Length != 4) //order ID should be 4 characters long
    {
        Console.WriteLine($"{ordersArray[i]}\t-Error");
    }
    else
    {
        Console.WriteLine(ordersArray[i]);
    }
}






