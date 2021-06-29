using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSequence
{
    class Fibonacci
    {
        private int firstNumber = 0;
        private int SecondNumber = 1;
        private int nextNumber;
        private int numberOfElements;

        public Fibonacci() // constructor
        {
            FibonacciSequence();
        }

        public void FibonacciSequence()
        {
            Console.Write("Enter the number of elements to Print: **Number must be greater than 2**: ");
            numberOfElements = int.Parse(Console.ReadLine());

            if (numberOfElements < 2)
            {
                Console.WriteLine("Please enter a number greater than two");
            }
            else
            {
                //First print first and second number
                Console.Write(firstNumber + " " + SecondNumber + " ");

                //Starts the loop from 2 because 0 and 1 are already printed
                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + SecondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = SecondNumber;
                    SecondNumber = nextNumber;
                }
            }
        }
    }
}
