using Linked_Lists;
using System;

Linked_Lists.DoubleyLinkedList<int> dLinkedList = new();

dLinkedList.AddNode(1);
dLinkedList.AddNode(2);
dLinkedList.AddNode(3);
dLinkedList.AddNode(4);

dLinkedList.PrintList();
dLinkedList.ReverseList();
dLinkedList.PrintList();


