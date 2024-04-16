namespace BinarySearch;

public class BookAllocation
{
    // There are ‘m’ number of students, and the task is to allocate all the books to the students
    // Allocate books in such a way that:

    // 1. Each student gets at least one book.
    // 2. Each book should be allocated to only one student.
    // 3. Book allocation should be in a contiguous manner.

    // You have to allocate the book to ‘m’ students such that the maximum number of pages assigned to a student is minimum.
    // If the allocation of books is not possible, return -1.

    // Example:
    // Input: ‘n’ = 4 ‘m’ = 2 
    // ‘arr’ = [12, 34, 67, 90]

    // Output: 113

    // Explanation: All possible ways to allocate the ‘4’ books to '2' students are:
    // 12 | 34, 67, 90 - the sum of all the pages of books allocated to student 1 is ‘12’, and student two is ‘34+ 67+ 90 = 191’, so the maximum is ‘max(12, 191)= 191’.
    // 12, 34 | 67, 90 - the sum of all the pages of books allocated to student 1 is ‘12+ 34 = 46’, and student two is ‘67+ 90 = 157’, so the maximum is ‘max(46, 157)= 157’.
    // 12, 34, 67 | 90 - the sum of all the pages of books allocated to student 1 is ‘12+ 34 +67 = 113’, and student two is ‘90’, so the maximum is ‘max(113, 90)= 113’.

    public static void Solution(int[] nums, int m)
    {
        System.Console.WriteLine(FindPages(nums,m));
    }

    public static int FindPages(int[] arr,int m) {
        // Write your code here.
        if (arr.Length < m) return -1;
        int min = 0;
        int max = 0;

        for(int i = 0; i < arr.Length; i++)
        {
            min = min > arr[i] ? min : arr[i];
            max += arr[i];
        }

        while (min <= max)
        {
            int mid = min + (max - min) / 2;
            int studentCount = GetStudentCount(arr, mid);
            if (studentCount <= m)
            {
                max = mid - 1;
            }
            else min = mid  +1;
        }
        return min;
    }

    public static int GetStudentCount(int[] arr, int pages)
    {
        int student = 1;
        int totalPage = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (totalPage + arr[i] > pages)
            {
                student++;
                totalPage = arr[i];
            }
            else totalPage += arr[i];
        }
        return student;
    }

}
