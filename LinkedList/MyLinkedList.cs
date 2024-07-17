using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.LinkedList
{
    internal class LinkedListNode<T> where T : IEquatable<T>
    {
        internal T Data { get; set; }
        internal LinkedListNode<T>? Next { get; set; }
        public LinkedListNode(T Data)
        {
            this.Data = Data;
            Next = null;
        }
    }

    public class MyLinkedList<T> : IMyLinkedList<T> where T : IEquatable<T>
    {
        private LinkedListNode<T>? head;
        private int count;
        public MyLinkedList()
        {
            head = null;
            count = 0;
        }
        public void AddDataToFront(T Data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(Data);
            node.Next = head;
            head = node;
            count++;
        }
        public void AddDataToEnd(T data)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(data);
            LinkedListNode<T>? list = head;
            if (head == null)
            {
                head = node;
            }
            else
            {
                while (list?.Next != null)
                {
                    list = list.Next;
                }
                list.Next = node;
            }
                count++;
        }
        // InsertBefore
        public void AddDataBefore(T newData, T existingData)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(newData);
            if (head == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            else if (head.Data.Equals(existingData))
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                LinkedListNode<T> current = head;
                LinkedListNode<T> previous = current;
                bool isMatched = false;
                while (current != null && !(isMatched = current.Data.Equals(existingData)))
                {
                    previous = current;
                    current = current.Next;
                }
                if (!isMatched)
                {
                    Console.WriteLine("No Existing Data Found");
                    return;
                }
                else
                {
                    newNode.Next = current;
                    previous.Next = newNode;
                }
            }
            count++;
        }
        // InsertAfter
        public void AddDataAfter(T newData, T existingData)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            LinkedListNode<T> newNode = new LinkedListNode<T>(newData);
            LinkedListNode<T> current = head;
            bool isMatched = false;
            while (current != null && !(isMatched = current.Data.Equals(existingData)))
            {
                current = current.Next;
            }
            if (!isMatched)
            {
                Console.WriteLine("No Existing Data Found");
                return;
            }
            else
            {
                newNode.Next = current.Next;
                current.Next = newNode;
            }
            count++;
        }
        // InsertAtKPosition

        public void Display()
        {
            LinkedListNode<T>? list = head;
            while (list != null)
            {
                Console.WriteLine(list.Data);
                count++;
                list = list.Next;
            }
        }

    }
}
