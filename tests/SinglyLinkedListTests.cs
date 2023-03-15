using Udub.Sdde.Collections.Generic;


namespace sdde.tests;

public class SinglyLinkedListTests
{
    private readonly ITestOutputHelper output;
    public SinglyLinkedListTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    [Fact]
    public void Add_To_List_At_Last()
    {
         ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
         for (int index = 0; index < 10; index++)
         {
            tester.AddLast(new SinglyNode<int>(index));
         }
        
        output.WriteLine($"Total Nodes: {tester.Count.ToString()}");
         foreach(var element in tester)
         {
            output.WriteLine($"Node: {element}");
         }
    }

    [Fact]
    public void Add_To_List_At_First()
    {
         ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
         for (int index = 0; index < 10; index++)
         {
            tester.AddFirst(new SinglyNode<int>(index));
         }
        
        output.WriteLine($"Total Nodes: {tester.Count.ToString()}");
         foreach(var element in tester)
         {
            output.WriteLine($"Node: {element}");
         }
    }
}