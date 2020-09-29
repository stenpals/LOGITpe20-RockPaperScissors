using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string computerGuess;

            int userState = 0;
            int computerState = 0;
            Console.WriteLine("Hello, what's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! Welcome to rock, paper, scissors!");

            while (userState < 3 && computerState < 3)
            {
                Console.WriteLine("Rock, paper, or scissors?");
                userInput = Console.ReadLine().ToLower();

                Random rnd = new Random();

                int randomNumber = rnd.Next(1, 4);

                if (randomNumber == 1)
                {
                    computerGuess = "rock";
                }
                else if (randomNumber == 2)
                {
                    computerGuess = "paper";
                }
                else
                {
                    computerGuess = "scissors";
                }

                if (userInput == computerGuess)
                {
                    Console.WriteLine($"It's a draw! The computer also chose {userInput}");
                }
                else if (userInput == "rock" && computerGuess == "scissors")
                {
                    userState++;
                    Console.WriteLine($"You got a point! The computer chose scissors. You now have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "rock" && computerGuess == "paper")
                {
                    computerState++;
                    Console.WriteLine($"You lost! The computer chose paper. You have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "paper" && computerGuess == "rock")
                {
                    userState++;
                    Console.WriteLine($"You got a point! The computer chose rock. You now have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "paper" && computerGuess == "scissors")
                {
                    computerState++;
                    Console.WriteLine($"You lost! The computer chose scissors. You have {userState} points and the compter has {computerState} points.");
                }
                else if (userInput == "scissors" && computerGuess == "paper")
                {
                    userState++;
                    Console.WriteLine($"You got a point! The computer chose paper. You now have {userState} points and the computer has {computerState} points.");
                }
                else if (userInput == "scissors" && computerGuess == "rock")
                {
                    computerState++;
                    Console.WriteLine($"You lost! The computer chose rock. You have {userState} points and the computer has {computerState} points.");
                }
                else
                {
                    Console.WriteLine("Sorry, please try again!");
                }

            }
            if (userState == 3)
            {
                Console.WriteLine("You won! The computer lost, congrats!!");
            }
            else
            {
                Console.WriteLine("The computer won. We 3's get them next time.");
            }
        }
    }
}