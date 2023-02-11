using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args){

        string reference1 = "Proverbs 3:5-6";
        string scripture1 = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        //call the scripture function to display the scripture for the user to see
        Console.WriteLine("\n" + Scripture.DisplayScripture(reference1, scripture1) + "\n");


        //prompt the user to hit the enter key to hide words
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

        //main program loop for retrieving user input (Enter/Quit).
        string userInput = "";
        while(userInput != "quit") {
            userInput = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("\n" + Word.HideWord(Word.HideWord(Word.HideWord(Scripture.DisplayScripture(reference1, scripture1) + "\n"))));
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

        }
        Console.WriteLine("Goodbye!");
    }

}