// 06. Print Numbers

using System.Text;
using System.Windows.Markup;

Console.WriteLine("What will be the pattern's size(int > 3)? If not specified the default will be displayed.");
int size = 3;
bool isValidInt = int.TryParse(Console.ReadLine(), out size);

if (!isValidInt || size < 3) Console.WriteLine($"This is not a valid int. Try again! The default pattern is as fallows:");

Console.WriteLine($"**1**");
Console.WriteLine($"**101**");
Console.WriteLine($"**1001**");
string pattern_lastStep = "**1001**";
int currentLineLength = pattern_lastStep.Length-6;

while (currentLineLength <= size)
{
	var nextStringPatternBuilder = new string('0', ++currentLineLength);
	Console.WriteLine($"**1{nextStringPatternBuilder}1**");
}