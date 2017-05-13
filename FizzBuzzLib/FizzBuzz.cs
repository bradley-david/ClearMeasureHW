using System;
using System.Collections.Generic;
using System.Text;
//library class for FizzBuzz problem part 2

namespace FizzBuzzLib {
    public class FizzBuzz {
        //solution to part 1, now in library
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

        /*Solution to part 4
         * Takes in an int-string map that represents the replacement rules.
         * For every integer i in the inclusive range [min,max], we iterate over
         * the map and test if i is evenly divisible by the keys in the map.
         * Print the values these keys are associated with.
         * The order of printing depends on the order of the foreach iteration and by extension 
         * the order of the map's backing hash table, so it is not guaranteed.
         * If i is not divisible by any key, print i
         * 
         * For example, to use this for the original FizzBuzz problem, we would
         * have a Dictionary d mapping 3 to "Fizz" and 5 to "Buzz" 
         * and call AdvancedFizzBuzz(d, 1, 100)
         * 
         */

        public static void AdvancedFizzBuzz(Dictionary<int, string> map, int min, int max) {
            for (int i = min; i <= max; i++) {   //all numbers in range

                StringBuilder sb = new StringBuilder();    //will be the concatenated string of values whose keys i is evenly divisible by

                foreach (KeyValuePair<int, string> kvp in map) {
                    if (i % kvp.Key == 0) {
                        sb.Append(kvp.Value);
                    }
                }

                if (sb.Length != 0) {
                    Console.WriteLine(sb.ToString());
                } else {
                    Console.WriteLine(i);
                }

            }


        }
    }
}
