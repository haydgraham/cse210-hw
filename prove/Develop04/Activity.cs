using System;
using System.Collections.Generic;


class Activity {
    //member variables
    protected static string menu = "Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu: ";

    public void printMenu(){
        Console.WriteLine(menu);
    }

    public void printActivityMessage(string activityMessage){
        Console.Write(activityMessage);
    }

  



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

    public void countDownAnimation(int countDownStart){
        List<string> countDownList = new List<string>();
        for(int i = countDownStart; i > -1; i--){
            countDownList.Add(i.ToString());
        }
        animator(countDownList, 5, 10);
    }

    public void spinnerAnimation(int duration, int speed){
        List<String> spinnerList = new List<string>();
        spinnerList.Add("|");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");

        animator(spinnerList, duration, speed);
    }

    public void getReadyAnimation(int duration, int speed){
        Console.Clear();
        Console.Write("Get Ready...\n");
        spinnerAnimation(duration, speed);
    }

    public void returnToMenu(int seconds, string activityName){
        Console.WriteLine("Well done!!");
        spinnerAnimation(2, 1);
        Console.WriteLine("You have completed another " + seconds + " seconds of the " + activityName + " Activity");
        spinnerAnimation(2, 1);
        Console.Clear();
        printMenu();
    }

}