using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Linked_Lists
{
    public class LinkedList<T>
    {
        public Node Head = new();
        public Node PreviousNode = new();





        public class Node 
        {
            public T Data;
            public Node Next = null!;

            public Node(T data)
            {
                Data = data;
            }

            public Node(){}
        }

        public void AddFirst(T data)
        {
            Head.Data = data;
            PreviousNode = Head;
        }

        public void AddNode(T data)
        {
            Node currentNode = new(data);
            PreviousNode.Next = currentNode;
            PreviousNode = currentNode;
        }

        public void PrintList()
        {
            Node node = Head;

            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public void SearchListIteratively(T data)
        {
            Node node = Head;
            bool bFound = false;
            int index = -1;
            while (node != null)
            {
                index++;
                if (node.Data!.Equals(data))
                {
                    bFound = true;
                    Console.WriteLine($"'{data}' was found at index: {index}");
                }
                node = node.Next;
            }

            if (bFound != true)
            {
                Console.WriteLine("Not found.");
            }
            
        }

        public void SearchListRecursively(int data, Node node)
        {
            //Base case.
            if (node.Next == null)
            {
                if (node.Data!.Equals(data))
                {
                    Console.WriteLine("Found");
                    return;
                }
                Console.WriteLine($"'{data}' was not found within the list.");
                return;
            }

            if (node.Data.Equals(data))
            {
                Console.WriteLine("Found");
                return;
            }
            else
            {
                SearchListRecursively(data, node.Next);
            }
        }

        public void CompareData(T dataOne, T dataTwo)
        {
            if (dataOne.Equals(dataTwo))
            {
                Console.WriteLine("Found");
            }
        }

        public void FindLengthIteratively()
        {
            int counter = 1;
            Node node = Head;

            while (node.Next != null)
            {
                counter++;
                node = node.Next;
            }
            Console.WriteLine($"Linked list length: {counter}");
        }

        public void FindLengthRecursively(int counter, Node node)
        {

            if (node.Next == null)
            {
                Console.WriteLine($"Length of list: {counter}");
            }
            else 
            {
                counter++;
                FindLengthRecursively(counter, node.Next);
            }
        }


        //Got code from: https://www.geeksforgeeks.org/reverse-a-linked-list/
        public void ReverseList()
        {
            Node nextNode = null!, previousNode = null!, currentNode = Head;

            while (currentNode != null)
            {
                nextNode = currentNode.Next;
                currentNode.Next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }
            Head = PreviousNode;
        }

        public void DeleteHead()
        {
            Node node = Head;
            Head = node.Next;
        }

        public void DeleteTail()
        {
            Node currentNode = Head;

            while (currentNode.Next.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = null!;
        }

        public void DeleteMiddle(int position)
        {
            Node currentNode = Head;
            for (int i = 0; i < position - 1; i++)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = currentNode.Next.Next;
        }

    
    }


}