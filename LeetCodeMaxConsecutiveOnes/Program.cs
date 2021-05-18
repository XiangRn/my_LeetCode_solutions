using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMaxConsecutiveOnes
{
    class Program
    {
      static int FindMaxConsecutiveOnes(int[] nums)
        {           
            int count= 0; int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                    if (i == nums.Length - 1)
                    {
                        m = Math.Max(count, m);
                    }
                }
                else
                {
                    if (count != 0)
                    {
                        m = Math.Max(count, m);
                    }
                    count = 0;
                }
            }           
            return m;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
           int[] a = new int[] { 1, 1, 0, 1, 1, 1 };
            
            Console.WriteLine(FindMaxConsecutiveOnes(a));
            Console.ReadLine();
        }
    }
}
