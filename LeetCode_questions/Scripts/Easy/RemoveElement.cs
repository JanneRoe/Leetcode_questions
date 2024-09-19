using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class RemoveElement
    {
        public int Solution(int[] nums, int val) 
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++) 
            {
                if(nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;                      
                }                
            }

            return k;
        }
    }
}
