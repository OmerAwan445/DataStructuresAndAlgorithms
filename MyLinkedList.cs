using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    internal class LinkedListNode<T> where T : IEquatable<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T>? Next { get; set; }
        public LinkedListNode(T Data)
        {
            this.Data = Data;
            this.Next = null;
        }
    }

    public class MyLinkedList<T> where T : IEquatable<T>
    {
        LinkedListNode<T>? head;
        int count;
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
        }
        // InsertBefore
        public void AddDataBefore(T newData, T existingData)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(newData);
            if (head == null)
            {
                Console.WriteLine("List is Empty");
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
                }
                else
                {
                    newNode.Next = current;
                    previous.Next = newNode;
                }
            }

        }

        // InsertAfter
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
