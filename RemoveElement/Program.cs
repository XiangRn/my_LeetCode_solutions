using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    class Program
    {
        static int RemoveElement(int[] nums, int val)
        {
            List<int> ls = nums.ToList();int i = 0;
            while(ls.Count>0 && i < ls.Count)
            {
                if(ls[i] == val)
                {
                    ls.Remove(ls[i]);
                    continue;
                }
                i++;
            }
            int[] new_nums = ls.ToArray();
            for (int j = 0; j < new_nums.Length; j++)
            {
                nums[j] = new_nums[j];
            }
            return ls.ToArray().Length;
        }        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] nums = new int[] { 3, 2, 2, 3 };
            int val = Convert.ToInt32(Console.ReadLine());
            int len = RemoveElement(nums, val);
            Console.Write("\n");
            // any modification to nums in your function would be known by the caller.
            // using the length returned by your function, it prints the first len elements.
            for (int i = 0; i < len; i++)
            {
                Console.Write(nums[i] + "\n");
            }

            Console.ReadLine();
        }
    }
}
