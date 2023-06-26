using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@\[\]^_`{|}~])([^\s]{40,50})$";
		Regex regex = new Regex(pattern);

		while (true)
		{
			Console.Write("Enter a string (or 'quit' to stop): ");
			string userInput = Console.ReadLine();

			if (userInput.ToLower() == "quit")
			{
				break;
			}

			if (regex.IsMatch(userInput))
			{
				Console.WriteLine("Match");
			}
			else
			{
				Console.WriteLine("No match");
			}
		}
	}
}