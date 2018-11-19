using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Player
    {
        IShape shape;

        public void UserInputShape(string userInput)
        {
            Console.WriteLine("Choose to play with: \n1 for ROCK \n2 for PAPER \n3 for SCISSORS");
            switch (userInput)
            {
                case "1":
                    shape = new Rock();
                    break;
                case "2":
                    shape = new Paper();
                    break;
                case "3":
                    shape = new Scissors();
                    break;
                default:
                    Console.WriteLine("Not an option");
                    break;
            }
            string input = Console.ReadLine();
            shape.Use(input);
        }
    }
}
