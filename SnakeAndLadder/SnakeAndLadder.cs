using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        public static void snakeAndLadder()
        {
            String Player = "Priyanshu";
            int position = 0;

            Random random = new Random();

            int dice = random.Next(1, 7);

            Console.WriteLine("{1} got {0} from dice",dice,Player);

            //updating position 

            position += dice;

            Console.WriteLine("{0} position is {1} ",Player,position);
        }
    }
}
