﻿using System;
using System.Collections.Generic;

namespace Array;

public class SuperiorElements
{
    // There is an integer array ‘a’ of size ‘n’.
    // An element is called a Superior Element if it is greater than all the elements present to its right.
    // You must return an array all Superior Elements in the array ‘a’.

    // Note:
    // The last element of the array is always a Superior Element. 

    // Example
    // Input: a = [1, 2, 3, 2], n = 4
    // Output: 2 3
    // Explanation: 
    // a[ 2 ] = 3 is greater than a[ 3 ]. Hence it is a Superior Element. 
    // a[ 3 ] = 2 is the last element. Hence it is a Superior Element.
    // The final answer is in sorted order.

    public static void Solution(int[] nums)
    {
        List<int> result = OptimalSolution(nums);

        foreach (var number in result)
        {
            Console.Write(number+ ", ");
        }
    }

    private static List<int> OptimalSolution(int[] nums)
    {
        var outputList = new List<int>();
        var maxNum = nums[nums.Length - 1];
        outputList.Add(maxNum);
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] > maxNum)
            {
                outputList.Add(nums[i]);
                maxNum = nums[i];
            }
            
        }
        return outputList;
    }
}
