using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpsls
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputComp;
            int randomNum;

            Console.WriteLine("Choose rock, paper, scissors, lizard, or spock")
                inputPlayer = Console.ReadLine();

            Random random = new Random();
            randomNum = random.Next(1, 6);
            switch (randomNum)
            {
                case 1:
                    inputComp = "rock";
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("draw");
                    }
                     else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("you win");
                    }
                    break;
                case 2:
                    inputComp = "paper";
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("draw");
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("you lose");
                    }
                    break;
                case 3:
                    inputComp = "scissors";
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("draw");
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("you win");
                    }
                    break;
                case 4:
                    inputComp = "lizard";
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("draw");
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("you lose");
                    }
                    break;
                case 5:
                    inputComp = "spock";
                    if (inputPlayer == "rock")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "paper")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "scissors")
                    {
                        Console.WriteLine("you lose");
                    }
                    else if (inputPlayer == "lizard")
                    {
                        Console.WriteLine("you win");
                    }
                    else if (inputPlayer == "spock")
                    {
                        Console.WriteLine("draw");
                    }
                    break;
                default:
                    Console.WriteLine("OOPS");
                    break;
            }
        }
    }
}
