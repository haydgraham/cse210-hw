using System;
using System.Collections.Generic;


class Activity {
    //fields
    protected static string _menu = "Menu Options:\n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\nSelect a choice from the menu: ";


    //methods
    public void getMenu(){
        Console.WriteLine(_menu);
    }

    public static void Animator(List<string> listToBeAnimated, int duration, int sleepInterval) {
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

    public void CountDownAnimation(int countDownStart){
        List<string> countDownList = new List<string>();
        for(int i = countDownStart; i > -1; i--){
            countDownList.Add(i.ToString());
        }
        Animator(countDownList, 5, 10);
    }

    public void SpinnerAnimation(int duration, int speed){
        List<String> spinnerList = new List<string>();
        spinnerList.Add("|");
        spinnerList.Add("/");
        spinnerList.Add("-");
        spinnerList.Add("\\");

        Animator(spinnerList, duration, speed);
    }

    public void GetReadyAnimation(int duration, int speed){
        Console.Clear();
        Console.Write("Get Ready...\n");
        SpinnerAnimation(duration, speed);
    }

    public void ReturnToMenu(int seconds, string activityName){
        Console.WriteLine("Well done!!");
        SpinnerAnimation(2, 1);
        Console.WriteLine("You have completed another " + seconds + " seconds of the " + activityName + " Activity");
        SpinnerAnimation(2, 1);
        Console.Clear();
        getMenu();
    }

}