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
                    break;
                case 2:
                    inputComp = "paper";
                    break;
                case 3:
                    inputComp = "scissors";
                    break;
                case 4:
                    inputComp = "lizard";
                    break;
                case 5:
                    inputComp = "spock";
                    break;
                default:
                    break;
            }
        }
    }
}
