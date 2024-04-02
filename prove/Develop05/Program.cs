using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int userInput = 0;
        int totalPoints = 0;
        Console.Write("Welcome to the Goal Tracker. Press enter to start program: ");
        Console.ReadLine();
        List<String> goals = new List<String>();
        List<String> separatedGoals = new List<String>();
        Console.Clear();

        while(userInput != 6)
        {   
            Console.Clear();
            Console.WriteLine($"\nYou have {totalPoints} points");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1: //create new goal
                    Console.Clear();
                    Console.Write("The types of Goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\n\nWhich type of goal would you like to create? ");
                    int userGoal = int.Parse(Console.ReadLine());
                    switch (userGoal)
                    {
                        case 1:   //create simple goal
                            SimpleGoal simpleGoal = new SimpleGoal("Simple Goal", "This is a simple goal.",0,false);
                            simpleGoal.CreateGoal();
                            goals.Add(simpleGoal.GoalStatus());
                            separatedGoals.Add(simpleGoal.SeparateGoal());
                            break;


                        case 2:    //create eternal goal
                            EternalGoal eternalGoal = new EternalGoal("Eternal Goal", "This is an eternal goal.",0,false);
                            eternalGoal.CreateGoal();
                            goals.Add(eternalGoal.GoalStatus());
                            separatedGoals.Add(eternalGoal.SeparateGoal());
                             break;

                        case 3:    //create checklist goal
                        ChecklistGoal checklistGoal = new ChecklistGoal("Checklist Goal", "This is a checklist goal.",0,false,0,0,0);
                        checklistGoal.CreateGoal();
                        goals.Add(checklistGoal.GoalStatus());
                        separatedGoals.Add(checklistGoal.SeparateGoal());
                            break;

                        default:
                            Console.WriteLine("Please enter a valid number");
                        break;
                    }

                    break;

                case 2: //list goals
                    Console.Clear();
                    int goalIndex = 0;
                    foreach (String goal in goals)
                    {
                        goalIndex++;
                        Console.WriteLine($"{goalIndex}. {goal}");
                    }
                    Console.WriteLine("Click enter to continue");
                    Console.ReadLine();
                    break;

                case 3: //save goals
                    Console.Clear();
                    Console.WriteLine("What would you like to name your file?");
                    string saveFileName = Console.ReadLine();
                    saveFileName = $"{saveFileName}.txt";

                    using (StreamWriter outputFile = new StreamWriter(saveFileName))
                    {
                        outputFile.WriteLine(totalPoints);
                        foreach (String goal in separatedGoals)
                        {
                            outputFile.WriteLine(goal);
                        }
                    }
                    break;

                case 4: // Load goals
                    Console.Clear();
                    goals.Clear();
                    separatedGoals.Clear();

                    Console.WriteLine("Enter the filename to load:");
                    string loadFileName = Console.ReadLine();
                    loadFileName = $"{loadFileName}.txt";

                    string[] lines = System.IO.File.ReadAllLines(loadFileName);
                    bool isFirstLine = true;
                    foreach (string line in lines)
                    {
                        if (isFirstLine)
                        {
                            totalPoints = int.Parse(lines[0]);
                            isFirstLine = false;
                            continue;
                        }

                        string[] parts = line.Split(':');
                        string goalType = parts[0];
                        string goalDetails = parts[1];

                        string[] details = goalDetails.Split(',');
                        string goalName = details[0];
                        string goalDescription = details[1];
                        int goalPoints = int.Parse(details[2]);


                        switch (goalType)
                        {
                            case "SimpleGoal":
                                bool isComplete = bool.Parse(details[3]);
                                SimpleGoal loadedSimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, isComplete);
                                goals.Add(loadedSimpleGoal.GoalStatus());
                                separatedGoals.Add(loadedSimpleGoal.SeparateGoal());
                                break;

                            case "EternalGoal":
                                EternalGoal loadedEternalGoal = new EternalGoal(goalName, goalDescription, goalPoints, false);
                                goals.Add(loadedEternalGoal.GoalStatus());
                                separatedGoals.Add(loadedEternalGoal.SeparateGoal());
                                break;

                            case "ChecklistGoal":
                                bool isCompleteChecklist = bool.Parse(details[3]);
                                int bonus = int.Parse(details[4]);
                                int timesToComplete = int.Parse(details[5]);
                                int timesCompleted = int.Parse(details[6]);
                                ChecklistGoal loadedChecklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, isCompleteChecklist, bonus, timesToComplete, timesCompleted);
                                goals.Add(loadedChecklistGoal.GoalStatus());
                                separatedGoals.Add(loadedChecklistGoal.SeparateGoal());
                                break;

                            default:
                                break;
                        }
                    }
                    break;

                case 5: // Record event
                    Console.Clear();
                    int goalCounter = 0;
                    foreach (String goal in goals)
                    {
                        goalCounter++;
                        Console.WriteLine($"{goalCounter}. {goal}");
                    }

                    Console.Write("Which goal did you accomplish? ");
                    int userEvent = int.Parse(Console.ReadLine());

                    string completedGoal = separatedGoals[userEvent - 1];
                    string[] parts2 = completedGoal.Split(':'); //was a comma before this change
                    string completedGoalType = parts2[0];
                    string completedGoalDetails = parts2[1];

                    switch (completedGoalType)
                    {
                        case "SimpleGoal":
                            string[] simpleDetails = completedGoalDetails.Split(',');
                            SimpleGoal simpleGoal = new SimpleGoal(simpleDetails[0], simpleDetails[1], int.Parse(simpleDetails[2]), true);
                            goals[userEvent - 1] = simpleGoal.GoalStatus();
                            separatedGoals[userEvent - 1] = simpleGoal.SeparateGoal();
                            totalPoints += simpleGoal.GetGoalPoints();
                            break;

                        case "EternalGoal":
                            string[] eternalDetails = completedGoalDetails.Split(',');
                            EternalGoal eternalGoal = new EternalGoal(eternalDetails[0], eternalDetails[1], int.Parse(eternalDetails[2]), false);
                            goals[userEvent - 1] = eternalGoal.GoalStatus();
                            separatedGoals[userEvent - 1] = eternalGoal.SeparateGoal();
                            totalPoints += eternalGoal.GetGoalPoints();
                            break;

                        case "ChecklistGoal":
                            string[] checklistDetails = completedGoalDetails.Split(',');
                            bool isComplete2 = bool.Parse(checklistDetails[3]);
                            int bonus2 = int.Parse(checklistDetails[4]);
                            int timesToComplete2 = int.Parse(checklistDetails[5]);
                            int timesCompleted2 = int.Parse(checklistDetails[6]);
                            Console.Write("How many times did you accomplish this goal? ");
                            timesCompleted2 += int.Parse(Console.ReadLine());

                            if (timesCompleted2 == timesToComplete2) //was >= before this change
                            {
                                totalPoints += bonus2;
                                isComplete2 = true;
                            }

                            ChecklistGoal checklistGoal = new ChecklistGoal(checklistDetails[0], checklistDetails[1], int.Parse(checklistDetails[2]), isComplete2, bonus2, timesToComplete2, timesCompleted2);
                            goals[userEvent - 1] = checklistGoal.GoalStatus();
                            separatedGoals[userEvent - 1] = checklistGoal.SeparateGoal();
                            totalPoints += checklistGoal.GetGoalPoints();
                            break;

                        default:
                            break;


                    }
                    break;


                case 6: //quit
                    Console.Clear();
                    Console.WriteLine("\nGoodbye!");
                    break;

                default:
                    Console.WriteLine("Please enter a valid number");
                    break;
            }
        }
    }
}