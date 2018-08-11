using System;

/// <summary>
/// Create Linked List data structure class
/// 
/// Test to ensure data structure and methods work
/// </summary>

namespace LinkedListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object of LinkedList class and instantiate
            LinkedList list = new LinkedList();
            list.Add("Test1");
            list.Add("Test2");
            list.Add(1, "45");

            object second = list.Get(1);
            object first = list.IndexOf("Test1");
            object third = list[2];
            Console.WriteLine("Element 2's data = " + second);
            Console.WriteLine("index of second = " + first);
            Console.WriteLine("Element 3's data = " + third);

            // test remove
            list.Remove(2);
            Console.WriteLine("After deleting third index position, there are {0} elements remaining", list.Count);

            // test contains
            Console.WriteLine("T/F: Does list contain 'Test1'? {0}", list.Contains("Test1"));

            // final method test: clear
            list.Clear();
            Console.WriteLine("Is list empty? {0}", list.Empty);
            Console.WriteLine();

            // Create new linked list to test print list method
            LinkedList printList = new LinkedList();
            printList.Add("Adam");
            printList.Add(10);
            printList.Add(true);
            printList.Add("Code");

            // call print list method
            printList.PrintLinkedList();


            // keep console open
            Console.Read();
        }
    }
}
