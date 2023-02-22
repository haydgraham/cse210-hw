using System;

class Program
{
    static void Main(string[] args)
    {
        //Start the program with the main menu screen
        Console.WriteLine(Base.menu);

        //Main program loop
        string choice = "";
        while(choice != "4"){

        choice = Console.ReadLine();
        if(choice == "1"){
            Console.Clear();
            //create breathing instance
            Breathing breathing = new Breathing();
            //use base class to display the unique activity message
            breathing.activityMessage(breathing.activityName, breathing.activityDescription);


        }
        else if(choice == "2"){
            Console.Clear();
            //create reflecting instance
            Reflecting reflecting = new Reflecting();
            //use base class method to display the unique activity message
            reflecting.activityMessage(reflecting.activityName, reflecting.activityDescription);



        }
        else if(choice == "3"){
            Console.Clear();
            //create listing instance
            Listing listing = new Listing();
            //use base class method to display the unique activity message
            listing.activityMessage(listing.activityName, listing.activityDescription);
        }
        
        }
    }
}