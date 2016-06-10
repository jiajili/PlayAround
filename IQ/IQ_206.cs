using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/
    /// 206. Reverse Linked List
    /// 
    /// Reverse a singly linked list.
    /// </summary>
    public class IQ_206
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode prev = null,next = null;
            ListNode current = head;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            return prev;
        }

        public ListNode ReverseListRecusive(ListNode head)
        {
            return ReverseRecusive(head, null);
        }

        private ListNode ReverseRecusive(ListNode current, ListNode prev)
        {
            if (current == null) return null;
            ListNode next = current.next;
            current.next = prev;

            return next == null? current : ReverseRecusive(next, current);
        }
    }
}
