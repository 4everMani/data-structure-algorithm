using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class FindDuplicate
    {
        public static void Solution(int[] nums)
        {
            //Console.WriteLine(BruteForce(nums));
            Console.WriteLine(Improved(nums));
            
        }

        private static int BruteForce(int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;

                while (j < nums.Length)
                {
                    if (nums[i] == nums[j])
                    {
                        return nums[i];
                    }
                    j++;
                }
            }
            return 0;
        }

        private static int Improved(int[] nums) 
        {
            for (int i =0; i < nums.Length; ++i) 
            {
                int indexToVisit = Math.Abs(nums[i]);

                if (nums[indexToVisit] < 0)
                {
                    return indexToVisit;
                }

                else
                {
                    nums[indexToVisit] = -nums[indexToVisit];
                }
            }
            return -1;
        }
    }
}
