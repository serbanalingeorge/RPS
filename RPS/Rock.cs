using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{
    class Rock : IShape
    {
        public void Use(string shape)
        {
            switch (shape)
            {
                case "1":
                    Console.WriteLine("DRAW");
                    break;
                case "2":
                    Console.WriteLine("LOST");
                    break;
                case "3":
                    Console.WriteLine("WON");
                    break;
                default:
                    Console.WriteLine("Not an option");
                    break;
            }
        }
    }
}
