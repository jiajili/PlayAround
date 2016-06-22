using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_083
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode prev = head;
            ListNode current = head.next;

            while (current != null)
            {
                if (prev.val == current.val)
                {
                    prev.next = current.next;
                    current = current.next;
                }
                else
                {
                    prev = current;
                    current = current.next;
                }
            }

            return head;
        }
    }
}
