using System;


class Program
{
    static void Main(string[] args)
    {
        //Start the program with the main menu screen
        Console.WriteLine(BaseActivity.menu);

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

            //get the desired duration of the activity from user
            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Get Ready...\n");
            List<string> spinner = new List<string>();
            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");

            BaseActivity.spinner(spinner, 5);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            while(DateTime.Now < endTime){
                Console.WriteLine("Breathe in...");
                Thread.Sleep(2000);
                Console.WriteLine("Now breathe out...\n");
                Thread.Sleep(2000);
            }

            Console.WriteLine("Well done!!");
            Thread.Sleep(2000);
            Console.WriteLine("\nYou have completed another " + seconds + " seconds of the Breathing Activity.");
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(BaseActivity.menu);

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