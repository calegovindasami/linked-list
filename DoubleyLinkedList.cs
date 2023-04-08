using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_Lists
{
    public class DoubleyLinkedList<T>
    {

        public Node Head = new();
        public Node Tail = new();
        public int Size = 0;

        
        public class Node
        {
            public T Data;
            public Node Previous = null!;
            public Node Next = null!;
            
            public Node(T data)
            {
                Data = data;
            }

            public Node(){}

        }

        public void AddNode(T data)
        {
            if (Head.Data == null)
            {
                Head.Data = data;
                Tail = Head;
            }
            else
            {
                Node node = new(data);

                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;

            }

            Size++;

        }

        public void PrintList()
        {
            Node node = Head;
            while (node != null)
            {
                Console.Write(node.Data + "; ");
                node = node.Next;
            }
            Console.WriteLine();
            Console.WriteLine("Size of list: " + Size);
        }

        public void SearchList(T data)
        {
            Node node = Head;
           
            int index = 0;
            bool bFound = false;
            while (node != null)
            {
                if (node.Data!.Equals(data))
                {
                    Console.WriteLine($"{data} has been found at index: {index}");
                    bFound = true;
                }
                node = node.Next;
                index++;
            }
            
            if (!bFound)
            {
                Console.WriteLine($"{data} has NOT been found.");
            }
        }

        public void InsertNode(T data, int index)
        {
            Node node = Head;
            Node newNode = new(data);
            
            //To insert at head.
            if (index == 0)
            {
                InsertHead(newNode);
            }

            //To insert at tail.
            else if (index == Size - 1)
            {
                InsertTail(newNode);
            }

            //Prevents inserting out of bounds.
            else if (index > Size - 1 || index < 0)
            {
                Console.WriteLine("Index out of range");
                return;
            }

            //Inserts data in the middle.
            else
            {
                InsertMiddle(newNode, index);
            }

            Size++;
        }

        public void InsertHead(Node newNode)
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        public void InsertTail(Node newNode)
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
        }

        public void InsertMiddle(Node newNode, int index)
        {
            Node node = Head;
            for (int i = 0; i < index; i++)
            {
                node = node.Next;
            }
            
            newNode.Previous = node.Previous;
            node.Previous.Next = newNode;
            newNode.Next = node;
        }

        public void DeleteNode(int index)
        {
            Node node = Head;
            if (index > Size - 1 || index < 0)
            {
                Console.WriteLine("Index out of range");
                return;
            }
            else if(index == 0)
            {
                Head = Head.Next;
                Head.Previous = null!;
            }
            else if (index == Size - 1)
            {
                Tail = Tail.Previous;
                Tail.Next = null!;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    node = node.Next;
                }

                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
            Size--;
        }


    }
}