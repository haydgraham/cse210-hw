using System;


class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        activity.printMenu();

        string choice = "";
        while(choice != "4"){
        choice = Console.ReadLine();
        if(choice == "1"){
            Console.Clear();
            Breathing breathing = new Breathing();
            Console.Write(breathing.getBreathingActivityMessage());
            breathing.breathingActivity();
        }
        else if(choice == "2"){
            Reflecting reflecting = new Reflecting();
            reflecting.reflectingActivity();
        }
        else if(choice == "3"){
            Console.Clear();
            Listing listing = new Listing();
            listing.listingActivity();
         



         
            


        }
        }
    }
}