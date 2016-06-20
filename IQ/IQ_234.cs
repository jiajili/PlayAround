using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_234
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null || head.next == null) return true;

            ListNode faster = head;
            ListNode slower = head;

            while (faster.next != null && faster.next.next != null)
            {
                faster = faster.next.next;
                slower = slower.next;
            }

            ListNode middle = slower.next;
            slower.next = null;

            ListNode prev = null;
            ListNode current = middle;
            ListNode next = null;

            while (current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }

            ListNode left = head;
            ListNode right = prev;

            while (left != null && right != null)
            {
                if (left.val != right.val)
                {
                    return false;
                }
                left = left.next;
                right = right.next;
            }

            return true;
        }
    }
}
