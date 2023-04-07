using Linked_Lists;
using System;

Linked_Lists.LinkedList<int> linkedList = new();

linkedList.AddFirst(0);

linkedList.AddNode(1);

linkedList.AddNode(2);


linkedList.PrintList();

linkedList.FindLengthRecursively(1, linkedList.Head);