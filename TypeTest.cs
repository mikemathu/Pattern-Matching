using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingTypeTest
{
    public class TypeTest
    {
        public static decimal Test()
        {
            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            decimal total = 0;

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    //Console.WriteLine("{0} is a decimal",d);
                    total += d;
                }
            }
            //Console.WriteLine(total);

            return total;
        }
    }
}
