using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Elephant:Cow
    {
        public char Sign;

        public Elephant(int firstnumber,int secondnumber)
        {
            this.Name = "Shikunzi";
            
        }
        public void Walk()
        {
            Console.WriteLine("I am walking");
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
    }
}
