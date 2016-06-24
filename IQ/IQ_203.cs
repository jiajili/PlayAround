using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (null == head) return head;

            ListNode previous = new ListNode(-1);
            previous.next = head;

            ListNode current = previous;
            ListNode next = current.next;

            while (next != null)
            {
                if (next.val != val)
                {
                    current.next = next;
                    current = next;
                }
                    next = next.next;                
            }

            current.next = null;

            return previous.next;
        }
    }
}
