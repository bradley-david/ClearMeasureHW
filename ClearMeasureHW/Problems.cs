using System;
using System.Collections.Generic;
using FizzBuzzLib;

/** Main class for Clear Measure, Inc software engineering internship application homework
 */


namespace ClearMeasureHW {
    class Problems {

        public static void Main(string[] args) {
            //call library methods
            //should have the same output
            FizzBuzz.BasicFizzBuzz();

            var map = new Dictionary<int, string>();
            map.Add(3, "Fizz");
            map.Add(5, "Buzz");
            FizzBuzz.AdvancedFizzBuzz(map, 1, 100);
        }


        //solution to part 1, also included in library directory
        //if divisible by 3, print Fizz
        //if divisible by 5, print Buzz
        //if divisible by both, print FizzBuzz
      
        public static void BasicFizzBuzz() {
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
        }

        /*Solution to part 3:
         * Manual tests for the AdvancedFizzBuzz method to ensure future stability as features are added should include 
         * comparing its output (with the replacement rules of 3 -> Fizz and 5 -> Buzz) to the output of the BasicFizzBuzz method, as is done
         * in the main function above. The outputs should be the same. 
         * Another possible manual test for this method is calling it with different ranges of integers, including ranges with negative numbers.
         * Some future addition (perhaps taking the square root of a number?) may not work with negative numbers, so this would be a useful test.
         */

    }
}
