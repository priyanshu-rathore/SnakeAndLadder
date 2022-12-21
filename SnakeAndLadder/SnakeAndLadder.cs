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


            //checking option UC3

            int check = random.Next(0, 3);

            if(check == 0)
            {
                Console.WriteLine("No Play");
                Console.WriteLine(Player+" postion is "+position);
            }else if(check == 1)
            {
                Console.WriteLine("Ladder");
                dice = random.Next(1, 7);
                position += dice;
                Console.WriteLine("Number in die is {0}",dice);
                Console.WriteLine("{0} position is {1}",Player,position);

            }
            else
            {
                Console.WriteLine("Snake");
                dice = random.Next(1, 7);
                position -= dice;
                if (position < 0) { 
                    position = 0;
                }
                Console.WriteLine("Number in die is {0}", dice);
                Console.WriteLine("{0} postion is {1}",Player,position);
            }


        }
    }
}
