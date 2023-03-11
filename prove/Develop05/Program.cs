using System;
using System.Collections;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        ArrayList goalHolder = new ArrayList();
        ArrayList goalHolderCsv = new ArrayList();

        string menu = "Menu options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Remove Goal\n 7. Quit\nSelect a choice from the menu:";
        Console.WriteLine(menu);

        string choice = "";
        while(choice != "7"){
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
                    int points = int.Parse(Console.ReadLine());
                    Simple simple = new Simple(false, name, description, points);
                    goalHolder.Add(simple.ToGoalFormat());
                    goalHolderCsv.Add(simple.ToCsvFormat());

                    Console.Clear();
                    Console.WriteLine(menu);


                }
                else if(goalType == "2"){
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Eternal eternal = new Eternal(name, description, points);
                    goalHolder.Add(eternal.ToGoalFormat());
                    goalHolderCsv.Add(eternal.ToCsvFormat());

                    Console.Clear();
                    Console.WriteLine(menu);
                    

                }
                else if(goalType == "3"){
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short descripiton of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int times = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times?");
                    int bonus = int.Parse(Console.ReadLine());
                    Checklist checklist = new Checklist(false, name, description, points, times, bonus);
                    goalHolder.Add(checklist.ToGoalFormat());
                    goalHolderCsv.Add(checklist.ToCsvFormat());

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
               using (StreamWriter outputFile = new StreamWriter(filename))

               foreach(string goal in goalHolderCsv){
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
                    string[] parts = line.Split(",");

                    string goalType = parts[0];
                    if(goalType == "Simple"){
                        Boolean completed = bool.Parse(parts[1]);
                        string name = parts[2];
                        string description = parts[3];
                        int points = int.Parse(parts[4]);

                        Simple simple = new Simple(completed, name, description, points);
                        goalHolder.Add(simple.ToGoalFormat());
                        goalHolderCsv.Add(simple.ToCsvFormat());

                    }
                    else if(goalType == "Eternal"){
                        Boolean completed = bool.Parse(parts[1]);
                        string name = parts[2];
                        string description = parts[3];
                        int points = int.Parse(parts[4]);

                        Eternal eternal = new Eternal(name, description, points);
                        goalHolder.Add(eternal.ToGoalFormat());
                        goalHolderCsv.Add(eternal.ToCsvFormat());

                    }
                    else if(goalType == "Checklist"){
                        Boolean completed = bool.Parse(parts[1]);
                        string name = parts[2];
                        string description = parts[3];
                        int points = int.Parse(parts[4]);
                        int times = int.Parse(parts[5]);
                        int bonus = int.Parse(parts[6]);

                        Checklist checklist = new Checklist(completed, name, description, points, times, bonus);
                        goalHolder.Add(checklist.ToGoalFormat());
                        goalHolderCsv.Add(checklist.ToCsvFormat());
                    }
                }
               
                Console.WriteLine($"\n{menu}");

            }
            else if(choice == "5"){
                //todo: each part of the string separated by " " and then put that into another string
                //that starts with "[X]"
                Console.WriteLine("Which goal did you accomplish");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                object selectedGoal = goalHolder[goalIndex];
                string selectedGoalAsString = selectedGoal.ToString();
                goalHolder[goalIndex] = Goal.MarkComplete(selectedGoalAsString);


                Console.WriteLine(menu);
            }
            else if(choice == "6"){
                Console.WriteLine("Which goal would you like to remove?");
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                goalHolder.RemoveAt(goalIndex);
                goalHolderCsv.RemoveAt(goalIndex);

                Console.WriteLine(menu);
            }
            }
        }
    }