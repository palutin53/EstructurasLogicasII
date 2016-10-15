using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB1
{
    class Program
    {
         static public void Main(String []args)
        {

        }
        class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int initial)        // Constructor
            {
                value = initial;
                left = null;
                left = null;
            }
        }
        class Tree
        {
            Node top;
            public Tree()
            {
                top = null;
            }
            public Tree(int initial)
            {
                top = new Node(initial);
            }
            public void Add(int value)
            {
                // non-recursive add
                if (top == null)    // the tree is empty
                {
                    // add item has a base node
                    Node NewNode = new Node(value);
                    top = NewNode;
                    return;
                }
                Node CurrentNode = top;
                bool added = false;
                do
                {
                    // Traverse tree
                    if (value < CurrentNode.value)
                    {
                        // go left
                        if (CurrentNode.left == null)
                        {
                            // add the item
                            Node NewNode = new Node(value);
                            CurrentNode.left = NewNode;
                            added = true;
                        }
                        else
                        {
                            CurrentNode = CurrentNode.left;
                        }
                    }
                    if(value>=CurrentNode.value)
                    {
                        if(CurrentNode.right==null)
                        {
                            Node NewNode = new Node(value);
                            CurrentNode.right = NewNode;
                            added = true;
                        }
                        else
                        {
                            // go right
                            CurrentNode = CurrentNode.right;
                        }
                    }
                } while (!added);
            }
            public void AddRc(int value)
            {
                // recursive add
                AddR(ref top, value);
            }
            private void AddR(ref Node N, int value)
            {
                // private recursive search for where to add the new node
                if (N == null)
                {
                    // Node doesn`t exist, so add it here
                    Node NewNode = new Node(value);
                    N = NewNode; // here, set the old node reference to the newly created node thus attaching it to the tree
                    return; //end the function call a fall back
                }
                if (value < N.value)
                {
                    AddR(ref N.left, value);
                    return;
                }
                if(value >= N.value)
                {
                    AddR(ref N.right, value);
                    return;
                }
            }
            public void Print(Node N, ref string s)
            {
                // write oout the tree in sorted order to the string newstring
                // implement using recursion
                if(N == null) { N = top; }
                if (N.left != null)
                {
                    Print(N.left, ref s);
                    s = s + N.value.ToString().PadLeft(3);
                }
                else
                {
                    s = s + N.value.ToString().PadLeft(3);
                }
                if (N.right != null)
                {
                    Print(N.right, ref s);
                }
            }
        }
    }
}
