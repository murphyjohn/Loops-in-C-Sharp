using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Remove the comment slashes to call whichever of the methods you wish to run for Exercises 1-5.
            // Ex1();
            // Ex2();
            // Ex3();
           // Ex4();
          //  Ex5();
        }

        /* Exercise 1
         * Create a program that continues to ask the user to enter a number until the user enters 0.
         */
        static void Ex1()
        {
            String numStr;
            int num = 1;

            while (num != 0)
            {
                Console.WriteLine("Please enter 0");
                numStr = Console.ReadLine();
                num = Convert.ToInt32(numStr);
            }
            if (num ==0)
            {
                Console.WriteLine("Thank you");
            }
            else
            {
                Console.WriteLine("Try again");
            }
        }

        /*Exercise 2
         * Create a program that asks the user to enter a number between 1 and 3, then using the if-else conditional construct print 
         * "You have entered [the number]" for each number 1-3, and print "I told you to enter a number between 1 and 3" if any other number is entered.
         */
        static void Ex2()
        {
            String numStr;
            int num;
            Console.WriteLine("Please enter a number between 1 and 3");
            numStr = Console.ReadLine();
            num = Convert.ToInt32(numStr);

            if(num == 1)
            {
                Console.WriteLine("You have entered 1");
            }
            else if(num == 2)
            {
                Console.WriteLine("You have entered 2");
            }
            else if (num == 3)
            {
                Console.WriteLine("You have entered 3");
            }
            else
            {
                Console.WriteLine("I told you to enter a number between 1 and 3");
            }

        }

        /* Exercise 3
         * Create a program that asks the user to enter 2 numbers. The program should then prompt the user to enter a +-// operator and using a condition
         * statement print the result of the operation on the numbers.
         */
        static void Ex3()
        {
            String numStr1, numStr2;
            String opr;
            int num1, num2;

            Console.WriteLine("Please enter your first number");
            numStr1 = Console.ReadLine();
            num1 = Convert.ToInt32(numStr1);
            Console.WriteLine("Please enter your second number");
            numStr2 = Console.ReadLine();
            num2 = Convert.ToInt32(numStr2);
            Console.WriteLine("Please enter your arithmetic operator");
            opr = Console.ReadLine();


            if (opr.Equals("+"))
            {
                Console.WriteLine(num1 + num2);
            }
            else if (opr.Equals("-"))
            {
                Console.WriteLine(num1 - num2);
            }
            else if (opr.Equals("*"))
            {
                Console.WriteLine(num1 * num2);
            }
            else if (opr.Equals("/"))
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("invalid operator");
            }

        }

        /* Exercise 4
         * Add a while loop to the above program so that the program continues to run until the user enters % for the operator.
         */
        static void Ex4()
        {
            String numStr1, numStr2;
            String opr;
            int num1, num2;

            Console.WriteLine("Please enter your first number");
            numStr1 = Console.ReadLine();
            num1 = Convert.ToInt32(numStr1);
            Console.WriteLine("Please enter your second number");
            numStr2 = Console.ReadLine();
            num2 = Convert.ToInt32(numStr2);
            Console.WriteLine("Please enter your arithmetic operator");
            opr = Console.ReadLine();

            while (opr != "%")
            {
                Console.WriteLine("please enter \"%\" for the operator");
                opr = Console.ReadLine();
            }

            if (opr.Equals("+"))
            {
                Console.WriteLine(num1 + num2);
            }
            else if (opr.Equals("-"))
            {
                Console.WriteLine(num1 - num2);
            }
            else if (opr.Equals("*"))
            {
                Console.WriteLine(num1 * num2);
            }
            else if (opr.Equals("/"))
            {
                Console.WriteLine(num1 / num2);
            }
            else if(opr.Equals("%")){
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("please enter \"%\" for the operator");
                opr = Console.ReadLine();
            }
            
                
            
        }

        /* Exercise 5
         * Ceate a program that initialises an array with the numbers 0-99. 
         * Then use a loop to iterate through the contents of the array and a conditional statement to print all of the odd numbers in the array
         * to the console.
         */
        static void Ex5()
        {
            int i = 0;
            int[] numArray=new int[100];

            for (i = 0; i < 100; i++)
            {
                numArray[i] = i;
            }

            for( int j = 0; j < 100; j++)
            {
                if(numArray[j]%2 != 0)
                {
                    Console.WriteLine(numArray[j]);
                }
            }
        }

    }
}
