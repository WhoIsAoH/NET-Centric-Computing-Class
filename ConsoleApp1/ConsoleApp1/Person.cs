using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        int numberofeyes;
        public int noofeyes
        {
            get
            {
                return numberofeyes;
            }
            set
            {
                numberofeyes = value;
            }
        }
        public string hariColor { get; set; }
        public void genderChoose(string gender)
        {
            if (gender.ToUpper() == "MALE") { Console.WriteLine("You are Male"); }
            else Console.WriteLine("You are Female");
        }
        
        public string eatingHabit(string mylunch)
        {
            return "I usually eat " + mylunch;
        }
    }
}
