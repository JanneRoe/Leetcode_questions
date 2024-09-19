using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class SearchInsertPosition
    {
        /*Given a sorted array of distinct integers and a target value, 
         * return the index if the target is found. If not, return the 
         * index where it would be if it were inserted in order.

         * You must write an algorithm with O(log n) runtime complexity.*/

        public int Solution(int[] nums, int target)
        {
            if (nums.Max() < target)
            {
                return nums.Length;
            }

            if (nums.Contains(target))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target) { return i; }
                }
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > target)
                    {
                        return i;
                    }
                }
            }
            

            return 0;
        }
    }
}
