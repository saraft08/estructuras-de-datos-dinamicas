using System;


namespace Binary_Tree
{
    class TreeTraversal
    {
        public static void InOrderTraversal(BinaryTree root, Action<BinaryTree> callback)
        {
            if (root == null)
            {
                return;
            }

            BinaryTree current = root;
            BinaryTree predecessor;

            while (current != null)
            {
                if (current.Left == null)
                {
                    callback(current);
                    current = current.Right;
                }
                else
                {
                    predecessor = current.Left;

                    while (predecessor.Right != null && predecessor.Right != current)
                    {
                        predecessor = predecessor.Right;
                    }

                    if (predecessor.Right == null)
                    {
                        predecessor.Right = current;
                        current = current.Left;
                    }
                    else
                    {
                        predecessor.Right = null;
                        callback(current);
                        current = current.Right;
                    }
                }
            }
        }
    }
}
