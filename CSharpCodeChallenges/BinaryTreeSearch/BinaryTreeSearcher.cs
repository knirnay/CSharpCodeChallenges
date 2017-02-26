namespace CSharpCodeChallenges.BinaryTreeSearch
{
    using System;

    /// <summary>
    /// Binary search Tree example. 
    /// Binary search tree (BST) is a binary tree where the value of each node is larger or equal 
    /// to the values in all the nodes in that node's left subtree and is smaller than the values 
    /// in all the nodes in that node's right subtree.
    /// </summary>
    public static class BinaryTreeSearcher
    {
        /// <summary>
        /// Tests the binary tree travers.
        /// </summary>
        public static void TestBinaryTreeTravers()
        {
            Node n102 = new Node(102, null, null);
            Node n101 = new Node(101, null, n102);
            Node n98 = new Node(98, null, null);
            Node n99 = new Node(99, n98, null);
            Node n100 = new Node(100, n99, n101);
            Console.WriteLine(TreeTraverser(n100, 150));
        }

        /// <summary>
        /// Trees the traverser.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static bool TreeTraverser(Node node, int value)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (value > node.Value)
            {
                if (node.Right == null)
                {
                    return false;
                }

                if (node.Right.Value == value)
                {
                    return true;
                }

                while (node.Right.Value != value)
                {
                    return TreeTraverser(node.Right, value);
                }
            }

            if (value < node.Value)
            {
                if (node.Left == null)
                {
                    return false;
                }

                if (node.Left.Value == value)
                {
                    return true;
                }

                while (node.Left.Value != value)
                {
                    return TreeTraverser(node.Left, value);
                }
            }

            return false;
        }
    }
}
