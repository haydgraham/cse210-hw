class Reflecting : Activity {
    private string activityName = "Reflecting";

    private string reflectingActivityMessage = "Welcome to the Reflecting Activity.\n\nThis activity will help you to reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\nHow long in seconds would you like for your session?: ";


    public void reflectingActivity(){
            Console.Clear();
            
            Console.Write(reflectingActivityMessage);

            int seconds = Convert.ToInt32(Console.ReadLine());

            getReadyAnimation(2, 1);

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
                countDownAnimation(5);
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
            spinnerAnimation(2, 1);
            Console.Write("\n");
            }

            returnToMenu(seconds, activityName);

    }
}