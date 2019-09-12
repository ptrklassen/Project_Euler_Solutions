using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_prob_3_Prime_Factor
{
    class Program
    {

        

        public static void Main(string[] args)
        {
            Int64 i = 775146; //sq rt(ish) of 600851475143
            Int64 n = 600851475143;
            List<Int64> factors = new List<Int64>();
            List<Int64> primes = new List<Int64>();

            while (i > 0)
            {

                if (600851475143 % i == 0)
                {
                    //Console.WriteLine(i);
                    factors.Add(i); 
                    Int64 j = n / i;
                    factors.Add(j);
                    Console.WriteLine(factors.Count-1);
                }
                i--;
            }
            foreach (Int64 number in factors)
            {
                Factor(number);
                if (Factor(number) != 0) { primes.Add(Factor(number)); }

            }
            
            primes.Sort();
            primes.ForEach(Console.WriteLine);            
            Console.WriteLine("Done");
            Console.ReadLine();
        }
        public static Int64 Factor(Int64 number)
        {
            Int64 num = number;
            Int64 root = Convert.ToInt64(Math.Sqrt(Convert.ToDouble(number)));
            int count = 0;
            while (root > 0)
            {
                if (num % root == 0)
                {
                    count++;
                }
                root--;
            }
            if (count == 1)
            {
                return num;
            }
            else { return 0; }
        }
    }
}
