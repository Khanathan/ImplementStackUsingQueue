using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementStackUsingQueue
{
    public class MyStack
    {
        //Constructor: Empty stack starts with Count = 0;
        public MyStack()
        {
            count = 0;
        }

        private Queue<int> q1 = new Queue<int>();
        private Queue<int> q2 = new Queue<int>();


        public void Push(int input)
        {
            //Enqueue pushes item to q2.
            q2.Enqueue(input);

            //Transfer all q1 items to q2, newly pushed items stay at the beginning of the queue/Stack.
            //q1 will be empty at the end of the while loop.
            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Dequeue());
            }

            //Swap names of q1 and q2, making q1 the Queue containing the Stack items.
            Queue<int> qTemp = q1;
            q1 = q2;
            q2 = qTemp;
            count++;
        }

        public int Pop()
        {
            count--;
            return q1.Dequeue();            
        }

        private int count;

        public int Count
        {
            get { return count; }
        }
    }
}
