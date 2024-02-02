using System;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp 
{
    internal class Program
    {
        static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static string ReverseStringWords(string input)
        {
            
            string[] wordsArray = input.Split();
            Array.Reverse(wordsArray);
            return string.Join(" ", wordsArray);
        }

        public static List<int> countDigits(string input) 
        {
            int alphabet = 0;
            int digits = 0;
            int special = 0;
            int[] ints = new int[3];
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    digits++;
                }
                else if (!char.IsLetter(c) && !char.IsDigit(c))
                {
                    special++;
                }
                else 
                {
                    alphabet++;
                }

            }
            //ints[0] =  alphabet;
            //ints[1] = digits;
            //ints[2] = special;

            List<int> counts = new List<int> { alphabet, digits, special };
            //return counts;


            return counts;
        }

        public static int CountChars(string input) 
        {
            int count = 0;
            foreach (char c in input) 
            {
                count++;
            }
            return count;
        }


        public static string Copy(string input) 
        {
            string copiedString = "";
            foreach (char c in input) 
            {
                copiedString += c;
            }
            return copiedString;
        }

        public static List<int> CountVowelCons(string input) 
        {
            int vowels = 0;
            int cons = 0;
            string alpha = "aeiouAEIOU";
            foreach (char c in input) 
            {
                if (alpha.Contains(c))
                {
                    vowels++;
                }
                else 
                {
                    cons++;
                }
            }

            List<int> counts = new List<int> {vowels, cons };


            return counts; 
        }
        static Dictionary<char, int> CountCharacterFrequency(string input)
        {
            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }

            return charFrequency;
        }

       

        static void DisplayCharacterFrequency(Dictionary<char, int> charFrequency)
        {
            Console.WriteLine("Character Frequency:");
            foreach (var entry in charFrequency)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
        }

        static char GetHighestFrequencyChar(Dictionary<char, int> charFrequency)
        {
            return charFrequency.OrderByDescending(entry => entry.Value).First().Key;
        }

        static char GetLeastFrequencyChar(Dictionary<char, int> charFrequency)
        {
            return charFrequency.OrderBy(entry => entry.Value).First().Key;
        }

        public static char[] Sort(string text) 
        {
            char[] result = text.ToCharArray().Distinct().ToArray();
            Array.Sort(result, 0, result.Length);
            return result;
        }

        public static string ReversingStringWords(string input) 
        {
            string reversed = "";
            
            for (int i = 0; i < input.Length; i++) 
            {
                reversed = input[i] + reversed;
            }

            return reversed;
        }

        

        public static Dictionary<string, int> CountLengthWords(string sentense) 
        {
            string[] splited = sentense.Split(' ');
            Dictionary<string,int> counter = new Dictionary<string,int>();
            for (int i = 0; i < splited.Length; i++) 
            {
                string word = splited[i];
                int length = word.Length;

                // Add the word and its length to the dictionary
                counter.Add(word, length);
                Console.WriteLine(splited[i].Length);
            }
            return counter;
        }
        public static string[] MergingArrays(string[] arr1, string[] arr2)
        {
            string[] mergedArray = arr1.Concat(arr2).Distinct().ToArray();
            return mergedArray;
        }

        public static string RotateSubstring(string input, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= input.Length || length <= 0 || startIndex + length > input.Length)
            {
                // Handle invalid indices or length
                return "Invalid indices or length";
            }

            string rotatedSubstring = input.Substring(startIndex, length);
            string rotatedString = rotatedSubstring + input.Substring(0, startIndex) + input.Substring(startIndex + length);
            string i = input.Substring(0, startIndex);
            string j = input.Substring(startIndex + length);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(rotatedSubstring);

            return rotatedString;
        }

        public static string ReplaceWords(string sentense, string wordToReplace, string replacementWord) 
        {
            string[] splited = sentense.Split(' ');

            for (int i = 0; i < splited.Length; i++) 
            {
                if (splited[i] == wordToReplace) 
                {
                    splited[i] = replacementWord;
                }
            }

            string s = string.Join(" " ,splited );
            return s;
        }

        public static List<char> CommonCharacters(string first, string second) 
        {
            List<char> chars = new List<char>();
            for (int i = 0; i < first.Length; i++) 
            {
                for (int j = 0; j < second.Length; j++) 
                {
                    if (first[i] == second[j] && !chars.Contains(first[i])) 
                    {
                        chars.Add(first[i]);
                    }
                }
            }
            return chars;
        }

        public static string AlternateConcatenation(string first, string second) 
        {
            if (first.Length != second.Length) 
                return "";

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < first.Length; i++)
            {
                result.Append(first[i]);
                result.Append(second[i]);
            }
    
            return result.ToString();
        }

        public static Dictionary<char, int> CountRepeatedChar(string input)
        {
            Dictionary<char, int> charFreq = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charFreq.ContainsKey(c))
                {
                    charFreq[c]++;
                }
                else
                {
                    charFreq[c] = 1;  // Corrected line, initialize count to 1 for a new character
                }
            }

            return charFreq;
        }

        public static string ConcatenateDictionary(Dictionary<char, int> charCounts)
        {
            StringBuilder result = new StringBuilder();

            foreach (var entry in charCounts)
            {
                result.Append(entry.Key);
                result.Append(entry.Value);
            }

            return result.ToString();
        }
        public static void Main(string[] args)
        {
            string input = "aaabbccc";
            Dictionary<char, int> charCounts = CountRepeatedChar(input);

            string result = ConcatenateDictionary(charCounts);
            Console.WriteLine(result);
        }
    }
}