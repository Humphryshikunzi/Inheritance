using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cow:Animal
    {
        public void Talking()
        {
            Console.WriteLine("i say Moooh");
        }

        public override void Implementment()
        {
            Console.WriteLine("I am implementing class Animal");
        }
    }
}
