/*
This code reverses a message, counts the number of times a particular character appears, then prints the results to the console window.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();

Array.Reverse(message);
int letterCount = 0;

foreach (char i in message) 
{
    if (i == 'o') 
    {
        letterCount++;
    } 
}

string newMessage = new string(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
