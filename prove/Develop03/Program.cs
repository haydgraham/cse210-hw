using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args) {

        Reference reference = new Reference("Proverbs", 3, "5-6");
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        //main program loop for retrieving user input (Enter/Quit).
        string userInput = "";
        int numberOfWordsToHide = 0;
        while(userInput != "quit" && numberOfWordsToHide <= scripture.WordCount()) {
            Console.WriteLine("numberOfWords: " + numberOfWordsToHide);
            Console.WriteLine("\n" + scripture.LearnScripture(numberOfWordsToHide) + "\n");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            numberOfWordsToHide++;
        }
        Console.WriteLine("Goodbye!");
    }

}