[TestClass]
public class LinkedListReverserTests
{
    [TestMethod]
    public void Reverse_ShouldReverseLinkedList()
    {
        // Arrange
        var reverser = new LinkedListReverser();
        var node1 = new LinkedListNode<int>(1);
        var node2 = new LinkedListNode<int>(2);
        var node3 = new LinkedListNode<int>(3);
        var node4 = new LinkedListNode<int>(4);

        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;

        // Act
        var reversedHead = reverser.Reverse(node1);

        // Assert
        Assert.AreEqual(4, reversedHead.Value);
        Assert.AreEqual(3, reversedHead.Next.Value);
        Assert.AreEqual(2, reversedHead.Next.Next.Value);
        Assert.AreEqual(1, reversedHead.Next.Next.Next.Value);
        Assert.IsNull(reversedHead.Next.Next.Next.Next);
    }

    [TestMethod]
    public void Reverse_ShouldHandleEmptyList()
    {
        // Arrange
        var reverser = new LinkedListReverser();

        // Act
        var reversedHead = reverser.Reverse<int>(null);

        // Assert
        Assert.IsNull(reversedHead);
    }

    [TestMethod]
    public void Reverse_ShouldHandleSingleElementList()
    {
        // Arrange
        var reverser = new LinkedListReverser();
        var node1 = new LinkedListNode<int>(1);

        // Act
        var reversedHead = reverser.Reverse(node1);

        // Assert
        Assert.AreEqual(1, reversedHead.Value);
        Assert.IsNull(reversedHead.Next);
    }
}
