//Reverse linked list 1 -> 2 -> 3 -> 4 -> 5
//to                  5 -> 4 -> 3 -> 2 -> 1
//=========================================

using System;
using System.Collections.Generic;
using System.Linq;

public class Node<T> {

    public T value;
    public Node<T> Next;
    
    
    public Node(T val, Node<T> node){
        value = val;
        Next = node;
    }
}

public class LinkedList<T>
{
    public List<Node<T>> Nodes;
    
    public LinkedList(){
        Nodes = new List<Node<T>>();
    } 

    public void Reverse() {
        var reverseList = new List<Node<T>>();
        var lastNode = Nodes.Where(item => item.Next == null).FirstOrDefault();
        ReverseNode(lastNode);
    }

    private Node<T> ReverseNode(Node<T> node) {
        
        var previous = Nodes.Where(item => item.Next == node).FirstOrDefault();
        if (previous == null)
        {            
            node.Next = null;            
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