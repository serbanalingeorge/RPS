using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Scissors : IShape
    {
        public void Use(string shape)
        {
            switch (shape)
            {
                case "1":
                    Console.WriteLine("LOST");
                    break;
                case "2":
                    Console.WriteLine("WON");
                    break;
                case "3":
                    Console.WriteLine("DRAW");
                    break;
                default:
                    Console.WriteLine("Not an option");
                    break;
            }
        }
    }
}
