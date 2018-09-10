using System;

namespace ImplementTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // code here
        }
    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    class BinarySearchTree
    {
        // insert a value into tree
        public Node Insert(Node root, int val)
        {
            if (root == null)
            {
                root = new Node();
                root.value = val;
            }
            else if (root.value > val)
            {
                root.left = Insert(root.left, val);
            }
            else
            {
                root.right = Insert(root.right, val);
            }
            return root;
        }

        // traverse through tree
        public void Traverse(Node root)
        {
            if (root == null)
                return;

            Traverse(root.left);
            Traverse(root.right);
        }

        // search tree
        public Node SearchBst(Node root, int val)
        {
            if (root == null || root.value == val)
                return root;

            if (root.value > val)
                return SearchBst(root.left, val);
         
            if (root.value < val)
                return SearchBst(root.right, val);

            // not in tree
            return null;
        }

        // Sum all nodes in tree
        public int SumBST(Node root)
        {
            if (root == null)
                return 0;

            return root.value + SumBST(root.left) + SumBST(root.right);
        }

        // find the min value in a tree
        public int MinBSTVal(Node root)
        {
            if (root.left == null)
                return root.value;

            return MinBSTVal(root.left);
        }
    }
}
