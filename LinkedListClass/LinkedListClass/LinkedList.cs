using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListClass
{
    public class LinkedList
    {
        /// <summary>
        /// private fields:
        ///     Object data = contan the data of the node, what we want to store in the list
        ///     Node next   = reference to next node in the list
        ///
        /// Constructor:
        ///     Node(object data, Node next)
        ///     
        /// Public properties:
        ///     Data - get and set data field
        ///     Next - get and set the next field
        /// </summary>
        public class Node
        {
            private object data;
            private Node next;

            public Node(object data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            public object Data
            {
                get => data;
                set => data = value;
            }

            public Node Next
            {
                get => next;
                set => next = value;
            }
        }

        /// <summary>
        /// Private fields: 
        ///     Node head - Is a reference to the FIRST node in the list. (Linear list ->)
        ///     int size  - Current size of the list
        ///     
        /// Constructor: 
        ///     LinkedList() - initialized the private fields
        ///     
        /// Public Properties:
        ///     Empty   - T/F if list is empty
        ///     Count   - Returning the size private field, how many items are in the list
        ///     Indexer - Access data like an array
        private Node head;
        private int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public bool Empty
        {
            get => count == 0;
        }

        public int Count
        {
            get => count;
        }

        /// <summary>
        /// Pass in int and object
        /// Make sure the index is 0 or larger
        /// If the index exceeds the count, set the index to the count
        /// Get the first node in the list
        /// Check if index is 0 or list is empty, put at beginning of list
        /// Else, Loop up to one before where we want to insert
        /// index starts at current node, and loops to - 1 of that
        /// Then sets the value to be the next one after that
        /// Incremement count by one
        /// Return the object :)
        /// </summary>
        /// <param name="i"></param>
        /// <param name="o"></param>
        /// <returns></returns>
        public object Add(int ind, object obj)
        {
            if (ind < 0)
            {
                throw new ArgumentOutOfRangeException("Index " + ind);
            }

            if (ind > count)
            {
                ind = count;
            }

            Node current = head;

            if (Empty || ind == 0)
            {
                head = new Node(obj, head);
            }
            else
            {
                for (int i = 0; i < ind - 1; i++)
                {
                    current = current.Next;
                }

                current.Next = new Node(obj, current.Next);
            }
            count++;

            return obj;
        }

        /// <summary>
        /// Append addition to end
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public object Add(object obj)
        {
            return Add(count, obj);
        }

        /// <summary>
        /// Takes index of item to remove
        /// Throw error if index is negative
        /// Return null if list is empty
        /// Handle if index is greater than count
        /// Get first node in the list
        /// If removing first node, set result = current data and head to the next node
        /// Else, Loop up to one before where we want to insert
        /// index starts at current node, and loops to - 1 of that
        /// Remove reference to node (This is same as deleting)
        /// Decrement size
        /// Return the new result
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public object Remove(int index)
        {
            if (index < -1)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (Empty)
            {
                return null;
            }

            if (index > count)
            {
                index = count - 1;
            }

            Node current = head;
            object result = null;

            if (index == 0)
            {
                result = current.Data;
                head = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                result = current.Next.Data;
                current.Next = current.Next.Next;
            }
            count--;
            return result;
        }

        /// <summary>
        /// Set head reference to null
        /// Set count to 0
        /// </summary>
        /// <returns></returns>
        public void Clear()
        {
            head = null;
            count = 0;
        }

        /// <summary>
        /// Get index of object if it exists, otherwise return -1
        /// Start at head
        /// Loop through whole list
        /// Check if head data equals the object, if so, return the index
        /// If not, increase current head by one until reached
        /// If never reached, it means it is not in the list; return -1
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public int IndexOf(object obj)
        {
            Node current = head;

            for (int i = 0; i < count; i++)
            {
                if (current.Data.Equals(obj))
                {
                    return i;
                }
                current = current.Next;
            }
            return -1;
        }

        /// <summary>
        /// Returns true if in list, else false
        /// If index of equals -1, it means that it does not exist in list
        /// If not, it exists
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Contains(object obj)
        {
            if (IndexOf(obj) == -1)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Get object at specified index position
        /// Check if empty, -1 or larger than counter
        /// Set to head
        /// Loop to index
        /// Set node = next until reaching specified index
        /// Return the data
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public object Get(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("Index: " + index);
            }

            if (Empty)
            {
                return null;
            }

            if (index >= count)
            {
                index = count - 1;
            }

            Node current = head;

            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        /// <summary>
        /// Another way to get data
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get
            {
                return Get(index);
            }
        }

        /// <summary>
        /// Print entire linked list
        /// Create current node at head
        /// While current doesn't equal nothing, print current's data and set current = next node
        /// </summary>
        public void PrintLinkedList()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }

        /// <summary>
        /// Checks if linked list is a cycle
        /// Create two seperate nodes
        /// </summary>
        /// <returns></returns>
        public bool HasCycle()
        {
            Node current = head;
            Node fast = head;

            while (current != null && fast != null && fast.Next != null)
            {
                current = current.Next;
                fast = fast.Next.Next;

                if (current == fast)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
