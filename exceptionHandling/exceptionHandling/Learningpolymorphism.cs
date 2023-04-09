using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    internal interface Learningpolymorphism
    {
        void Animal();
        //{
        //    Console.WriteLine("Cow eat grass");
        //}
        void Animal(string food);
        void Animal(string food, string animal);
        //{
        //    Console.WriteLine(animal + "eat" + food);
        //}
        
    }
}