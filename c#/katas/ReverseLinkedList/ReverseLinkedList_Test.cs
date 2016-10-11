using NUnit.Framework;

[TestFixture]
public class ReverseLinkedList_Test
{
    private LinkedList ll;

    [SetUp]
    public void SetUp()
    {
        ll = new LinkedList();
        var lastNode = new Node(5, null);
        ll.Nodes.Add(lastNode);
        var nextNode1 = new Node(4, lastNode);
        ll.Nodes.Add(nextNode1);
        var nextNode2 = new Node(3, nextNode1);
        ll.Nodes.Add(nextNode2);
        var nextNode3 = new Node(2, nextNode2);
        ll.Nodes.Add(nextNode3);
        var firstNode = new Node(1, nextNode3);
        ll.Nodes.Add(firstNode);
    }

    [Test]
    public void ListShouldBeReversed()
    {
       
       Assert.That(ll.GetListOrder(), Is.EqualTo("5 <- 4 <- 3 <- 2 <- 1"));
       ll.Reverse();
       Assert.That(ll.GetListOrder(), Is.EqualTo("1 <- 2 <- 3 <- 4 <- 5"));

    }
   
}
