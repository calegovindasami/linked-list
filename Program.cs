using Linked_Lists;
using System;

Linked_Lists.LinkedList<int> linkedList = new();

linkedList.AddFirst(1);

linkedList.AddNode(2);

linkedList.AddNode(3);

linkedList.AddNode(4);


linkedList.DeleteMiddle(2);
linkedList.PrintList();

