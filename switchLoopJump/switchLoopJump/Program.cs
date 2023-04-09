using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace switchLoopJump
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Testing of loop ");
            while (true)
            {
                Console.WriteLine("\ninput the value for test");
                int inp=Convert.ToInt32(Console.ReadLine());
                switch (inp)
                {
                    case 1:
                        Console.WriteLine("Today is weekend");
                        break;
                    case 2:
                        Console.WriteLine("Testing of loop");
                        Console.WriteLine("testing for loop");
                        for (int i = 0; i < 5 ; i++)
                        {
                            Console.WriteLine("The value of i is" + i);
                        }
                        break;
                    case 3:
                        Console.WriteLine("testing of for each loop");
                        string[] country = { "Nepal", "USA", "Aus", "china", "india" };
                        foreach (string test in country)
                            Console.WriteLine(test + "\t");
                        break;

                    case 4:
                        Console.WriteLine("testing of while loop before switch statement");
                        break;
                    case 5:
                        Console.WriteLine("testing of do while loop");
                        int x = 0;
                        do
                        {
                            Console.WriteLine("x= " + x + "\t");
                            x++;
                        } while (x < 5);
                        break;
                    case 6:
                        goto testingGoto;
                           
                    default:
                        Console.WriteLine("testing of Switch loop and jump statement");
                        return;
                }
            }
        testingGoto:
            Console.WriteLine("testing of goto");
            Console.Read();
        }
    }
}
