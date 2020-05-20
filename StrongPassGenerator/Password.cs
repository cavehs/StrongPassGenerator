using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongPassGenerator
{
    public class Password
    {
        Random random;

        public Password()
        {
            // Always seed a random to ensure unique values!
            random = new Random(System.DateTime.Now.Millisecond);
        }

        public string Generate(int inputLength, bool symbol, bool number, bool lowerCase, bool upperCase, bool noSimilar, bool isAmbigious)
        {
            var initialInputLength = inputLength;
            string pass = null;

            someMore: for (int i = 0; i < inputLength; i++)
            {

                up: switch (random.Next(1, 6))
                {
                    case 1:
                        if (symbol == true)
                        {
                            pass += Symbols();
                        }
                        else
                            goto up;
                        break;

                    case 2:
                        if (number == true)
                        {
                            pass += Numbers();
                        }
                        else
                            goto up;
                        break;

                    case 3:
                        if (lowerCase == true)
                        {
                            pass += LowerCase();
                        }
                        else
                            goto up;
                        break;

                    case 4:
                        if (upperCase == true)
                        {
                            pass += UpperCase();
                        }
                        else
                            goto up;
                        break;
                    case 5:
                        if (isAmbigious == false)
                        {
                            pass += Ambigious();
                        }
                        else
                            goto up;
                        break;
                }

                if (noSimilar == true)
                {
                    pass = removeSimilar(pass);
                    if (pass.Length < initialInputLength)
                    {
                        inputLength = initialInputLength - pass.Length;
                        goto someMore;
                    }
                }
            }

            return pass;

        }


        public char Symbols()
        {
            char symbolChar = ' ';

            switch (random.Next(1, 6))
            {
                case 1:
                    symbolChar = (char)(random.Next(33, 34));
                    break;
                case 2:
                    symbolChar = (char)(random.Next(35, 39));
                    break;
                case 3:
                    symbolChar = (char)(random.Next(42, 44));
                    break;
                case 4:
                    symbolChar = (char)(random.Next(61, 62));
                    break;
                case 5:
                    symbolChar = (char)(random.Next(63, 65));
                    break;

            }
            return symbolChar;
        }

        public char Numbers()
        {
            char NumbersChar = (char)(random.Next(49, 58));
            return NumbersChar;
        }

        public char LowerCase()
        {
            char lowerCaseChar = (char)(random.Next(97, 123));
            return lowerCaseChar;
        }
        public char UpperCase()
        {
            char upperCaseChar = (char)(random.Next(65, 91));
            return upperCaseChar;
        }

        public string removeSimilar(string similar)
        {
            char c;
            for (int i = 0; i < similar.Length; i++)//for removing lower and uppercase similarities e.g. A,a
            {
                c = similar[i];

                if ((int)c <= 90 && (int)c >= 65)
                    c = (char)(32 + (int)c);
                else if ((int)c <= 122 && (int)c >= 97)
                    c = (char)((int)c - 32);

                for (int j = i + 1; j < similar.Length; j++)
                {
                    if (c == similar[j])
                    {
                        similar = similar.Remove(j, 1);
                        j--;
                    }
                }
            }
            for (int i = 0; i < similar.Length; i++)// For removing similarities: A,A or G,G
            {
                c = similar[i];

                for (int j = i + 1; j < similar.Length; j++)
                {
                    if (c == similar[j])
                    {
                        similar = similar.Remove(j, 1);
                        j--;
                    }
                }
            }

            var ArrSimilarOnes = new char[7] { '1', 'I', 'l', '|', '0', 'O', 'o' };

            for (int i = 0; i < ArrSimilarOnes.Length; i++)// For removing similarities e.g.: O,o,0
            {
                c = ArrSimilarOnes[i];
                for (int j = 0; j < similar.Length; j++)
                {
                    if (c == similar[j])
                    {
                        similar = similar.Remove(j, 1);
                        j--;
                    }
                }
            }


            return similar;
        }


        public char Ambigious()
        {
            char ambChar = ' ';

            switch (random.Next(1, 12))
            {
                case 1:
                    ambChar = (char)(random.Next(34, 35));
                    break;
                case 2:
                    ambChar = (char)(random.Next(39, 42));
                    break;

                case 3:
                    ambChar = (char)(random.Next(44, 45));
                    break;

                case 4:
                    ambChar = (char)(random.Next(46, 48));
                    break;
                case 5:
                    ambChar = (char)(random.Next(58, 61));
                    break;
                case 6:
                    ambChar = (char)(random.Next(62, 63));
                    break;
                case 7:
                    ambChar = (char)(random.Next(91, 95));
                    break;
                case 8:
                    ambChar = (char)(random.Next(96, 97));
                    break;
                case 9:
                    ambChar = (char)(random.Next(123, 127));
                    break;
                case 10:
                    ambChar = (char)(random.Next(95, 96));  // _
                    break;
                case 11:
                    ambChar = (char)(random.Next(45, 46));  // -
                    break;
            }
            return ambChar;
        }
    }
}

