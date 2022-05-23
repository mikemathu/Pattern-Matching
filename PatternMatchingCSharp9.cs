using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingCSharp9
{
    public class CSharp9
    {
        public static void IfElsePatternMatchingUpdateInCShharp9()
        {
            Console.WriteLine("================ C# 9 If Else Pattern Matching Improvements ===============/n");
            object testItem1 = 123;
            Type t = typeof(string);
            char c = 'f';

            //Type patterns. Checks if a variable is a type
            if (t is Type)
            {
                Console.WriteLine($"{t} is a Type");
            }

            //Relational, Conjuctive and Disjunctive patterns. Conjuctive (and) patterns Requires both patterns to match.Disjunctive (or) patterns Requires either pattern to match.Relational patterns Requires input to be less than, less than or equal, greater than, or greater than or equal
            if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
            {
                //Console.WriteLine($"{c} is a character");
            }

            //Parenthesized patterns
            if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',' )
            {
                //Console.WriteLine($"{c} iz a character or separator");
            }

           



        }
    }
}
