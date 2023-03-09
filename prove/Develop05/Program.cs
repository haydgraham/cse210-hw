using System;
using System.Collections;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        ArrayList goalHolder = new ArrayList();

        Console.WriteLine("\nYou have 0 points.\n");

        string menu = "Menu options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\nSelect a choice from the menu:";
        Console.WriteLine(menu);

        string choice = "";
        while(choice != "6"){
            choice = Console.ReadLine();
            if(choice == "1"){
                Console.WriteLine("The types of goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\nWhich type of goal would you like to create?");
                string goalType = Console.ReadLine();
                if(goalType == "1"){
                    Console.WriteLine("What is the name of your goal");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it?");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal?");
                    int points = Console.Read();
                    Goal goal = new Goal(name, description, points, false);
                    goalHolder.Add(goal.toString());
                    Console.Clear();
                    Console.WriteLine(menu);


                }
                else if(goalType == "2"){
                    //todo: prompt for eternal goal object
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = Console.Read();
                    Console.Clear();
                    Console.WriteLine(menu);

                }
                else if(goalType == "3"){
                    //todo: prompt for checklist goal object
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short descripiton of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = Console.Read();
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int bonus = Console.Read();
                    Console.Clear();
                    Console.WriteLine(menu);
                }
            }
            else if(choice == "2"){
                Console.Clear();
                Console.WriteLine("The goals are:");
                int i = 1;
                foreach(string goal in goalHolder){
                    Console.WriteLine($" {i}. {goal}");
                    i++;
                }

                Console.WriteLine("\n" + menu);
               
            }
            else if(choice == "3"){
               Console.WriteLine("What is the filename of the goal file? ");
               string filename = Console.ReadLine();
               foreach(string goal in goalHolder){
               using (StreamWriter outputFile = new StreamWriter(filename))
               outputFile.WriteLine(goal);
               }
               Console.Clear();
               Console.WriteLine(menu);
            }
            else if(choice == "4"){
                Console.WriteLine("What is the filename for the goals file");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(" ");

                    string completed = parts[0];
                    string name = parts[1];
                    string description = parts[2];

                    string goal = $"{completed} {name} {description}";
                    goalHolder.Add(goal);
                }
                Console.WriteLine("The goals are:");
                int i = 1;
                foreach(string goal in goalHolder){
                    Console.WriteLine($" {i}. {goal}");
                    i++;
                }
                Console.WriteLine($"\n{menu}");

            }
            else if(choice == "5"){
                Console.WriteLine("Which goal did you accomplish");
                string markCompleted = Console.ReadLine();
                int markCompletedInt = Convert.ToInt32(markCompleted);
                Console.WriteLine("Congratulations! you have earned {} points!\nYou now have {} points.");
                goalHolder[markCompletedInt] = "Completed";
                Console.WriteLine(menu);
            }
        }
    }
}