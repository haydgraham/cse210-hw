using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {  
        Console.Write("\nWelcome to the Journal Program!");
        //create an empty list to append the user's journal entries to
        List<String> entries = new List<String>();
        
        //get user choice
        String choice = "";
        while(choice != "5") {
            Console.Write("\n\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nWhat would you like to do?\n>");             //if the user selects 1 give them a prompt and store their entry in a list
            choice = Console.ReadLine();
            if(choice == "1") {
                //save the prompt in a variable and then write it
                string entryPrompt = Prompt();
                Console.Write(entryPrompt + "\n>");
                string entry = Console.ReadLine();
                entries.Add(entryPrompt + " " + entry);
            }
            else if(choice == "2") {
                DateTime today = DateTime.Today;
                foreach(String item in entries) {
                    Console.Write("\n\nDate: " + today + " - " + item);
                    }
            }
            else if(choice == "3") {
                Console.Write("\nWhat is the filename?\n>");
                string filename = Console.ReadLine();
                List<string> lines = new List<string>();
                lines = File.ReadAllLines("/Users/hayden/Desktop/programmingwclasses/cse210-hw/prove/Develop02/" + filename).ToList();
                foreach(string line in lines){
                    entries.Add(line);
                }

            }
            else if(choice == "4") {
                Console.Write("\nWhat is the filename?\n>");
                string filename = Console.ReadLine();
                
                TextWriter tw = new StreamWriter("/Users/hayden/Desktop/programmingwclasses/1cse210-hw/prove/Develop02/" + filename, true);
                tw.Close();

                    
                File.WriteAllLines(filename, entries);
                }
        }
    }

        static string Prompt() {
            //make a list of prompts to pull from
            List<String> prompts = new List<String>();
            prompts.Add("\nDid you get out of the house today?");
            prompts.Add("\nDid you reach out to a loved one today?");
            prompts.Add("\nWhat would you have done differently today?");
            prompts.Add("\nHow will you meet your goals tomorrow?");
            prompts.Add("\nWhat blessings are you grateful for?");
            //make a random number
            Random random = new Random();
            int randomNum = random.Next(1, 6);
            string randomPrompt = prompts[randomNum];
            //use the random number to select a prompt from the prompt list and return it to main
            return randomPrompt;
        }
}