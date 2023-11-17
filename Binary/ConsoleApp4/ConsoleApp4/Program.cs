using System;


namespace Binary_Tree
{


    class Program
    {
        static void Main()
        {
            // Construir el árbol de ejemplo
            BinaryTree tree = new BinaryTree(1)
            {
                Left = new BinaryTree(2)
                {
                    Left = new BinaryTree(4)
                    {
                        Right = new BinaryTree(9)
                    }
                },
                Right = new BinaryTree(3)
                {
                    Left = new BinaryTree(6),
                    Right = new BinaryTree(7)
                }
            };

            // Realizar el recorrido en orden con la función de devolución de llamada
            TreeTraversal.InOrderTraversal(tree, Callback.Execute);
        }
    }
}
