using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program6
    {
        static void Main(string[] args)
        {
            /*string wish = "One #Day I'll make #onions #cry";

            String[]words = wish.Split(' ');

            var result = words.Where(w => w.StartsWith("#"));

            foreach(var word in result)
            {
                Console.WriteLine(word);
            }*/

            var nums = new List<int> { 6,1,43,2,145,-45,123,-4};

            int length = nums.Count();
            Console.WriteLine("Total elements : "+ length);

            //count even;

            int length2 = nums.Count(x=>x%2 == 0);
            Console.WriteLine("even number length " + length2);

            int total = nums.Sum();
            Console.WriteLine("Total value " + total);

            int evenSum = nums.Sum(x => x % 2 == 0 ? x : 0);
            Console.WriteLine("Evene sum " + evenSum);

            double mean = nums.Average();
            Console.WriteLine("Mean " + mean);

            Console.WriteLine($"Largest value {nums.Max()}");
            Console.WriteLine($"Smallest value {nums.Min()}");

            var result = from n in nums orderby n ascending select n;

            foreach( int n in result ) Console.Write(n+" ");

        }
    }
}
