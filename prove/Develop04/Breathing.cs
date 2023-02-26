class Breathing : Activity {
    //variables
    private string activityName = "Breathing";
    private string breathingActivityMessage = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long in seconds would you like for your session?: ";

   public string getActivityName(){
        return activityName;
   }
    public string getBreathingActivityMessage(){
        return breathingActivityMessage;
    }

    public void breathingActivity(){
        int seconds = Convert.ToInt32(Console.ReadLine());
        getReadyAnimation(2, 1);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
            while(DateTime.Now < endTime){
                Console.Write("Breathe in...");
                countDownAnimation(5);
                Console.WriteLine("");
                Console.Write("Now breathe out...");
                countDownAnimation(5);
                Console.WriteLine("\n");
            }
        returnToMenu(seconds, activityName);
    }



}