using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Players
    {
        public static void players()
        {
            Console.WriteLine("Enter Player Names :");
            string playerOne = Console.ReadLine();
            string playerTwo = Console.ReadLine();

            int posOne = 0, posTwo = 0, count = 1, dice = 0;

            Random random = new Random();

            while (posOne <= 100 || posTwo <= 100)
            {
                if (count % 2 == 0)
                {
                    int check = random.Next(0, 2);
                    if (check == 0)
                    {
                        Console.WriteLine("Snake");
                        dice = random.Next(1, 7);
                        posOne -= dice;
                        if (posOne < 0)
                        {
                            posOne = 0;
                        }
                        Console.WriteLine(playerOne + " is at postion " + posOne);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Ladder");
                        dice = random.Next(1, 7);
                        posOne += dice;
                        Console.WriteLine(playerOne + " is at position " + posOne);
                        Console.WriteLine("");
                    }
                    count++;

                }
                else
                {
                    int check = random.Next(0, 2);
                    if (check == 0)
                    {
                        Console.WriteLine("Snake");
                        dice = random.Next(1, 7);
                        posTwo -= dice;
                        if (posTwo < 0)
                        {
                            posTwo = 0;
                        }
                        Console.WriteLine(playerTwo + " is at postion " + posTwo);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("Ladder");
                        dice = random.Next(1, 7);
                        posOne += dice;
                        Console.WriteLine(playerTwo + " is at position " + posTwo);
                        Console.WriteLine("");
                    }
                    count++;
                }

                if (posOne > posTwo)
                {
                    Console.WriteLine(playerOne + " Wins");
                }
                else
                {
                    Console.WriteLine(playerTwo + " Wins");
                }
            }
        }
    }
}
