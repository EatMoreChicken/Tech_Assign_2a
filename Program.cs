/*
    Author: Varghese Emlin Charly
    Date: 09/15/2020
    Comments: This is the code for Tech Assignment 2a. I chose to use a "for" loop to accomplish the end goal.
    The program will ask the user for an input that is between the minimum and maximum set using the local
    variables. Once the user enters an integer that is within the acceptable range, the code will announce
    the value they entered and then procced to printing out the number of loops it takes to count to the 
    integer that they entered.
*/


using System;

namespace Tech_Proj_2a
{
    class Program
    {
        static void Main(string[] args)
        {
            /* These local variables can be set to constrain the minimum and maximum integer input that the user
            is allowed to enter. This allows us to change it on the fly if need be. Due to the instruction stating
            that the input must be "between", the code will not allow the user to pick the minimum value or the
            maximum value.*/
            int MIN_VALUE = 1;
            int MAX_VALUE = 25;

            // This is the initial promote for the user to enter an integer between the min and max local variables that were previously declared
            Console.WriteLine("Please enter a number between "+ MIN_VALUE.ToString() + " and " + MAX_VALUE.ToString() + ":");

            try
            {
                /* Grabbing the user's input from the command line using "ReadLine" and then converting the string input to an int variable called "input". If the user doesn't
                input an integer, it will fail and procced to show the user an error declared below. */
                int input = int.Parse(Console.ReadLine());

                /* The if statement will determine if the value inputted is between the constrains specified in the local variable "MIN_VALUE" and "MAX_VALUE". 
                If it passes, it will continue to the for loop. */
                if ((input>MIN_VALUE) && (input<MAX_VALUE)) {
                    /* The for loop in declaring the local variable "i" to keep track of the number of times the loop has run. I initially give the variable "i" the value of "1", 
                     else it will start counting from "0" (simply to make it more intuitive). Every time the code within the loop runs, the "i++" is used to increment the value of
                    "i" by 1. The loop's constrain "i <= input" also ensures that "i" is less than or equal to the input value to make sure the look doesn't keep counting past that value.*/
                    for (int i = 1; i <= input; i++)
                    {
                        /* This portion of the code will run every time the the value of "i" is incremented and is within the constrains stated above. */
                        Console.WriteLine("You have entered " + input.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                    }
                    // Lets the user know that the code is done counting.
                    Console.WriteLine("Done! Reopen the program to try again. Press any key to continue...");
                    // Waiting for the user to click a key to exit the code.
                    Console.ReadKey(true);
                }
                /* If the value inputted by the user is not within the constraints of the minimum and maximum values, it will print the following strings to the command line.*/
                else
                {
                    
                    /*The string will print out minimum and maximum integer expected. The string also prompts the user to reopen the program to try again.*/
                    Console.WriteLine("Plase enter an integer that is between " + MIN_VALUE.ToString() + " and " + MAX_VALUE.ToString() + ". (Not including the minimum and maximum integers.)");
                    Console.WriteLine("The program will now exit. Please reopen to try again. Press any key to continue...");
                    // Waiting for the user to click a key to exit the code.
                    Console.ReadKey(true);
                }
            }
            /* If any errors occur within the "try" section of the code, specifically if the user inputs a non-integer, this section of the code will display an error and instructions. */
            catch
            {
                /*The string will print out minimum and maximum integer expected. The string also prompts the user to reopen the program to try again.*/
                Console.WriteLine("Plase enter an integer that is between " + MIN_VALUE.ToString() + " and " + MAX_VALUE.ToString() + ". (Not including the minimum and maximum integers.)");
                Console.WriteLine("The program will now exit. Please reopen to try again. Press any key to continue...");
                // Waiting for the user to click a key to exit the code.
                Console.ReadKey(true);
            }
        }
    }
}
