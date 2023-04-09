using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptionHandling
{
    //inheritance
    internal class childClassPoly:Learningpolymorphism
    {
        public childClassPoly()
        {
            Console.WriteLine("this is constructor running at last");
        }
        public childClassPoly(string name)
        {
            Console.WriteLine("this is constructor running at last with the name; {0}",name);
        }
        ~childClassPoly() { }
        
        public void Animal(string food)
        {
            Console.WriteLine("cow eat"+food);
        }
        public void Animal()
        {
            Console.WriteLine("testing animal function");
        }
        public void Animal(string food, string animal)
        {
            Console.WriteLine(animal + "eat" + food);
        }
        
    }
}
