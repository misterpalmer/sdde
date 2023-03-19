using System.Collections.Generic;


namespace Sdde.Tests.Data;

public class LinkedListTestsData
{
     public static IEnumerable<object[]> SummationTestData =>
        new List<object[]>
            {
                new object[] { 0, 10, 45 },
                new object[] { 100, 1001, 495550 },
                new object[] { 1, 10001, 50005000 },
            };

    public static IEnumerable<object[]> CreateLinkedListFromIEnumerableData =>
        new List<object[]>
            {
                new object[] { (object) new int[] { 0 } },
                new object[] { (object) new int[] { 100, 99 } },
                new object[] { (object) new int[] { 1, 2, 3, 4, 5 } },
                new object[] { (object) new int[] { 23, 45, 67 } },
                new object[] { (object) new int[] { 98, 76, 54 } },
                new object[] { new string[] { "One", "Two", "Three", "Four", "Five" } },
                new object[] { new string[] { "linked", "list", "node" } },
                new object[] { new string[] { "singly", "doubly", "circular" } },
                new object[] { (object) new bool[] { true } },
                new object[] { (object) new bool[] { true, false } },
                new object[] { (object) new bool[] { true, true, true } },
            };
    
    public static IEnumerable<object[]> ThreeNodeData =>
        new List<object[]>
            {
                new object[] { 23, 45, 67 },
                new object[] { 98, 76, 54 },
                new object[] { 0, 10, 45 },
                new object[] { 100, 1001, 495550 },
                new object[] { "linked", "list", "node" },
                new object[] { "singly", "doubly", "circular" },
                new object[] { true, true, true },
                new object[] { true, true, false },
            };

    public static IEnumerable<object[]> NegativeSearchData =>
        new List<object[]>
            {
                new object[] { (object) new int[] { 0 }, 1 },
                new object[] { (object) new int[] { 100, 99 }, 1 },
                new object[] { (object) new int[] { 1, 2, 3, 4, 5 }, 1000 },
                new object[] { (object) new int[] { 23, 45, 67 }, 0 },
                new object[] { (object) new int[] { 98, 76, 54 }, 10000 },
                new object[] { new string[] { "One", "Two", "Three", "Four", "Five" }, "Zero" },
                new object[] { new string[] { "linked", "list", "node" }, "stack" },
                new object[] { new string[] { "singly", "doubly", "circular" }, "heap" },
                new object[] { (object) new bool[] { true }, false },
                new object[] { (object) new bool[] { true, true }, false },
                new object[] { (object) new bool[] { true, true, true }, false },
            };
}