using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
           var lion=new Lion('=',1000);
           var an=new MyClass();
           lion.Walk();
           lion.Eatmeat();
           lion.Talking();
           lion.Implementment();
           lion.Swim();
           Console.WriteLine(an.ToString());
           string value = Console.ReadLine();
        //   bool checkvalue = int.TryParse(Console.ReadLine());
           if ((value==String.Empty)) throw new NullReferenceException();

           int numbwe = int.Parse(Console.ReadLine());
          




        }

        
    }
}
