using System;
using System.Collections.Generic;
using FizzBuzzLib;

/** Main class for Clear Measure, Inc software engineering internship application homework
 */


namespace ClearMeasureHW {
    class Problems {

        public static void Main(string[] args) {
            //call library methods
            //have the same output
            FizzBuzz.BasicFizzBuzz();

            var map = new Dictionary<int, string>();
            map.Add(3, "Fizz");
            map.Add(5, "Buzz");
            FizzBuzz.AdvancedFizzBuzz(map, 1, 100);
        }


        //solution to part 1, also included in library directory
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

    }
}
