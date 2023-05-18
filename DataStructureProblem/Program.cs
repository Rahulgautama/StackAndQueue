using System;
using System.Collections.Generic;

namespace DataStructureProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
           // linkedList.Add(30);
            //linkedList.Add(70);

            linkedList.Append(linkedList,56);
            //linkedList.Append(linkedList,30);
            linkedList.Append(linkedList,70);

            linkedList.AddAfter(30,56);
            linkedList.Display();

        }
    }
}
