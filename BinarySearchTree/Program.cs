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
            search.Insert(22);
            search.Insert(40);
            search.Insert(60);
            search.Insert(95);
            search.Insert(11);
            search.Insert(65);
            search.Insert(3);
            search.Insert(16);
            search.Insert(63);
            search.Insert(67);
            search.Display();
            search.GetSize();
        }
    }
}
