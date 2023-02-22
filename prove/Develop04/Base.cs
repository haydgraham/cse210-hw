class Base {

    //fields
    
    public static string menu = "Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu: ";
   


    //methods
   










    ///////////////
    public void activityMessage(string activityName, string activityDescription){
        Console.Write("Welcome to the " + activityName + ".\n\n" + activityDescription + "\n\nHow long, in seconds, would you like for your session? ");
    }
}