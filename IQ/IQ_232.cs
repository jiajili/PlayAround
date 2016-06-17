using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayAround.IQ
{
    class IQ_232
    {
        private Stack<int> forAdd = new Stack<int>();
        private Stack<int> forGet = new Stack<int>();

        // Push element x to the back of queue.
        public void Push(int x)
        {
            while (forGet.Count > 0)
            {
                forAdd.Push(forGet.Pop());
            }

            forAdd.Push(x);
        }

        // Removes the element from front of queue.
        public void Pop()
        {
            while (forAdd.Count > 0)
            {
                forGet.Push(forAdd.Pop());
            }

            forGet.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            while (forAdd.Count > 0)
            {
                forGet.Push(forAdd.Pop());
            }


            return forGet.Peek();

        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return forAdd.Count == 0 && forGet.Count == 0;
        }
    }
}
