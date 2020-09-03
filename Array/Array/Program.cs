using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[5];
            
            Console.WriteLine("Ange ett namn och tryck enter mellan varje 5 gånger.");

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();

            }

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(names[i]);
            }


        }
    }
}
