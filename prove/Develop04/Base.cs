using System;
using System.Collections.Generic;


class BaseActivity {
    //fields
    public static string menu = "Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu: ";
    public static List<string> listToBeAnimated = new List<string>();

    //methods
    public static void animator(List<string> listToBeAnimated, int duration, int sleepInterval) {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        int i = 0;
        while(DateTime.Now < endTime){
                Console.Write(listToBeAnimated[i]);
                Thread.Sleep(100 * sleepInterval);
                Console.Write("\b \b");
                i++;
                if(i >= listToBeAnimated.Count){
                    i = 0;
                }
        }

    }
    public void activityMessage(string activityName, string activityDescription){
        Console.Write("Welcome to the " + activityName + ".\n\n" + activityDescription + "\n\nHow long, in seconds, would you like for your session? ");
    }
}