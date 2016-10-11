//Reverse linked list 1 -> 2 -> 3 -> 4 -> 5
//to                  5 -> 4 -> 3 -> 2 -> 1
//=========================================

using System;
using System.Collections.Generic;
using System.Linq;

public class Node {

    public int value;
    public Node Next;
    
    
    public Node(int val, Node node){
        value = val;
        Next = node;
    }
}

public class LinkedList {
    public List<Node> Nodes;
    
    public LinkedList(){
        Nodes = new List<Node>();
    } 

    public void Reverse() {
        var reverseList = new List<Node>();
        var lastNode = Nodes.Where(item => item.Next == null).FirstOrDefault();
        ReverseNode(lastNode);
    }

    private Node ReverseNode(Node node) {
        
        var previous = Nodes.Where(item => item.Next == node).FirstOrDefault();
        if (previous == null)
        {
            var previousNext = node.Next;
            node.Next = null;
            Console.WriteLine(node.Next);
            return node;
        }
        else {            
            node.Next = ReverseNode(previous);
            return node;
        }

    }

    public string GetListOrder() {
        var orderStr = "";
        var lastNode = Nodes.Where(item => item.Next == null).FirstOrDefault();
        orderStr += lastNode.value;
        var currentNode = lastNode;
        
        while (Nodes.Where(item => item.Next == currentNode).FirstOrDefault() != null) {
            currentNode = Nodes.Where(item => item.Next == currentNode).FirstOrDefault();
            orderStr += " <- " + currentNode.value;
        }

        return orderStr;
    }

}