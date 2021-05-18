using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeFindNumberswithevennumbers
{
    class Program
    {
       static int FindNumbers(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {               
                if (nums[i].ToString().Length % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; int n = Convert.ToInt32(Console.ReadLine());int[] a = new int[n];
         
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            foreach (var item in a)
            {
                Console.Write(item +" ");
            }
            Console.Write("\n"); Console.WriteLine(FindNumbers(a));
         
            
            Console.ReadLine();
        }
    }
}
