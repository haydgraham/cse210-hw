using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args){

        string reference1 = "Proverbs 3:5-6";
        string scripture1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        //main program loop for retrieving user input (Enter/Quit).
        string userInput = "";
        int numberOfWords = 0;
        var wordHider = new WordHider(scripture1);
        while(userInput != "quit") {
            Console.WriteLine("numberOfWords: " + numberOfWords);
            Console.WriteLine("\n" + Scripture.DisplayScripture(reference1, wordHider.HideWords(numberOfWords)) + "\n");
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();
            Console.Clear();
            numberOfWords++;
        }
        Console.WriteLine("Goodbye!");
    }

}