using Linked_Lists;
using System;

Linked_Lists.DoubleyLinkedList<string> dLinkedList = new();

dLinkedList.AddNode("Head");
dLinkedList.AddNode("Two");
dLinkedList.AddNode("Three");
dLinkedList.PrintList();
dLinkedList.InsertNode("New", 1);
dLinkedList.PrintList();


