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
            Console.Write("Get Ready...\n");
            List<string> spinner = new List<string>();
            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");

            BaseActivity.animator(spinner, 2, 1);

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            while(DateTime.Now < endTime){
                Console.Write("Breathe in...");
                Breathing.countDown(5);
                Console.WriteLine("");
                Console.Write("Now breathe out...");
                Breathing.countDown(5);
                Console.WriteLine("\n");
            }

            Console.WriteLine("Well done!!");
            Thread.Sleep(2000);
            Console.WriteLine("\nYou have completed another " + seconds + " seconds of the Breathing Activity.");
            Breathing.animator(spinner, 2, 1);
            Console.Clear();
            Console.WriteLine(BaseActivity.menu);

        }
        else if(choice == "2"){
            Console.Clear();
            //create reflecting instance
            Reflecting reflecting = new Reflecting();
            //use base class method to display the unique activity message
            reflecting.activityMessage(reflecting.activityName, reflecting.activityDescription);

            int seconds = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("Get Ready...\n");
             List<string> spinner = new List<string>();
            spinner.Add("|");
            spinner.Add("/");
            spinner.Add("-");
            spinner.Add("\\");

            BaseActivity.animator(spinner, 2, 1);

            Console.WriteLine("\nConsider the following prompt:\n");

            List<string> prompts = new List<string>();
            prompts.Add(" --- Think of a time when you did something really difficult. ---");
            prompts.Add(" --- Think of a time when you followed a spiritual prompting. ---");
            prompts.Add(" --- Think of a time when you accomplished something great. ---");
            prompts.Add(" --- Think of a time when you went the extra mile to stick to a goal. ---");
            prompts.Add(" --- Think of a time when you helped someone in need. ---");

            Random random = new Random();
            int randomIndex = random.Next(0, prompts.Count());



            Console.WriteLine(prompts[randomIndex] + "\n");
            Console.WriteLine("When you have something in mind, press enter to continue.");

            string enter = Console.ReadLine();
            if(enter == ""){
                Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
                Reflecting.countDown(5);
                Console.Clear();
            }

            List<string> questions = new List<string>();
            questions.Add("> How did you feel when it was complete? ");
            questions.Add("> What is your favorite thing about this experience? ");
            questions.Add("> What did you learn from this experience? ");
            questions.Add("> What spiritual insights did you gain from this experience? ");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(seconds);

            while(DateTime.Now < endTime) {
            randomIndex = random.Next(0, questions.Count());
            Console.Write(questions[randomIndex]);
            Reflecting.animator(spinner, 5, 1);
            Console.Write("\n");
            }

            Console.WriteLine("\nWell done!!");
            Reflecting.animator(spinner, 2, 1);
            Console.WriteLine("You have completed another " + seconds + " seconds of the Reflecting Activity.");
            Reflecting.animator(spinner, 2, 1);
            Console.Clear();
            Console.WriteLine(BaseActivity.menu);



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