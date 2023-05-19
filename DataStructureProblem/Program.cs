using System;
using System.Collections.Generic;

namespace DataStructureProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //linkedList.Add(56);
            // linkedList.Add(30);
            //linkedList.Add(70);

            //linkedList.Append(linkedList,56);
            //linkedList.Append(linkedList,30);
            //linkedList.Append(linkedList,70);

            //linkedList.AddAfter(30,56);

            //linkedList.AddAfter(40, 30);

            //linkedList.Delete(40);
            //Node new_node;

            //new_node = linkedList.NewNode(12);
            //linkedList.SortedInsert(new_node);
            //new_node = linkedList.NewNode(25);
            //linkedList.SortedInsert(new_node);
            //new_node = linkedList.NewNode(13);
            //linkedList.SortedInsert(new_node);
            //linkedList.DeleteFirst();
            //linkedList.DeleteLast();
            //Console.WriteLine(linkedList.Search(56));
            stack.Push(23);
            stack.Push(31);
            stack.Push(33);
            stack.Pop();
            stack.Display();

        }
       
    }
}
