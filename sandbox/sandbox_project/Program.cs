public class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }

    public Node(int data)
    {
        this.Data = data;
    }
}

public class BinaryTree
{
    public Node? Root { get; set; }

    public bool IsValidBST()
    {
        return IsValidBST(Root, long.MinValue, long.MaxValue);
    }

    private bool IsValidBST(Node? node, long min, long max)
    {

        // Base case: an empty tree is a valid BST
        if (node == null)
        {
            return true;
        }

        // Code to see if the current node's value is in the valid range
        if (node.Data <= min || node.Data >= max)
        {
            return false;
        }

        return IsValidBST(node.Left, min, node.Data) && // The left subtree must be less than current node
               IsValidBST(node.Right, node.Data, max);  // The right subtree must be greater than current node
    }
}