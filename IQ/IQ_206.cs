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
            return null;
        }
    }
}
