using PlayAround.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int aCount = ListCount(headA);
            int bCount = ListCount(headB);

            ListNode smaller, bigger;

            if (aCount >= bCount)
            {
                bigger = headA;
                smaller = headB;
            }
            else
            {
                bigger = headB;
                smaller = headA;
            }

            int diff = Math.Abs(aCount - bCount);

            while (diff > 0)
            {
                bigger = bigger.next;
                diff--;
            }

            ListNode ret = null;
            while (bigger != null & smaller != null)
            {
                if (bigger == smaller)
                {
                    ret = bigger;
                    break;
                }

                bigger = bigger.next;
                smaller = smaller.next;
            }

            return ret;
        }

        private int ListCount(ListNode head)
        {
            if (head == null) return 0;

            ListNode current = head;
            int count = 0;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }
    }
}
