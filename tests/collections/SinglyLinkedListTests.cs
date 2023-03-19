using Udub.Sdde.Collections.Generic;
using Sdde.Tests.Data;

namespace Sdde.Tests;

public class SinglyLinkedListTests
{
    private readonly ITestOutputHelper output;
    public SinglyLinkedListTests(ITestOutputHelper output)
    {
        this.output = output;
    }
    
    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddFirstByNode_UsingIEnumerable_ReturnSumOfNodesAndListProperties(
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
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Data.Should<int>().Be(indexStart);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddFirstByNode_UsingIEnumerator_ReturnSumOfNodesAndListProperties(
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
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Data.Should<int>().Be(indexStart);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddFirstByValue_UsingIEnumerable_ReturnSumOfNodesAndListProperties(
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
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Data.Should<int>().Be(indexStart);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddFirstByValue_UsingIEnumerator_ReturnSumOfNodesAndListProperties(
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
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Data.Should<int>().Be(indexStart);
        tester.Last!.Next.Should().BeNull();
    }
    
    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddLastByNode_UsingIEnumerable_ReturnSumOfNodesAndListProperties(
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
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexStart);
        tester.Last!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddLastByNode_UsingIEnumerator_ReturnSumOfNodesAndListProperties(
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
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexStart);
        tester.Last!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddLastByValue_UsingIEnumerable_ReturnSumOfNodesAndListProperties(
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
            tester.AddLast(index);
        }
        
        foreach(var element in tester)
        {
            actualNodeSum += element;
        }

        // Assert
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexStart);
        tester.Last!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.SummationTestData), MemberType= typeof(LinkedListTestsData))]
    public void CreateEmptyList_AddLastByValue_UsingIEnumerator_ReturnSumOfNodesAndListProperties(
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
            tester.AddLast(index);
        }
        
        while(looper.MoveNext())
        {
            actualNodeSum += looper.Current;
        }

        // Assert
        using var scope = new AssertionScope();
        actualNodeSum.Should<int>().Be(expectedNodeSum);
        tester.Count.Should<int>().Be(expectedNodeCount);
        tester.First!.Data.Should<int>().Be(indexStart);
        tester.Last!.Data.Should<int>().Be(indexEnd - 1);
        tester.Last!.Next.Should().BeNull();  
    }
    
    [Theory]
    [MemberData(nameof(LinkedListTestsData.ThreeNodeData), MemberType= typeof(LinkedListTestsData))]
    public void CreateListByNode_MultipleAddLast_ReturnListProperties<T>(T first, T second, T third)
    {
        // Arrange
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(new SinglyNode<T>(first));

        // Act
        tester.AddLast(second);
        tester.AddLast(new SinglyNode<T>(third));

        // Assert
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(3);
        tester.First!.Data.Should().Be(first);
        tester.Last!.Data.Should().Be(third);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.ThreeNodeData), MemberType= typeof(LinkedListTestsData))]
    public void CreateListByValue_MultipleAddLast_ReturnListProperties<T>(T first, T second, T third)
    {
        // Arrange
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(first);

        // Act
        tester.AddLast(second);
        tester.AddLast(new SinglyNode<T>(third));

        // Assert
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(3);
        tester.First!.Data.Should().Be(first);
        tester.Last!.Data.Should().Be(third);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.ThreeNodeData), MemberType= typeof(LinkedListTestsData))]
    public void CreateListByNode_MultipleAddFirst_ReturnListProperties<T>(T first, T second, T third)
    {
        // Arrange
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(new SinglyNode<T>(first));

        // Act
        tester.AddFirst(second);
        tester.AddFirst(new SinglyNode<T>(third));

        // Assert
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(3);
        tester.First!.Data.Should().Be(third);
        tester.Last!.Data.Should().Be(first);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.ThreeNodeData), MemberType= typeof(LinkedListTestsData))]
    public void CreateListByValue_MultipleAddFirst_ReturnListProperties<T>(T first, T second, T third)
    {
        // Arrange
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(first);

        // Act
        tester.AddFirst(second);
        tester.AddFirst(new SinglyNode<T>(third));

        // Assert
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(3);
        tester.First!.Data.Should().Be(third);
        tester.Last!.Data.Should().Be(first);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.ThreeNodeData), MemberType= typeof(LinkedListTestsData))]
    public void CreateListByNode_MultipleAddMixed_ReturnListProperties<T>(T first, T second, T third)
    {
        // Arrange
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(new SinglyNode<T>(first));

        // Act
        tester.AddLast(second);
        tester.AddFirst(new SinglyNode<T>(third));

        // Assert
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(3);
        tester.First!.Data.Should().Be(third);
        tester.Last!.Data.Should().Be(second);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.ThreeNodeData), MemberType= typeof(LinkedListTestsData))]
    public void CreateListByValue_MultipleAddMixed_ReturnListProperties<T>(T first, T second, T third)
    {
        // Arrange
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(first);

        // Act
        tester.AddLast(new SinglyNode<T>(second));
        tester.AddFirst(third);

        // Assert
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(3);
        tester.First!.Data.Should().Be(third);
        tester.Last!.Data.Should().Be(second);
        tester.Last!.Next.Should().BeNull();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.CreateLinkedListFromIEnumerableData), MemberType= typeof(LinkedListTestsData))]
    public void CreateList_FromIEnumerable_ReturnListProperties<T>(T[] values)
    {
        // Given
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(values);

        // When

        // Then
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(values.Count());
        tester.First!.Data.Should().Be(values.First());
        tester.Last!.Data.Should().Be(values.Last());
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.CreateLinkedListFromIEnumerableData), MemberType= typeof(LinkedListTestsData))]
    public void CreateList_FromIEnumerable_ClearList_ReturnListProperties<T>(T[] values)
    {
        // Given
        ISinglyLinkedList<T> tester = new SinglyLinkedList<T>(values);

        // When
        tester.Clear();
        
        // Then
        using var scope = new AssertionScope();
        tester.Count.Should<int>().Be(0);
        tester.First!.Should().BeNull();
        tester.Last!.Should().BeNull();
    }

    [Fact]
    public void AddAfterByValue()
    {
        // Arrange

        // Act

        //Assert
    }

    [Fact]
    public void AddNodeAfter()
    {
        // Arrange

        
        // Act


        //Assert

        
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.CreateLinkedListFromIEnumerableData), MemberType= typeof(LinkedListTestsData))]
    public void Contains_FindRandomIndexFromInput_ReturnsTrue<T>(T[] values)
    {
        // Given
        ISinglyLinkedList<T> sut = new SinglyLinkedList<T>(values);
        Random random = new Random();
        var index = random.Next(values.Count());

        // When
        var result = sut.Contains(values[index]);

        // Then
        using var scope = new AssertionScope();
        result.Should().BeTrue();
    }

    [Theory]
    [MemberData(nameof(LinkedListTestsData.NegativeSearchData), MemberType= typeof(LinkedListTestsData))]
    public void Contains_FindRandomIndexFromInput_ReturnsFalse<T>(T[] values, T input)
    {
        // Given
        ISinglyLinkedList<T> sut = new SinglyLinkedList<T>(values);

        // When
        var result = sut.Contains(input);

        // Then
        using var scope = new AssertionScope();
        result.Should().BeFalse();
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
