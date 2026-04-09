using StringExtensionsLib;

string[] testStrings = { "Hello", "world", "Azure", "devops" };

foreach (string s in testStrings)
{
    Console.WriteLine($"\"{s}\" starts with uppercase: {s.StartsWithUpperCase()}");
}