using System;
using System.Collections.Generic;

namespace Task1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var input1 = new[] { 1, 2, 3, 4, 5 };
            var input2 = new[] { 15, 25, 35 };
            var input3 = new[] { 8, 8 };

            Console.WriteLine($"{input1.GetTotal()}\n{input2.GetTotal()}\n{input3.GetTotal()}");
        }

        public static int GetTotal(this IEnumerable<int> source)
        {
            var total = 0;
            foreach (var item in source)
            {
                if (item % 2 == 0)
                    total += 1;
            
                if (item % 2 != 0)
                    total += 3;
            
                if (item == 8)
                    total += 5;
            }
            return total;
        }
    }
}
