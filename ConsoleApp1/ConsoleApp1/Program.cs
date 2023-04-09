using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person test = new Person();

            test.noofeyes = 5;
            test.hariColor = "Red";
            Console.WriteLine("You have " + test.noofeyes + "Eyes.");
            Console.WriteLine(test.hariColor);
            test.genderChoose("maffle");
            string mylunch = test.eatingHabit("chauchau");
            Console.WriteLine(mylunch);
            Console.Read();


            /*Console.WriteLine("TesTing of operator");
            ArithmeticOperator();
            LogicalOperator();
            RelationalOperator();
            BitwiseOperator();
            ShiftingOperator();
            Console.Read();*/
        }
        static void ArithmeticOperator()
        {
            Console.WriteLine("\nTesting of Arithmetic operator");
            Console.WriteLine("Enter First number");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two number");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numOne + numTwo;
            Console.WriteLine("The sum of two number is:" + sum);
        }
        static void LogicalOperator()
        {
            Console.WriteLine("\nTesting of logical operator");
            Console.WriteLine("Enter Your college Name");
            String clz = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter your Program");
            String program = Console.ReadLine().ToUpper();
            if (clz == "BMC" && program == "CSIT")
            {
                Console.WriteLine("Access Granted");
            }
            else
                Console.WriteLine("Access Denied");
        }
        static void RelationalOperator()
        {
            Console.WriteLine("\nTesting of Relational Operator");
            Console.WriteLine("Printing greater number");
            Console.WriteLine("Enter first numbers:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second numbers:");
            int two = Convert.ToInt32(Console.ReadLine());
            var res = (one > two) ? one : two;
            Console.WriteLine("The greater number is:"+res);
        }
        static void BitwiseOperator()
        {
            Console.WriteLine("\nTesting of Bitwise Operator");
            Console.WriteLine("Anding two numbers");
            Console.WriteLine("Enter first numbers:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second numbers:");
            int two = Convert.ToInt32(Console.ReadLine());
            int anding = one & two;
            Console.WriteLine(anding);
        }
        static void ShiftingOperator()
        {
            Console.WriteLine("\nTesting of Shifting Operator");
            Console.WriteLine("Shifting a number");
            Console.WriteLine("Enter a numbers:");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Shifting a number to left multiply it by 2:");
            int two = one << 1;
            Console.WriteLine("The answer is: {0}", two);
        }
    }
}
