using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //testing of polymorphism
           // Learningpolymorphism lp = new Learningpolymorphism();
            childClassPoly lp = new childClassPoly();
            childClassPoly lp2 = new childClassPoly("mohit");
            lp.Animal("grass");

            //overloading
            //learning try catch exception
            try
            {
                Console.WriteLine("Enter a number");
                int myNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myNum);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            try//code to run where error may occur
            {
                string[] names = new string[6];
                names[0] = "mohit";
                names[1] = "nepal";
                names[2] = "ajay";
                names[3] = "Anil";
                names[4] = "aarya";
                names[5] = "basanta";
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
