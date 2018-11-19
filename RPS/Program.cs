using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("Choose Shape to play: \n1 ROCK \n2 PAPER \n3 SCISSORS");
            string input = Console.ReadLine();
            player.UserInputShape(input);
            
            Console.ReadKey();
        }
     
    }

}
