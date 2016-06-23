using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_019
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null) return head;

            ListNode fast = head;
            ListNode slow = head;

            for (int i = 0; i < n; i++)
            {
                fast = fast.next;
            }

            if (fast == null)
            {
                head = head.next;
                return head;
            }

            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            slow.next = slow.next.next;

            return head;
            
        }
    }
}
