using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class   Fish:Elephant
    {
       
        public Fish(char sign) : base(45, 98)
        {
            Sign = sign;
            Name = "Cow";

        }
        public virtual void Swim()
        {
            Console.WriteLine("I am swimming in Lake Victoria");
            Name = "4";
            
        }
    }
}
