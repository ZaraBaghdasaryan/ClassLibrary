# Morse Code Translation Service 

## Installation
 - Download the translation service using Nuget Handler.

## Usage
 - Create a Console Application 
 - Install the MorseCodeTranslationService Nuget package from Visual Studio. 
 - Add a using statement/reference to the package
 - Add the below-mentioned code in the Main method of your program


static void Main() 
        {
            var program = new TranslationProgram(); 
            
            while (true)
            {

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
## Future recommendations
 - If you would like, you can use the Factory pattern to add additional dictionaries 
 - and further develop your program to perform more exciting and interesting translation services. 

## Acknowledgmensts 
 - Package Icon was made by Sumit Saengthong on Iconscout. 


