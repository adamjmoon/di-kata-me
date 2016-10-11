using NUnit.Framework;

[TestFixture]
public class ReverseLinkedList_Test
{
    private LinkedList<int> ll;

    [SetUp]
    public void SetUp()
    {
        ll = new LinkedList<int>();
        var lastNode = new Node<int>(5, null);
        ll.Nodes.Add(lastNode);
        var nextNode1 = new Node<int>(4, lastNode);
        ll.Nodes.Add(nextNode1);
        var nextNode2 = new Node<int>(3, nextNode1);
        ll.Nodes.Add(nextNode2);
        var nextNode3 = new Node<int>(2, nextNode2);
        ll.Nodes.Add(nextNode3);
        var firstNode = new Node<int>(1, nextNode3);
        ll.Nodes.Add(firstNode);
    }

    [Test]
    public void ListListOfIntegersShouldBeReversed()
    {
       
       Assert.That(ll.GetListOrder(), Is.EqualTo("5 <- 4 <- 3 <- 2 <- 1"));
       ll.Reverse();
       Assert.That(ll.GetListOrder(), Is.EqualTo("1 <- 2 <- 3 <- 4 <- 5"));

    }

    [Test]
    public void LinkListOfStringsShouldBeReversed()
    {
        var strLL = new LinkedList<string>();

        var lastNode = new Node<string>("eee", null);
        strLL.Nodes.Add(lastNode);
        var nextNode1 = new Node<string>("ddd", lastNode);
        strLL.Nodes.Add(nextNode1);
        var nextNode2 = new Node<string>("ccc", nextNode1);
        strLL.Nodes.Add(nextNode2);
        var nextNode3 = new Node<string>("bbb", nextNode2);
        strLL.Nodes.Add(nextNode3);
        var firstNode = new Node<string>("aaa", nextNode3);
        strLL.Nodes.Add(firstNode);

        Assert.That(strLL.GetListOrder(), Is.EqualTo("eee <- ddd <- ccc <- bbb <- aaa"));
        strLL.Reverse();
        Assert.That(strLL.GetListOrder(), Is.EqualTo("aaa <- bbb <- ccc <- ddd <- eee"));

    }

}
