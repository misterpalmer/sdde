// See https://aka.ms/new-console-template for more information
using Udub.Sdde.Collections.Generic;

Console.WriteLine("Hello, World!");

ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
for (int index = 0; index < 10; index++)
{
    tester.AddLast(new SinglyNode<int>(index));
}

Console.WriteLine($"Total Nodes: {tester.Count.ToString()}");
foreach(var element in tester)
{
    Console.WriteLine($"Node: {element}");
}

tester.Clear();
for (int index = 0; index < 10; index++)
{
    tester.AddFirst(new SinglyNode<int>(index));
}

Console.WriteLine($"Total Nodes: {tester.Count.ToString()}");
foreach(var element in tester)
{
    Console.WriteLine($"Node: {element}");
}

Console.WriteLine($"Total Nodes: {tester.Count.ToString()}");
IEnumerator<int> looper = tester.GetEnumerator();
while(looper.MoveNext())
{
    Console.WriteLine($"Node: {looper.Current}");
}


var message = Console.ReadLine();
