using Udub.Sdde.Collections.Generic;


namespace Sdde.Tests;

public class SinglyLinkedListTests
{
    private readonly ITestOutputHelper output;
    public SinglyLinkedListTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    

    [Theory]
    [InlineData(0, 10, 45)]
    [InlineData(100, 1001, 495550)]
    public void AddFirstByNode_UsingIEnumerable_ReturnSumOfNodeValues(
        int indexStart,
        int indexEnd,
        int expectedNodeSum)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        int expectedNodeCount = indexEnd - indexStart;
        int actualNodeSum = 0;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(new SinglyNode<int>(index));
        }
        
        foreach(var element in tester)
        {
            actualNodeSum += element;
        }

        // Assert
        using (new AssertionScope("sum of nodes"))
        {
            actualNodeSum.Should<int>().Be(expectedNodeSum);   
        }
    }

    [Theory]
    [InlineData(0, 10, 45)]
    [InlineData(100, 1001, 495550)]
    public void AddFirstByNode_UsingIEnumerator_ReturnSumOfNodeValues(
        int indexStart,
        int indexEnd,
        int expectedNodeSum)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;
        int actualNodeSum = 0;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(new SinglyNode<int>(index));
        }
        
        while(looper.MoveNext())
        {
            actualNodeSum += looper.Current;
        }

        // Assert
        using (new AssertionScope("sum of nodes"))
        {
            actualNodeSum.Should<int>().Be(expectedNodeSum);   
        }
    }

    [Theory]
    [InlineData(0, 10, 45)]
    [InlineData(100, 1001, 495550)]
    public void AddFirstByValue_UsingIEnumerable_ReturnSumOfNodeValues(
        int indexStart,
        int indexEnd,
        int expectedNodeSum)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        int expectedNodeCount = indexEnd - indexStart;
        int actualNodeSum = 0;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(index);
        }
        
        foreach(var element in tester)
        {
            actualNodeSum += element;
        }

        // Assert
        using (new AssertionScope("sum of nodes"))
        {
            actualNodeSum.Should<int>().Be(expectedNodeSum);   
        }
    }

    [Theory]
    [InlineData(0, 10, 45)]
    [InlineData(100, 1001, 495550)]
    public void AddFirstByValue_UsingIEnumerator_ReturnSumOfNodeValues(
        int indexStart,
        int indexEnd,
        int expectedNodeSum)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;
        int actualNodeSum = 0;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(index);
        }
        
        while(looper.MoveNext())
        {
            actualNodeSum += looper.Current;
        }

        // Assert
        using (new AssertionScope("sum of nodes"))
        {
            actualNodeSum.Should<int>().Be(expectedNodeSum);   
        }
    }


    [Theory]
    [InlineData(0, 10)]
    [InlineData(100, 1001)]
    public void AddFirstByNode__ReturnCountOfNodes(
        int indexStart,
        int indexEnd)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(new SinglyNode<int>(index));
        }
        
        // Assert
        using (new AssertionScope("node count"))
        {
            tester.Count.Should<int>().Be(expectedNodeCount);   
        }
    }

    [Theory]
    [InlineData(0, 10)]
    [InlineData(100, 1001)]
    public void AddFirstByNode__ReturnFirstNode(
        int indexStart,
        int indexEnd)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(new SinglyNode<int>(index));
        }
        
        // Assert
        using (new AssertionScope("first node"))
        {
            tester.First!.Data.Should<int>().Be(indexEnd - 1);   
        }
    }

    [Theory]
    [InlineData(0, 10)]
    [InlineData(100, 1001)]
    public void AddFirstByNode__ReturnLastNode(
        int indexStart,
        int indexEnd)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddFirst(new SinglyNode<int>(index));
        }
        
        // Assert
        using (new AssertionScope("last node"))
        {
            tester.Last!.Data.Should<int>().Be(indexStart);
            tester.Last!.Next.Should().BeNull();
        }
    }


    [Theory]
    [InlineData(0, 10, 45)]
    [InlineData(100, 1001, 495550)]
    public void AddLastByNode_UsingIEnumerable_ReturnSumOfNodeValues(
        int indexStart,
        int indexEnd,
        int expectedNodeSum)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        int expectedNodeCount = indexEnd - indexStart;
        int actualNodeSum = 0;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddLast(new SinglyNode<int>(index));
        }
        
        foreach(var element in tester)
        {
            actualNodeSum += element;
        }

        // Assert
        using (new AssertionScope("sum of nodes"))
        {
            actualNodeSum.Should<int>().Be(expectedNodeSum);   
        }
    }

    [Theory]
    [InlineData(0, 10, 45)]
    [InlineData(100, 1001, 495550)]
    public void AddLastByNode_UsingIEnumerator_ReturnSumOfNodeValues(
        int indexStart,
        int indexEnd,
        int expectedNodeSum)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;
        int actualNodeSum = 0;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddLast(new SinglyNode<int>(index));
        }
        
        while(looper.MoveNext())
        {
            actualNodeSum += looper.Current;
        }

        // Assert
        using (new AssertionScope("sum of nodes"))
        {
            actualNodeSum.Should<int>().Be(expectedNodeSum);   
        }
    }

    [Theory]
    [InlineData(0, 10)]
    [InlineData(100, 1001)]
    public void AddLastByNode__ReturnCountOfNodes(
        int indexStart,
        int indexEnd)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddLast(new SinglyNode<int>(index));
        }

        // Assert
        using (new AssertionScope("node count"))
        {
            tester.Count.Should<int>().Be(expectedNodeCount);   
        }
    }

    [Theory]
    [InlineData(0, 10)]
    [InlineData(100, 1001)]
    public void AddLastByNode__ReturnFirstNode(
        int indexStart,
        int indexEnd)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddLast(new SinglyNode<int>(index));
        }
        
        // Assert
        using (new AssertionScope("first node"))
        {
            tester.First!.Data.Should<int>().Be(indexStart);   
        }
    }

    [Theory]
    [InlineData(0, 10)]
    [InlineData(100, 1001)]
    public void AddLastByNode__ReturnLastNode(
        int indexStart,
        int indexEnd)
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>();
        IEnumerator<int> looper = tester.GetEnumerator();
        int expectedNodeCount = indexEnd - indexStart;

        // Act
        for (int index = indexStart; index < indexEnd; index++)
        {
            tester.AddLast(new SinglyNode<int>(index));
        }

        // Assert
        using (new AssertionScope("last node"))
        {
            tester.Last!.Data.Should<int>().Be(indexEnd - 1);
            tester.Last!.Next.Should().BeNull();
        }
    }






    [Fact]
    public void AddAfterByValue()
    {
        // Arrange
        ISinglyLinkedList<int> tester = new SinglyLinkedList<int>(0);
        int addAfterValue = 0;
        int modulusValue = 10;
        int modulusremainder = 1;
        int expectedFirstValue = 0;
        int expectedLastValue = 0;
        int expectedNodeCount = 101;
        int expectedNodeSum = 550;
        int actualNodeSum = 0;
        int actualFirstNode = 0;
        int actualLastNode = 100;

        // Act
        for (int index = 1; index < 101; index++)
        {
            if (index % modulusValue == modulusremainder)
            {
                tester.AddAfter(tester.First, addAfterValue);
            }
            tester.AddLast(new SinglyNode<int>(index));
        }

        foreach(int node in tester)
        {
            if(node % modulusValue == modulusremainder)
            {
                actualNodeSum += node;
            }
        }

        //Assert
        using (new AssertionScope("All multiples should be added after the first node"))
        {
            
        }
    }

    [Fact]
    public void AddNodeAfter()
    {
        // Arrange

        
        // Act


        //Assert

        
    }

    [Fact]
    public void Contains()
    {

    }

    [Fact]
    public void RemoveValue()
    {

    }

    [Fact]
    public void RemoveNode()
    {
        // Given
    
        // When
    
        // Then
    }

    [Fact]
    public void RemoveFirst()
    {
        // Given
    
        // When
    
        // Then
    }

    [Fact]
    public void RemoveLast()
    {
        // Given
    
        // When
    
        // Then
    }

    [Fact]
    public void RemoveAll()
    {
        // Given
    
        // When
    
        // Then
    }

}
