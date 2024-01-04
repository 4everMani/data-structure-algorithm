using System;

namespace Array
{

    public class FindInMountainArray
    {



        //Example 1:
        //Input: array = [1,2,3,4,5,3,1], target = 3
        //Output: 2
        //Explanation: 3 exists in the array, at index=2 and index = 5.Return the minimum index, which is 2.
        
        //Example 2:
        //Input: array = [0,1,2,4,2,1], target = 3
        //Output: -1
        //Explanation: 3 does not exist in the array, so we return -1.


        public static void Solution(int target, MountainArray mountainArray)
        {
            Console.WriteLine(FindInMountainArr(target, mountainArray));
        }
        public static int FindInMountainArr(int target, MountainArray m)
        {
            var totalLength = m.Length();
            var result = FindTopIndex(m);
            var resultIndex = BinarySearch(0, result.index, target, m, true);
            if (resultIndex == -1)
            {
                return BinarySearch(result.index + 1, totalLength - 1, target, m, false);
            }
            return resultIndex;
        }

        public static (int index, int value) FindTopIndex(MountainArray mountainArr)
        {
            int start = 0;
            int totalLength = mountainArr.Length();
            int end = totalLength - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (mid - 1 >= 0 && mid + 1 <= totalLength - 1)
                {
                    int current = mountainArr.Get(mid);
                    int prev = mountainArr.Get(mid - 1);
                    int next = mountainArr.Get(mid + 1);
                    if (current > prev && current > next)
                    {
                        return (mid, current);
                    }
                    else if (current < prev && current > next)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }

                }
                else if (mid - 1 < 0) start = mid + 1;
                else end = mid - 1;
            }
            return (-1, -1);
        }

        private static int BinarySearch(int start, int end, int target, MountainArray mountainArr, bool isLeft)
        {
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int midValue = mountainArr.Get(mid);
                if (midValue == target)
                {
                    return mid;
                }
                else if (midValue > target)
                {
                    if (isLeft) end = mid - 1;
                    else start = mid + 1;
                }
                else
                {
                    if (isLeft) start = mid + 1;
                    else end = mid - 1;
                }
            }
            return -1;
        }
    }

    public class MountainArray
    {
        private int[] _arr;

        public MountainArray(int[] inputArr)
        {
            _arr = inputArr;
        }
        public int Get(int index) 
        { 
            return _arr[index];
        }
        public int Length() 
        { 
            return _arr.Length;
        }
    }
}
