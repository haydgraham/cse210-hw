class Breathing : Activity {
    //fields
    private string _activityName = "Breathing";
    private string _breathingActivityMessage = "Welcome to the Breathing Activity.\n\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n\nHow long in seconds would you like for your session?: ";

    //methods
    public void BreathingActivity(){
        Console.Clear();
        Console.Write(_breathingActivityMessage);
        int seconds = Convert.ToInt32(Console.ReadLine());
        GetReadyAnimation(2, 1);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        Console.Write("\n");
            while(DateTime.Now < endTime){
                Console.Write("Breathe in...");
                CountDownAnimation(5);
                Console.WriteLine("");
                Console.Write("Now breathe out...");
                CountDownAnimation(5);
                Console.WriteLine("\n");
            }
        ReturnToMenu(seconds, _activityName);
    }



}