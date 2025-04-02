using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Akvelon_Coding_task
{
	public class FizzBuzzResult
	{
		public int Count { get; set; }
		public string Result { get; set; }
	}
	public class FizzBuzzDetector
	{
		public FizzBuzzResult getOverlappings(string input)
		{
			if (input.Length < 7)
			{
				return new FizzBuzzResult()
				{
					Result = "Invalid Input, input length should be more than 6 characters",
					Count = 0
				};
			}

			if (input.Length > 100)
			{
				return new FizzBuzzResult()
				{
					Result = "Invalid Input, input length should be less than 101 characters",
					Count = 0
				};
			}

			int count = 0;
			var words = new List<string>();
			int index = 0;
			StringBuilder word = new StringBuilder();
			while (index < input.Length)
			{
				if (input[index] != ' ')
				{
					word.Append(input[index]);
				}
				else if(word.Length > 0)
				{
					words.Add(word.ToString());
					word.Clear();
				}
				index++;
			}

			if(word.Length > 0)
			{
				words.Add(word.ToString());
			}

			for (int i = 0; i < words.Count; i++)
			{

				if ((i + 1) % 15 == 0)
				{
					words[i] = "FizzBuzz";
					count++;
				}
				else if ((i + 1) % 3 == 0)
				{
					words[i] = "Fizz";
					count++;
				}
				else if ((i + 1) % 5 == 0)
				{
					words[i] = "Buzz";
					count++;

				}
			}

			return new FizzBuzzResult()
			{
				Count = count,
				Result = string.Join(" ", words)
			};
		}
	}
}
