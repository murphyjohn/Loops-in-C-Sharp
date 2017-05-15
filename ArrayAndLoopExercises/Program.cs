using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndLoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
        }

        /* EXERCISE 1
         * Create and initialise an array of type int with the numbers 1-10 and print the numbers to the screen */
         static void Ex1()
        {
            int[] intArray = new int[10];
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = (i + 1);
                Console.WriteLine(intArray[i]);
            }

        }

        /*EXERCISE 2
         * Using a for loop print the contents of the array to the screen*/
         static void Ex2()
        {
            int[] intArray = new int[10];
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = (i + 1);
                Console.WriteLine(intArray[i]);
            }
        }

        /*EXERCISE 3
         * Using a for loop initialise the contents of a 10 element array of type int to 0. Using another for loop print the contents of the array 
         * to the screen. */
         static void Ex3()
        {
            int[] numArray = new int[10];
            for(int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = 0;
                i++;
            }

            for(int j = 0; j < numArray.Length; j++)
            {
                Console.WriteLine(numArray[0]);
            }
        }

        /*EXERCISE 4
         * Using a while loop initialise the contents of a 10 element string array to "c#". USing another while loop print the contents of the 
         * array to the screen*/
         static void Ex4()
        {
            String[] strArray = new String[10];
            int i = 0;
            while (i < 10)
            {
                strArray[i] = "c#";
                i++;
            }
            int j = 0;
            while (j < strArray.Length)
            {
                Console.WriteLine(strArray[j]);
                j++;
            }
        }

        /* EXERCISE 5
         * Using a while loop create a guessing game program that keeps asking the user to enter a number until the user enters the number 7.
         * You will need to create and initialise an int variable to 0. You can then use this variable as the condition in your while loop(while number is
         * not equal to 7). Then in the while loop ask the user to enter a number and store the number entered in the number variable as the condition of 
         * your loop. */
         static void Ex5()
        {
            int i = 0;
            while(i != 7)
            {
                Console.WriteLine("Guess the number");
                String str=Console.ReadLine();
                i = Convert.ToInt32(str);
                if (i == 7)
                {
                    Console.WriteLine("Correct! The number was 7!");
                }
                else
                {
                    Console.WriteLine("That is not the number. Try again.");
                    Console.WriteLine("");
                }
            }
        }
    }
}
