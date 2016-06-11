using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list-ii/
    /// 
    /// Reverse Linked List II
    /// Reverse a linked list from position m to n. Do it in-place and in one-pass.
    //For example:
    //Given 1->2->3->4->5->NULL, m = 2 and n = 4,
    //return 1->4->3->2->5->NULL.
    //Note:
    //Given m, n satisfy the following condition:
    //1 ≤ m ≤ n ≤ length of list.
    /// </summary>
    public class IQ_092
    {
        public ListNode ReverseBetween(ListNode head, int m, int n)
        {
            if (m == n) return head;

            ListNode prev = null;
            ListNode first = new ListNode(0);
            ListNode second = new ListNode(0);

            int i = 0;
            ListNode p = head;
            while (p != null)
            {
                i++;
                if (i == (m - 1))
                {
                   prev = p;
                }

                if (i == m)
                {
                    first.next = p;
                }

                if (i == n)
                {
                    second.next = p.next;
                    // good trick, make p2 is null and stop while in the below code
                    p.next = null;
                }

                p = p.next;
            }

            if (first.next == null) return head;

            ListNode p1 = first.next;
            ListNode p2 = p1.next;
            p1.next = second.next;

            while (p1 != null && p2 != null)
            {
                ListNode t = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = t;
            }

            if (prev != null)
            {
                prev.next = p1;
            }
            else
            {
                return p1;
            }

            return head;
        }
    }
}
