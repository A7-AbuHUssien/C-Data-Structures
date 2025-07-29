using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Pre_Post_In__OrderTravesal
{
    public class BinaryTreeNode<T>
    {
        public T Value { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Right { get; set; }


        public BinaryTreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }


    public class BinaryTree<T>
    {
        public BinaryTreeNode<T> Root { get; private set; }


        public BinaryTree()
        {
            Root = null;
        }

        public void Insert(T value)
        {
            var newNode = new BinaryTreeNode<T>(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }


            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);


            while (queue.Count > 0)
            {
                var current = queue.Dequeue();


                if (current.Left == null)
                {
                    current.Left = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Left);
                }


                if (current.Right == null)
                {
                    current.Right = newNode;
                    break;
                }
                else
                {
                    queue.Enqueue(current.Right);
                }
            }
        }

        // Print the tree visually
        public void PrintTree()
        {
            if (Root == null)
                return;

            Queue<BinaryTreeNode<T>> queue = new Queue<BinaryTreeNode<T>>();
            queue.Enqueue(Root);

            int level = 0;
            int maxWidth = GetTreeWidth(Root);
            int nodeCount = 1;

            while (queue.Count > 0)
            {
                int count = queue.Count;
                int spaceBetween = (int)Math.Pow(2, maxWidth - level + 1);

                Console.Write(new string(' ', spaceBetween / 2));

                for (int i = 0; i < count; i++)
                {
                    var current = queue.Dequeue();

                    if (current != null)
                    {
                        Console.Write(current.Value);
                        queue.Enqueue(current.Left);
                        queue.Enqueue(current.Right);
                    }
                    else
                    {
                        Console.Write(" ");
                        queue.Enqueue(null);
                        queue.Enqueue(null);
                    }

                    Console.Write(new string(' ', spaceBetween));
                }

                Console.WriteLine();

                nodeCount *= 2;
                level++;

                if (level > maxWidth) break;
            }
        }

        private int GetTreeWidth(BinaryTreeNode<T> node)
        {
            if (node == null)
                return 0;

            int left = GetTreeWidth(node.Left);
            int right = GetTreeWidth(node.Right);

            return Math.Max(left, right) + 1;
        }



        private void PreOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }
        }


        public void PreOrderTraversal()
        {
            PreOrderTraversal(Root);
            Console.WriteLine();
        }
        private void PostOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(Root);
            Console.WriteLine();
        }
        private void InOrderTraversal(BinaryTreeNode<T> node)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left);            
                Console.Write(node.Value + " ");        
                InOrderTraversal(node.Right);           
            }
        }

        public void InOrderTraversal()
        {
            InOrderTraversal(Root);
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Insert(1);
            binaryTree.Insert(2);
            binaryTree.Insert(3);
            binaryTree.Insert(4);
            binaryTree.Insert(5);
            binaryTree.Insert(6);
            binaryTree.Insert(7);

            binaryTree.PrintTree();

            Console.WriteLine("\nPreOrder Traversal (Current - Left SubTree - Right SubTree):");
            binaryTree.PreOrderTraversal();

            Console.WriteLine("\nPostOrder Traversal (Left SubTree - Right SubTree - Current):");
            binaryTree.PostOrderTraversal();

            Console.WriteLine("\nInOrder Traversal (Left SubTree - Current - Right SubTree ):");
            binaryTree.PostOrderTraversal();


        }
    }
}
