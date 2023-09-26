using System;
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("Enter a string to reverse:");
string input = Console.ReadLine();

if (IsValidInput(input))
{
    string reversed = ReverseString(input);
    Console.WriteLine("Reversed string: " + reversed);
}
else
{
    Console.WriteLine("Invalid input. Please enter a non-null alphanumeric string.");
}

static bool IsValidInput(string input)
{
    // Use a regular expression to check if the input consists of alphanumeric characters and is not null or empty.
    // ^ - Start of the string
    // [a-zA-Z0-9]+ - Match one or more alphanumeric characters
    // $ - End of the string
    return !string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, "^[a-zA-Z0-9]+$");
}

string ReverseString(string input)
{
    // Convert the string to a char array
    char[] charArray = input.ToCharArray();

    // Reverse the char array
    Array.Reverse(charArray);

    // Create a new string from the reversed char array
    return new string(charArray);
}
