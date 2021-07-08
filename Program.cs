using System;

public class Node
{
    public int Value { get; set; }

    public Node Left { get; set; }

    public Node Right { get; set; }

    public Node(int value, Node left, Node right)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinarySearchTree
{
	public int step {get; set;}
	
    public bool Contains(Node root, int value, int step)
    {
		this.step= step;
		
        if (root == null)
        {
          return false;
        }else{
        if(root.Value>value)
        {
            root =root.Left;
			step = step+1;
            return Contains(root,value,step);
        }else if(root.Value<value)
        {
            root= root.Right;
			step = step+1;
            return Contains(root,value,step);
        }else if(root.Value==value){
            return true;
        }else 
            return false;
        }
    }

    public static void Main(string[] args)
    {
        Node n1 = new Node(1, null, null);
        Node n3 = new Node(3, null, null);
        Node n2 = new Node(2, n1, n3);

		BinarySearchTree tree = new BinarySearchTree();
	    tree.step = 0;
        Console.WriteLine(tree.Contains(n2, 3, tree.step) +" "+ tree.step);
		
    }
}