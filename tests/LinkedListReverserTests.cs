using Xunit;

public class LinkedListReverserTests
{
    [Fact]
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
        Assert.Equal(4, reversedHead.Value);
        Assert.Equal(3, reversedHead.Next.Value);
        Assert.Equal(2, reversedHead.Next.Next.Value);
        Assert.Equal(1, reversedHead.Next.Next.Next.Value);
        Assert.Null(reversedHead.Next.Next.Next.Next);
    }

    [Fact]
    public void Reverse_ShouldHandleEmptyList()
    {
        // Arrange
        var reverser = new LinkedListReverser();

        // Act
        var reversedHead = reverser.Reverse<int>(null);

        // Assert
        Assert.Null(reversedHead);
    }

    [Fact]
    public void Reverse_ShouldHandleSingleElementList()
    {
        // Arrange
        var reverser = new LinkedListReverser();
        var node1 = new LinkedListNode<int>(1);

        // Act
        var reversedHead = reverser.Reverse(node1);

        // Assert
        Assert.Equal(1, reversedHead.Value);
        Assert.Null(reversedHead.Next);
    }
}
