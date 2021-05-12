using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningSumof1dArray
{
    class Program
    {
        static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int m = nums[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    m += nums[j];
                }
                result[i] = m;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
           
            foreach (var item in RunningSum(nums))
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}
