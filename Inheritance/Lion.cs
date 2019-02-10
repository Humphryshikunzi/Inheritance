using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Inheritance
{
     class Lion:Fish
     {
         public Lion(char equalsinn,int rsult) : base(sign:'+')
       {
           
           Console.WriteLine("{0}{1}{2}{3}");  
       }
       public void Eatmeat()

       {
           Name = "23";
            Console.WriteLine("I am eating meat");
            Console.WriteLine(Name);
            IsMale = true;
            Console.WriteLine(IsMale);

       }

      public override void Swim()
       {
           Console.WriteLine("I am swimiimg in Indian Ocean");
           Name = "Elephant";
           Console.WriteLine(Name);
       }
      

    }

   
}
