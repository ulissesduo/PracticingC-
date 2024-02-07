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

        public static bool PrimeNumber(int number) 
        {
            if(number <= 1)
                   return false;

            for (int i = 2; i <= Math.Sqrt(number); i++) 
            {
                if(number % i == 0)
                    return false;
            }
            return true;                      
        }

        public static string AnagramChecker(string input1, string input2) 
        {
            char[] characteres = input1.ToCharArray().OrderByDescending(c => c).ToArray();
            char[] characteres2 = input2.ToCharArray().OrderByDescending(c => c).ToArray();

            if (characteres.SequenceEqual(characteres2))
            {
                Console.WriteLine("iguais");
            }
            else 
            {
                Console.WriteLine("não é anagrama");
            }

            for (int i = 0; i < characteres.Length;i++) 
            {
                 Console.WriteLine(characteres[i]);                    
            }
            Console.WriteLine();
            for (int i = 0; i < characteres2.Length; i++)
            {
                Console.WriteLine(characteres2[i]);
            }
            return input1;
        }
        public static Dictionary<string, int> LongestWord(string[] words)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();
           
            string longest = words[0];
            foreach (string word in words)
            {
                int count = word.Length;
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
                counter.Add(word, count);
            }
            var orderedCounter = counter.OrderByDescending(pair => pair.Value)
                            .ToDictionary(pair => pair.Key, pair => pair.Value);

            return orderedCounter;

        }

        static void InsertCyclically(int[] array, ref int currentIndex, int value)
        {
            array[currentIndex] = value;
            currentIndex = (currentIndex + 1) % array.Length;
        }
        static void DisplayMenu(string[] menuItems, int currentIndex)
        {
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == currentIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(">> ");
                }

                Console.WriteLine(menuItems[i]);

                Console.ResetColor();
            }
        }

        static int GetRandomNumber(Random random, int min, int max)
        {
            // Generate a random number within a larger range
            int largerRangeRandom = random.Next(min, max*2);

            // Use modulo to wrap the value within the desired range
            int wrappedRandomNumber = largerRangeRandom % (max - min + 1) + min;

            return wrappedRandomNumber;
        }



        public static void Main(string[] args)
        {
            //int[] array = { 1, 2, 3, 4, 5 };
            //int currentIndex = 0;

            //Console.WriteLine("Original Array:");

            //foreach (int element in array)
            //{
            //    Console.Write(element + " ");
            //}

            //Console.WriteLine("\n\nCyclic Indexing:");

            //// Access elements cyclically using modulo
            //for (int i = 0; i < 32; i++)
            //{
            //    int value = array[currentIndex];
            //    Console.Write(value + " ");

            //    currentIndex = (currentIndex + 1) % array.Length;
            //}
            //Console.WriteLine("Enter an angle in degrees:");
            int angle = int.Parse(Console.ReadLine());

            // Wrap angle within the range 0 to 360 degrees
            int wrappedAngle = (angle % 360 + 360) % 360;

            Console.WriteLine($"Wrapped Angle: {wrappedAngle} degrees");


            Console.WriteLine("Enter an hour:");
            int hour = int.Parse(Console.ReadLine());
            int parsing = (hour % 12 ) % 12;
            Console.WriteLine(parsing);



            //=================================================
            //string[] menuItems = { "Play", "Options", "Exit" };
            //int currentIndex = 0;

            //Console.WriteLine("Circular Navigation Menu:");

            //while (true)
            //{
            //    DisplayMenu(menuItems, currentIndex);

            //    ConsoleKeyInfo keyInfo = Console.ReadKey();

            //    // Handle navigation input
            //    if (keyInfo.Key == ConsoleKey.RightArrow)
            //    {
            //        currentIndex = (currentIndex + 1) % menuItems.Length;
            //    }
            //    else if (keyInfo.Key == ConsoleKey.LeftArrow)
            //    {
            //        currentIndex = (currentIndex - 1 + menuItems.Length) % menuItems.Length;
            //    }
            //    else if (keyInfo.Key == ConsoleKey.Enter)
            //    {
            //        Console.WriteLine($"\nSelected: {menuItems[currentIndex]}");
            //        break;
            //    }

            //    Console.Clear();




            //int minRange = 10;
            //int maxRange = 50;

            //Random random = new Random();

            //Console.WriteLine($"Random Numbers in the range [{minRange}, {maxRange}]:");

            //for (int i = 0; i < 100; i++)
            //{
            //    int randomNumber = GetRandomNumber(random, minRange, maxRange);
            //    Console.WriteLine(randomNumber);
            //}



            //char[] characters = { 'A', 'B', 'C', 'D', 'E' };
            //int currentIndex = 0;

            //Console.WriteLine("Original Array:");

            //foreach (char character in characters)
            //{
            //    Console.Write(character + " ");
            //}

            //Console.WriteLine("\n\nCyclic Indexing:");

            //// Access elements cyclically using modulo
            //for (int i = 0; i < 110; i++)
            //{
            //    char currentChar = characters[currentIndex];
            //    Console.Write(currentChar + " ");

            //    currentIndex = (currentIndex + 1) % characters.Length;
            //}
        }
        
    }
}