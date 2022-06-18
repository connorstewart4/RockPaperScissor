using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ProgramUI
{
    public void Run()
        {
            RunApplication();
        }
    private void PauseUntilKeyPress()
        {
            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    private void RunApplication()
        {
            bool continueToRun = true;
            while(continueToRun)
            {
                //Console.Clear();
                System.Console.WriteLine("Welcome to Rock Paper Scissors! Please select an option. \n" +
                "1. Play the computer. \n" +
                "2. Exit application. \n");
            string userInput = Console.ReadLine().ToLower();
                switch(userInput)
                {
                    case "1":
                    case "one":
                        PlayComputer();
                    break;
                    case "2":
                    case "two":
                        continueToRun = CloseApplication();
                    break;
                    default:
                        System.Console.WriteLine("Please enter a valid option.");
                    break;
                    }
                PauseUntilKeyPress();
                //count++
                //count = 3
                //return false;
                }

            }
    private void PlayComputer()
    {
        System.Console.WriteLine("What is your play? Please enter rock, paper, or scissors.");
        string userInput = Console.ReadLine();
        // RockPaperScissors rps = new RockPaperScissors();
        // rps.userInput = (RPS)userInput;

        Random rnd = new Random();
        int compInput = rnd.Next(1, 4);
        /*RockPaperScissors crps = new RockPaperScissors();
        crps.compInput = (RPS)compInput;*/
        switch(compInput)
            {
                case 1:
                compInput = 1;
                Console.WriteLine("Computer chose rock.");
                if (userInput == "paper")
                {
                    Console.WriteLine("You win! Press any key to return to menu.");
                }
                else if (userInput == "scissors")
                {
                    Console.WriteLine("You lose. Press any key to return to menu.");
                }
                else if (userInput == "rock")
                {
                    Console.WriteLine("It's a tie! Press any key to return to menu.");
                }
                else
                {
                    System.Console.WriteLine("invalid entry, press any key to return to menu.");
                }
                break;
                case 2:
                compInput = 2;
                Console.WriteLine("Computer chose paper.");
                if (userInput == "scissors")
                {
                    Console.WriteLine("You win! Press any key to return to menu.");
                }
                else if (userInput == "rock")
                {
                    System.Console.WriteLine("You lose. Press any key to return to menu.");
                }
                else if (userInput == "paper")
                {
                    Console.WriteLine("It's a tie! Press any key to return to menu.");
                }
                else
                {
                    System.Console.WriteLine("invalid entry, press any key to return to menu.");
                }
                break;
                case 3:
                compInput = 3;
                Console.WriteLine("Computer chose scissors.");
                if (userInput == "rock")
                {
                    Console.WriteLine("You win! Press any key to return to menu.");
                }
                else if (userInput == "paper")
                {
                    Console.WriteLine("You lose. Press any key to return to menu.");
                }
                else if (userInput == "scissors")
                {
                    Console.WriteLine("It's a tie! Press any key to return to menu.");
                }
                else
                {
                    System.Console.WriteLine("invalid entry, press any key to return to menu.");
                }
                break;
                default:
                Console.WriteLine("Invalid entry, press any key to return to menu.");
                break;
            }
        }
/*public Random random {get;} = new Random();
int computerInput = randomNumber.Next(1,4);
}
/*public Random randomNumber {get;} = new Random();
Call upon Update method in Repo to have "scorecared"
Also repo: read result/ scorecard
Do you want to play? "(Create)"
Input (Response)
Update Computer input
Update Victory
(Return/read) results
Delete (delete scorecard)
(exit code, part of a switch)
 case "x":
    isRunning = CloseApplication();
    break;*/
    private bool CloseApplication()
        {
            Console.Clear();
            System.Console.WriteLine("Thank you for playing.");
            PressAnyKeyExit();
            return false;
        }
    private void PressAnyKey()
    {
        System.Console.WriteLine("Press ANY KEY to return home...");
        Console.ReadKey();
    }

    private void PressAnyKeyExit()
    {
        System.Console.WriteLine("Press ANY KEY to Exit...");
        Console.ReadKey();
    }
}
    //  public class ProgramUI
    // {
    //     public void Run()
    //     {
    //         RunMenu();
    //     }

    //     private void PauseUntilKeyPress()
    //     {
    //         System.Console.WriteLine();
    //         Console.ReadLine();
    //     }

    //     private void RunMenu()
    //     {
    //         bool continueToRun = true;

    //         while(continueToRun)
    //         {
    //             Console.Clear();
    //             System.Console.WriteLine("Please enter an option. \n" +
    //             "1. Play the computer. \n" +
    //             "2. Exit application. \n" 
    //             );
    //             PauseUntilKeyPress();
    //         }

    //         string userInput = System.Console.ReadLine();
    //             switch(userInput)
    //             {
    //                 case "1":
    //                 case "one":
    //                     PlayComputer();
    //                     break;
    //                 case "2":
    //                 case "two":
    //                     continueToRun = false;
    //                     System.Console.WriteLine("Thanks for playing Rock Paper Scissors!");
    //                     break;
    //                 default:
    //                     System.Console.WriteLine("Please enter a valid option.");
    //                     break;
    //             }

    //     }

    //     private void PlayComputer()
    //     {
    //        Console.Clear();
    //        System.Console.WriteLine("Please enter Rock, Paper, or Scissors.");
    //        string userInput = Console.ReadLine.ToLower();
    //        int inputID = int.Parse(userInput);
    //        RockPaperScissors rps = new RockPaperScissors();
    //        rps.userInput = (RPS)inputID;
    //        public Random randomNumber {get;} = new Random();
    //        int computerInput = rnd.Next(1,4);
        
    //     }
    // }
    
    /*(exit code, part of a switch)
 case "x":
    isRunning = CloseApplication();
    break;
private bool CloseApplication()
    {
        Console.Clear();
        System.Console.WriteLine("Thank you.");
        PressAnyKey();
        return false;*/

    //}
