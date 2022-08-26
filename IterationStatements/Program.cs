using System;
using System.Collections.Generic;
using System.Linq;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
            var numbers = new List<int>();
            
            

            int num = 0;

            do 
            {
                Console.WriteLine($"{num}");
                num++;
                numbers.Add(num);
            } while (num < 100);

            Console.WriteLine("Increase");

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }


            // Create a foreach loop using the collection - numbers
            //In the scope of the foreach loop, print each number in numbers
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
            // AND as long as i is greater than or equal to 0
            // Decrement i by 1

            for (int i = numbers.Count() - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
