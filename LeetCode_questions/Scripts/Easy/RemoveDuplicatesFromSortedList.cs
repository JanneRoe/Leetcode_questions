using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_questions.Scripts.Easy
{
    public class RemoveDuplicatesFromSortedList
    {
        public ListNode Solution(ListNode head)
        {
            if(head == null) return null;   
            ListNode current = head;
            while (current != null && current.next != null)
            {                                
                if (current.val == current.next.val) 
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }                
            }

            return head;
        }
    }
}
