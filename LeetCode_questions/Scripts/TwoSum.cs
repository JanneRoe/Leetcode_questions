using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts
{
    /*Given an array of integers nums and an integer target, 
     * return indices of the two numbers such that they add up to target.
     *You may assume that each input would have exactly one solution, 
     *and you may not use the same element twice.
     *You can return the answer in any order.*/
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            int[] result = new int[2];
            int i, j;
            for (i = 0; i < nums.Length; i++) 
            {
                var n = nums[i];
                for (j = i + 1; j < nums.Length; j++) 
                {
                    var m = nums[j];

                    if((n+m) == target)
                    {
                        result = [ i, j ];
                        return result;                        
                    }
                    else
                    {

                    }
                }
            }
            result = [0,0];
            return result;
        }
    }
}
