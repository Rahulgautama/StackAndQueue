using System;
using System.Collections.Generic;

namespace DataStructureProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddFirst(56);
            linkedList.AddFirst(30);
            linkedList.AddFirst(70);

            foreach (var dataList in linkedList)
            {
                Console.WriteLine(dataList);
            }

        }
    }
}
