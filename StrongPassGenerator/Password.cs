using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrongPassGenerator
{
    public class Password
    {
        static RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

        const string harderSymbols = "\"'()./:;<>^[]\\`{}|~_";
        const string simpleSymbols = "!@#$%&*-+?";
        const string alphabetUpper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string alphabetLower = "abcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        char[] ArrSimilarOnes = new char[] { '1', 'I', 'l', '|' };
        char[] ArrSimilarZeros = new char[] { '0', 'O', 'o' };

        //Random random;

        public Password()
        {

            // Always seed a random to ensure unique values!
            //random = new Random(System.DateTime.Now.Millisecond);
        }

        public string Generate(int desriredLength, bool includeSymbols, bool includeNumbers, bool includeLowerCase, bool includeUpperCase, bool removeDuplicates, bool noSimilar, bool excludeAmbigious)
        {
            string password = string.Empty;
            string possibles = string.Empty;

            if (includeSymbols)
                possibles += simpleSymbols;

            if (includeNumbers)
                possibles += numbers;

            if(includeLowerCase)
                possibles += alphabetLower;

            if (includeUpperCase)
                possibles += alphabetUpper;

            if (!excludeAmbigious)
                possibles += harderSymbols;

            // Loop through this until we meet the length requirement
            do
            {
                password = GeneratePassword(possibles, password, desriredLength);

                if( removeDuplicates )
                {
                    password = StripDuplicates(password);
                }

                if ( noSimilar )
                {
                    password = StripDuplicatesCaseInsensitive(password);
                }

                if( excludeAmbigious )
                {
                    password = StripConfusingChars(password);
                }

            }
            while (password.Length < desriredLength);
 
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
            int totalspace = possibles.Length;
            char previouschar = ' ';

            while (password.Length < targetLength)
            {
                char newchar = possibles[GenerateRandomNumber((byte)totalspace)];

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

        private string StripRepeating( string inString, char[] markers )
        {

            for (int i = 0; i < markers.Length; i++)
            {
                // Do we have the same marker more than once?
                if ( inString.IndexOf(markers[i]) != inString.LastIndexOf(markers[i]) )
                {
                    // Remove the last one
                    inString = inString.Remove(inString.LastIndexOf(markers[i]), 1);
                }
            }

            return (inString);
        }

        public static byte GenerateRandomNumber(byte randomSpaceSize)
        {
            // Create a byte array to hold the random value.
            byte[] randomNumber = new byte[1];
            do
            {
                // Fill the array with a random value.
                rng.GetBytes(randomNumber);
            }
            while (!IsFair(randomNumber[0], randomSpaceSize));

            System.Diagnostics.Debug.WriteLine("Generated {0}", randomNumber[0]);
            System.Diagnostics.Debug.WriteLine("Returned {0}", (byte) randomNumber[0] % randomSpaceSize );

            // Return the random number mod the search space
            return (byte)(randomNumber[0] % randomSpaceSize);
        }

        private static bool IsFair(byte generatedNumber, byte searchSpace)
        {
            // There are MaxValue / searchSpace full sets of numbers that can come up
            // in a single byte.  For instance, if we have a 6 search space, there are
            // 42 full sets of 1-6 that come up.  The 43rd set is incomplete.
            int fullSetsOfValues = Byte.MaxValue / searchSpace;

            // If the random number is within this range of fair values, then we let it continue.
            // In the 6 sided die case, a roll between 0 and 251 is allowed.  (We use
            // < rather than <= since the = portion allows through an extra 0 value).
            // 252 through 255 would provide an extra 0, 1, 2, 3 so they are not fair
            // to use.
            return generatedNumber < searchSpace * fullSetsOfValues;
        }
    }
}

