using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatternMatching;

namespace PatternMatching
{
    public class PatternMatching
    {
        static void Main()
        {
           IfElsePatternMatching();
        }

        static void IfElsePatternMatching()
        {
            Console.WriteLine("===If Else Pattern Matching ===/n");
            object testItem1 = 123;
            object testItem2 = "Hello";

            if (testItem1 is string myStringValue1)
            {
                Console.WriteLine("{0} is a string", myStringValue1);

            }
            else if (testItem1 is int myValue1)
            {
                Console.WriteLine($"{myValue1} is an int");
            }

            if (testItem2 is string myStringValue2)
            {
                Console.WriteLine($"{myStringValue2} is a string");
            }
            else if (testItem2 is int myValue2)
            {
                Console.WriteLine($"{myValue2} is a string");
            }


        }



    }
}
