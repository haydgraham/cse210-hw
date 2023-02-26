class Listing : Activity {
    private string activityName = "Listing";

    private string listingActivityMessage = "Welcome to the Listing Activity.\n\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow long in seconds would you like for your session: ";


    public string getActivityName(){
        return activityName;
    }
    public string getListingActivityMessage(){
        return listingActivityMessage;
    }

    public void listingActivity(){
        Console.Clear();
        Console.Write(listingActivityMessage);

        int seconds = Convert.ToInt32(Console.ReadLine());

        getReadyAnimation(2, 1);
            
        Console.Write("List as many responses as you can to the following prompt:\n");

        List<string> prompts = new List<string>();
        prompts.Add(" --- When have you felt the holy ghost this month? ---");
        prompts.Add(" --- What steps did you take to develop your career this month? ---");
        prompts.Add(" --- What are some lessons you learned this month? ---");
        prompts.Add(" --- What are some things you can improve upon next month? ---");

        Random random = new Random();
        int randomIndex = random.Next(0, prompts.Count());
        Console.Write(prompts[randomIndex]);

        Console.Write("\nYou may begin in: ");
        countDownAnimation(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        List<string> entries = new List<string>();
        Console.WriteLine(" ");
            while(DateTime.Now < endTime){
                Console.Write(">");
                string entry = Console.ReadLine();
                entries.Add(entry);
            }

        Console.WriteLine("You listed " + entries.Count() + " items!");

        returnToMenu(seconds, activityName);
    }
}