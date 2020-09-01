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

            else if(age < 10)
            {

                Console.WriteLine("Du är var mysteriskt ung! Du är: " + age + "år gammal");

            }
            else
            {
                Console.WriteLine("Du är ganska ung, grattis! Du är:" + age + "år gammal");
            }

            for(var i = 0; i > 10; i++)
            {
                Console.WriteLine(i);

            }

            int choose = 0;

            while (choose > 1 || choose < 3)
            {
                Console.WriteLine("Ange en siffra mellan 1 och 3");

                choose = Convert.ToInt32(Console.ReadLine());

                switch (choose)
                {
                    case 1: Console.WriteLine("Du valde fall 1, där händer inget alls!");
                        break;

                    case 2: Console.WriteLine("Du valde fall 2, där händer det inte nånting alls heller!");
                        break;

                    case 3: Console.WriteLine("Du valde fall 3, och till din stora överaskning så hände inget där heller!");
                            break;

                }
                break;


            }

            Console.WriteLine("Slut!");
        }
    }
}
