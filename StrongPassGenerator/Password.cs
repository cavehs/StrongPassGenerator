using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrongPassGenerator
{
	public class PasswordOptions
	{
		public int PasswordLength { get; set; }
		public bool IncludeSymbols { get; set; }
		public bool IncludeNumbers { get; set; }
		public bool IncludeUppercase { get; set; }
		public bool IncludeLowercase { get; set; }
		public bool ExcludeDuplicates { get; set; }
		public bool ExcludeSimilar { get; set; }
		public bool ExcludeAmbiguous { get; set; }
	}

	public class Password
	{
		const string harderSymbols = "\"'()./:;<>^[]\\`{}|~_";
		const string simpleSymbols = "!@#$%&*-+?";
		const string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		const string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
		const string numbers = "0123456789";
		readonly char[] ArrSimilarOnes = new char[] { '1', 'I', 'l', '|' };
		readonly char[] ArrSimilarZeros = new char[] { '0', 'O', 'o' };

		private RandomNumberGenerator rng = null;


		public Password()
		{
			rng = RandomNumberGenerator.Create();
		}

		public string Generate(PasswordOptions options)
		{
			string password = string.Empty;
			string possibles = string.Empty;

			if (options.IncludeSymbols)
				possibles += simpleSymbols;

			if (options.IncludeNumbers)
				possibles += numbers;

			if (options.IncludeLowercase)
				possibles += alphabetLower;

			if (options.IncludeUppercase)
				possibles += alphabetUpper;

			if (!options.ExcludeAmbiguous)
				possibles += harderSymbols;

			// Loop through this until we meet the length requirement
			do
			{
				password = GeneratePassword(possibles, password, options.PasswordLength);

				if (options.ExcludeDuplicates)
				{
					password = StripDuplicates(password);
				}

				if (options.ExcludeSimilar)
				{
					password = StripDuplicatesCaseInsensitive(password);
				}

				if (options.ExcludeAmbiguous)
				{
					password = StripConfusingChars(password);
				}

			}
			while (password.Length < options.PasswordLength);

			return password;
		}

		private string StripConfusingChars(string password)
		{
			if (password.IndexOfAny(ArrSimilarOnes) >= 0)
			{
				password = StripRepeating(password, ArrSimilarOnes);
			}

			if (password.IndexOfAny(ArrSimilarZeros) >= 0)
			{
				password = StripRepeating(password, ArrSimilarZeros);
			}

			return (password);
		}

		public string GeneratePassword(string possibles, string password, int targetLength)
		{
			char previouschar = ' ';

			while (password.Length < targetLength)
			{
				char newchar = possibles[GenerateRandomNumber(possibles.Length)];

				// Try to avoid the same character twice? Aa should not be allowed, but Aba would be 
				if (Char.ToLower(previouschar) == Char.ToLower(newchar))
				{
					continue;
				}

				password += newchar;
				previouschar = newchar;
			}

			return password;
		}

		public string StripDuplicates(string password)
		{
			if (password.Length < 2)
				return password;

			char c;

			// For removing duplicates of same case: A,A or g,g
			for (int i = 0; i < password.Length; i++)
			{
				c = password[i];

				for (int j = i + 1; j < password.Length; j++)
				{
					if (c == password[j])
					{
						password = password.Remove(j, 1);
						j--;
					}
				}
			}

			return password;
		}


		public string StripDuplicatesCaseInsensitive(string password)
		{
			if (password.Length < 2)
				return password;

			char c;
			// For removing duplicates case insensitive e.g. A,a
			for (int i = 0; i < password.Length; i++)
			{
				c = password[i];

				if ((int)c <= 90 && (int)c >= 65)
					c = (char)(32 + (int)c);
				else if ((int)c <= 122 && (int)c >= 97)
					c = (char)((int)c - 32);

				for (int j = i + 1; j < password.Length; j++)
				{
					if (c == password[j])
					{
						password = password.Remove(j, 1);
						j--;
					}
				}
			}

			return password;
		}

		private string StripRepeating(string inString, char[] markers)
		{

			for (int i = 0; i < markers.Length; i++)
			{
				// Do we have the same marker more than once?
				if (inString.IndexOf(markers[i]) != inString.LastIndexOf(markers[i]))
				{
					// Remove the last one
					inString = inString.Remove(inString.LastIndexOf(markers[i]), 1);
				}
			}

			return (inString);
		}

		public byte GenerateRandomNumber(int randomSpaceSize)
		{
			// Create a byte array to hold the random value.
			byte[] randomNumber = new byte[1];
			// Fill the array with a random value.
			rng.GetBytes(randomNumber);

			// Return the random number mod the search space
			return (byte)(randomNumber[0] % randomSpaceSize);
		}
	}
}

