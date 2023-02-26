using System;


class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity();
        activity.getMenu();

        string choice = "";
        while(choice != "4"){
            choice = Console.ReadLine();
            if(choice == "1"){
                Breathing breathing = new Breathing();
                breathing.BreathingActivity();
            }
            else if(choice == "2"){
                Reflecting reflecting = new Reflecting();
                reflecting.ReflectingActivity();
            }
            else if(choice == "3"){
                Listing listing = new Listing();
                listing.ListingActivity();
            }
        }
    }
}