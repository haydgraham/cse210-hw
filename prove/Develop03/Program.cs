using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args){

        //call the scripture function to display the scripture for the user to see
        Console.WriteLine("\n" + Reference.DisplayReference() + " " + Scripture.DisplayScripture() + "\n");


        //prompt the user to hit the enter key to hide words
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

        //main program loop for retrieving user input (Enter/Quit).
        string userInput = "";
        while(userInput != "quit") {
            
            userInput = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n" + Reference.DisplayReference() + " " + Word.HideWord(Scripture.DisplayScripture() + "\n"));
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");

        }
        Console.WriteLine("Goodbye!");
    }

}