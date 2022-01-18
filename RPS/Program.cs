using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            String choice = "";
            String aiChoice = "";
            String result = "";
            var rand = new Random();
            Boolean keepPlayingCheck = true;
            String keepPlaying = "";

            Console.WriteLine("Hello!\nWelcome to a simple game of rock paper scissors!");

            do
            {
                choice = getChoice();


                Console.WriteLine("You chose " + choice);
                aiChoice = getChoice(rand.Next(3) + 1);
                Console.WriteLine("The computer chose " + aiChoice);
                result = findResult(choice, aiChoice);
                Console.WriteLine(result);
                Console.Write("Play again (Y/N)?: ");
                keepPlaying = Console.ReadLine();

                if (keepPlaying == "N" || keepPlaying == "NO" || keepPlaying == "no" || keepPlaying == "No")
                    keepPlayingCheck = false;

            } while (keepPlayingCheck == true);
            Console.ReadLine();
            


        }


        public static String getChoice()
        {
            String userChoice = "";
            String choice = "";
        do
        {
            Console.WriteLine("What do you want to pick?\n1) Rock\n2) Paper\n3) Scissors\n4) Quit");
            userChoice = Console.ReadLine();
            if (userChoice == "Rock" || userChoice == "rock" || userChoice == "1" || userChoice == "ROCK")
                choice = "Rock";
            else if (userChoice == "Paper" || userChoice == "paper" || userChoice == "2" || userChoice == "PAPER")
                choice = "Paper";
            else if (userChoice == "Scissors" || userChoice == "scissors" || userChoice == "3" || userChoice == "SCISSORS")
                choice = "Scissors";
            else if (userChoice == "Quit" || userChoice == "quit" || userChoice == "4" || userChoice == "QUIT")
                Environment.Exit(0);
            else
                Console.WriteLine("Please pick a valid option!");
            } while (choice == "");
            return choice;

        }

        public static String getChoice(int aiChoice)
        {
            
            String choice = "";

            if (aiChoice == 1)
                choice = "Rock";
            else if (aiChoice == 2)
                choice = "Paper";
            else if (aiChoice == 3)
                choice = "Scissors";
            
            return choice;
        }

       public static String findResult (String me, String ai)
        {
            if (me == ai)
                return "It's a tie!";

            else if ((me == "Rock" && ai == "Paper") || (me == "Paper" && ai == "Scissors") || (me == "Scissors" && ai == "Rock"))
                return "You Lose!";

            else return "You win!";
        }
    }
}
