using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Leetcode 88. Merge Sorted Array
            // int[] nums1 = { 1, 2, 3, 0, 0, 0};
            // int[] nums2 = { 2, 5, 6 };

            // MergeAndSort2(nums1, nums2);
            #endregion

            #region Leetcode 27. Remove Element

            // int[] testArray = { 0, 1, 2, 2, 3, 0, 4, 2 };
            // int val = 2;

            // var test = RemoveElement(testArray, val);

            #endregion
        }


        #region Leetcode 26. Remove Duplicates from Sorted Array

        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length - 1 - count; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    SlideToIndex(ref nums, i + 1, nums.Length - count - 1);
                    count++;
                }
            }

            return nums.Length - count;
        }

        #endregion


        #region Leetcode 27. Remove Element
        public static int RemoveElement(int[] nums, int val)
        {
            int count = 0;

            for (int i = 0; i < nums.Length - count; i++)
            {
                if (nums[i] == val && i < nums.Length - count)
                {
                    SwapToIndex(ref nums, i, nums.Length - count - 1);
                    i--;
                    count++;
                }
            }

            return nums.Length - count;
        }
        #endregion


        #region Leetcode 88. Merge Sorted Array

        public static void MergeAndSort(int[] nums1, int[] nums2)
        {

            int n = nums2.Length;
            int m = nums1.Length - n;

            if (n != 0)
            {
                int k = 0;

                for (int i = 0; i < m + n; i++)
                {
                    if (nums1[i] > nums2[k] || i >= m + k)
                    {
                        for (int j = m + n - 1; j > i; j--)
                        {
                            nums1[j] = nums1[j - 1];
                        }
                        nums1[i] = nums2[k];
                        k++;
                    }
                    if (k == n) break;
                }
            }
        }

        public static void MergeAndSort2(int[] nums1, int[] nums2)
        {

            int n = nums2.Length;
            int m = nums1.Length - n;

            int k = 0;

            for (int i = m; i < m + n; i++)
            {
                nums1[i] = nums2[k];
                k++;
            }

            Array.Sort(nums1);

            foreach (var num in nums1)
            {
                Console.WriteLine(num);
            }
        }
        #endregion


        #region Utillity Methods

        public static void SlideToIndex(ref int[] nums, int indexStart, int indexFinish)
        {
            if(indexStart < indexFinish)
            {
                int temp = nums[indexStart];

                for (int i = indexStart; i < indexFinish - 1; i++)
                {
                    nums[i] = nums[i + 1];
                }

                nums[indexFinish - 1] = temp;
            }
        }

        public static void SwapToIndex(ref int[] nums, int index1, int index2)
        {
            int temp = nums[index1];
            nums[index1] = nums[index2];
            nums[index2] = temp;
        }

        public static void PrintArray(ref int[] nums)
        {
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        #endregion

    }
}