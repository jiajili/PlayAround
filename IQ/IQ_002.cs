using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// You are given two linked lists representing two non-negative numbers. The digits are stored in reverse order 
    /// and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.
    /// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    /// Output: 7 -> 0 -> 8
    /// </summary>
    public class IQ_002
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l2;

            var preNode = new ListNode(-1);
            var current = preNode;

            var tempNode1 = l1;
            var tempNode2 = l2;

            var carry = false;
            while (tempNode1 != null || tempNode2 != null || carry)
            {
                int value = 0;
                if (tempNode1 != null)
                {
                    value += tempNode1.val;
                    tempNode1 = tempNode1.next;
                }

                if (tempNode2 != null)
                {
                    value += tempNode2.val;
                    tempNode2 = tempNode2.next;
                }

                if (carry)
                {
                    value += 1;
                }

                carry = value >= 10;
                value = value % 10;

                current.next = new ListNode(value);
                current = current.next;
            }

            return preNode.next;
        }
    }
}