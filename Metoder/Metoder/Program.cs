using System;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr  = { 1, 2, 3, 4, 5};

            string[] wordArr = { "king", "are", "you", "glad", "you", "are", "king" };


            Console.WriteLine(AddArray(numArr));

            Console.WriteLine(Reverse_array(wordArr));

            FindBounds(numArr);
        }

        
        public static int AddArray(int[] numArray)
        {
            int sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += numArray[i];
            }
            return sum;
        }

       
        public static string Reverse_array(string[] strArr)
        {
            string reverseArr = "";

            for (int i = strArr.Length - 1; i >= 0; i--)
            {
                reverseArr += strArr[i];
                reverseArr += " ";
            }
            return reverseArr;
        }

       
        public static void FindBounds(int[] numArray)
        {
            int smallestNum = numArray[0];
            int biggestNum = numArray[0];

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < smallestNum)
                {
                    smallestNum = numArray[i];
                }
                else if (numArray[i] > biggestNum)
                {
                    biggestNum = numArray[i];
                }
            }
            Console.WriteLine("The biggest number in the list is: " + biggestNum);
            Console.WriteLine("The smallest number in the list is: " + smallestNum);
        }

    }

       

        }




    
