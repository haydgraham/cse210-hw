class Breathing : BaseActivity {
    //data
    public string activityName = "Breathing Activity";
    public string activityDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";



    //methods
    public static void countDown(int countDownStart){
        List<string> countDownList = new List<string>();
        for(int i = countDownStart; i > -1; i--){
            countDownList.Add(i.ToString());
        }

        animator(countDownList, 5, 10);

    }

}