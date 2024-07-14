using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class LinkedListNode
    {
        public String? Data { get; set; }
        public LinkedListNode? Next { get; set; }
        public LinkedListNode(String Data) {
            this.Data = Data;
            this.Next = null;
        }
    }
    public class LinkedList
    {
        LinkedListNode? head;
        int count;
        public LinkedList() {
            head = null;
            count = 0;
        }
        public void AddDataToFront(String Data)
        {
         LinkedListNode node= new LinkedListNode(Data);
            node.Next = head;
            head = node;
        }
        public void Display()
        {
            LinkedListNode? list = head;
            while(list?.Data != null)
            {
                Console.WriteLine(list.Data);
                count++;
                list = list.Next;
            }
        }

    }
}
