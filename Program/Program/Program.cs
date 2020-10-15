using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            Console.WriteLine("Enter the name of customer1");
            customer1._name = Console.ReadLine();
            Console.WriteLine("Enter age of " + customer1._name);
            customer1._age = Convert.ToInt32(Console.ReadLine());

            Product products = new Product();
            ProductChild b = new ProductChild();


            Console.WriteLine("Type 1 to choose banana");
            Console.WriteLine("Type 2 to choose avocado");
            Console.WriteLine("Type 3 to choose fish");
            Console.WriteLine("Type 4 to view your cart");
            Console.WriteLine("Type 5 to leave the store without paying (badboy)");
            Console.WriteLine("Type 6 to pay and leave");


            bool looper = true;

            while (looper)
            {
                Console.WriteLine("Enter a number");
                int customerInput = Convert.ToInt32(Console.ReadLine());

                switch (customerInput)
                {
                    case 1:
                        Console.WriteLine("Type 1 to get a Fresh banana");
                        Console.WriteLine("Type 2 to get a Bad banana");
                        int customerInput2 = Convert.ToInt32(Console.ReadLine());

                        switch (customerInput2)
                        {
                            case 1:
                                customer1._cart.Add(b._bananaFresh);
                                break;

                            case 2:
                                customer1._cart.Add(b._bananaBad);
                                break;
                        }

                        break;
                    case 2:
                        customer1._cart.Add(products._avocado);
                        break;

                    case 3:
                        customer1._cart.Add(products._fish);
                        break;


                    case 4:
                        string listItems = "";
                        foreach (var orderItem in customer1._cart)
                        {
                            listItems += orderItem + " , ";
                        }
                        Console.WriteLine(listItems);
                        break;


                    case 5:
                        looper = false;
                        Console.WriteLine("You didnt pay, badboy");
                        break;

                    case 6:
                        looper = false;
                        Console.WriteLine("Bye bye mr " + customer1._name + " who is also " + customer1._age + " years old");
                        break;

                    default:
                        Console.WriteLine("" + "Invalid input, retard");
                        break;
                }

            }







        }
    }
}
