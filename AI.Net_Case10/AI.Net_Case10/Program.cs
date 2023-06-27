using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		// Regular expression
		string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!""#$%&'()*+,-./:;<=>?@\[\]^_`{|}~])([^\s]{40,50})$";
		Regex regex = new Regex(pattern);

		while (true)
		{
			Console.Write("If you want to test your string, enter '1', if you want to see the result of testing a regular expression, enter '2': ");
			string fisrtUserInput = Console.ReadLine();

			if (fisrtUserInput == "1")
			{
				while (true)
				{
					Console.Write("Enter a string (or 'back' to return): ");
					string secondUserInput = Console.ReadLine();

					if (secondUserInput.ToLower() == "back")
					{
						break;
					}

					if (regex.IsMatch(secondUserInput))
					{
						Console.WriteLine("Match");
					}
					else
					{
						Console.WriteLine("No match");
					}
				}
			}
			else if (fisrtUserInput == "2")
			{
				// Test cases
				string[] testCases = new string[]
				{
				"ThisIsTooShort1!",
				"ThisIsWayTooLong1!ThisIsWayTooLong1!ThisIsWayTooLong1!ThisIsWayTooLong1!",
				"ThisIsJustRightLengthWithAllReqChars1!",
				"missinguppercase1!",
				"MISSINGLOWERCASE1!",
				"MissingSpecialCharacter1",
				"Missingsigit!",
				"This has Excess White Spaces 1!",
				" ThisStartsWithWhiteSpace1!",
				"ThisEndsWithWhiteSpace1! ",
				"ThisIsCorrect1!ThisIsCorrect1!ThisIsCorrect1!"
				};

				// Test the regular expression
				foreach (string test in testCases)
				{
					bool isMatch = regex.IsMatch(test);
					Console.WriteLine($"Input: {test}\nMatch: {isMatch}\n");
				}

				Console.Write("Click enter to continue");
				Console.ReadLine();
			}
		}
	}
}