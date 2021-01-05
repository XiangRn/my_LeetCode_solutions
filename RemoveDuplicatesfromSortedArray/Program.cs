using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesfromSortedArray
{
    class Program
    {
        static int RemoveDuplicates(int[] nums)
        {
            Array.Sort(nums); List<int> ls = new List<int>();
            if (nums.Length ==1|| nums.Length==0)
            {
                  return nums.Length;
            }
            else
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i - 1] != nums[i])
                    {
                        ls.Add(nums[i - 1]);
                    }
                    if (i == nums.Length - 1)
                    {
                        ls.Add(nums[i]);
                    }
                }
                int[] new_nums = ls.ToArray();
                for (int i = 0; i < new_nums.Length; i++)
                {
                    nums[i] = new_nums[i];
                }
                return ls.ToArray().Length;
            }                      
            
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums1 = new int[n];
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int len = RemoveDuplicates(nums1);
            Console.Write("\n");
            // any modification to nums in your function would be known by the caller.
            // using the length returned by your function, it prints the first len elements.
            for (int i = 0; i < len; i++)
            {
                Console.Write(nums1[i]+"\n");
            }

           
            Console.ReadLine();
        }
    }
}
