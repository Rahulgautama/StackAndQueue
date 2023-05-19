using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureProblem
{
    public class Queue
    {
        LinkedList queue = new LinkedList();

        public void Enqueue(int data)
        {
            queue.AddToLast(data);
        }
        
        public void Displaye()
        {
            queue.Display();
        }
    }
}
