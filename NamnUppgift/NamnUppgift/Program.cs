using System;

namespace NamnUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Skriv ditt namn:");

            string name = Console.ReadLine();

            Console.WriteLine("Du heter:" + name);

            Console.WriteLine("Är du vid liv? y/n");
            var answear = Console.ReadLine();

            if (answear == "y")
            {

                Console.WriteLine("Du lever, de var ju roligt");

            }
            else
            {

                Console.WriteLine("Too bad du e död ditt n00b");

            }
            

            Console.WriteLine("Vänligen ange din ålder: ");

            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 40) {

                Console.WriteLine("Du var fett gammal mannen! Du är:" + age + "år gammal");

            }

            else
            {

                Console.WriteLine("Du är inte så gammal, grattis! Du är: " + age + "år gammal");

            }
            
        }
    }
}
