using System;
using System.Text;

namespace ConsoleApp
{
    public class Program
    {
        public static Dictionary<char, string> MorseAlphabetDictionary;

        static void Main()
        {
            while (true)
            {

                CreateDictionary();
                Console.WriteLine("Welcome to Morse Code Translator!");
                Console.WriteLine("Please, provide the sentence you would like to translate.");
                string userInput = Console.ReadLine().ToLower();

                if (userInput != "exit")
                {
                    Console.WriteLine("Here is your sentence in Morse code " + Translate(userInput));
                    Console.WriteLine();
                    Console.WriteLine("Press enter to translate again.");
                    Console.WriteLine("Type exit to exit the program.");

                    Console.ReadLine();
                }


                else
                {
                    System.Environment.Exit(0);

                }

            }

        }

        public static void CreateDictionary()
        {
            MorseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'a', ".-"},
                                       {'b', "-..."},
                                       {'c', "-.-."},
                                       {'d', "-.."},
                                       {'e', "."},
                                       {'f', "..-."},
                                       {'g', "--."},
                                       {'h', "...."},
                                       {'i', ".."},
                                       {'j', ".---"},
                                       {'k', "-.-"},
                                       {'l', ".-.."},
                                       {'m', "--"},
                                       {'n', "-."},
                                       {'o', "---"},
                                       {'p', ".--."},
                                       {'q', "--.-"},
                                       {'r', ".-."},
                                       {'s', "..."},
                                       {'t', "-"},
                                       {'u', "..-"},
                                       {'v', "...-"},
                                       {'w', ".--"},
                                       {'x', "-..-"},
                                       {'y', "-.--"},
                                       {'z', "--.."},

                                   };
        }



        public static string Translate(string userInput)
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (char character in userInput)
            {
                if (MorseAlphabetDictionary.ContainsKey(character))
                {
                    stringBuilder.Append(MorseAlphabetDictionary[character] + " ");
                }
                else if (character == ' ')
                {
                    stringBuilder.Append("/ ");
                }
                else
                {
                    stringBuilder.Append(character + " ");
                }
            }

            return stringBuilder.ToString();
        }
    }
}