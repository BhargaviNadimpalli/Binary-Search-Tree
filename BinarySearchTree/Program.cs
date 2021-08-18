using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary search tree programs");

            BinaryTree<int> search = new BinaryTree<int>(56);
            search.Insert(30);
            search.Insert(70);
            search.Display();
            search.GetSize();
        }
    }
}
