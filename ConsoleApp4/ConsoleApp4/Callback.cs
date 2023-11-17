using System;


namespace Binary_Tree
{
    class Callback
    {
        public static void Execute(BinaryTree node)
        {
            // Aquí se llama a la función de devolución de llamada
            Console.WriteLine($"callback({node.Value})");
        }
    }
}
