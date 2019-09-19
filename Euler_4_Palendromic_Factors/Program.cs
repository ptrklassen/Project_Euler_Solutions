using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4_Palendromic_Factors
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int number;
            int n1 = 999;
            int n2 = 999;
            int c = 99;
            int d = 99;
            while (c > 0)
            {
                number = n1 * n2;                
                if (Drommy(number) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine(n1 + " + " + n2 + " = " + number);
                    d--;
                    n2--;
                    if (d == 0)
                    {
                        n2 = 999;
                        n1--;
                        d = 99;
                        c--;
                    }
                }
            }
            Console.WriteLine("The equation is: " + n1 + " + " + n2);
            Console.WriteLine("Done");
            Console.Read();

        }
        public static bool Drommy(int number)
        {
            string pnum = Convert.ToString(number);
            int lnum = pnum.Length;
            int i = lnum;
            int k = lnum / 2;
            int l = (lnum - 1) / 2;
            int j = 0;

            if (lnum % 2 == 0)
            {
                while (i > k)
                {
                    if (pnum[i-1] == pnum[j])
                    { 
                        j++;
                        i--;
                    }
                    else
                    {
                        return false;
                    }
                }
                Console.WriteLine(pnum);
                return true;
            }
            else
            {
                while(i > l)
                {
                    if (pnum[i-1] == pnum[j])
                    {
                        j++;
                        i--;
                    }
                    else
                    {
                        return false;
                    }
                }
                Console.WriteLine(pnum);
                return true;
            }


           
        }
    }

}
