using System;
using System.Collections.Generic;

namespace GeneralTreeExample
{
    class Program
    {
        public class TreeNode<T>
        {
            public T Value { get; set; }
            public List<TreeNode<T>> Children { get; set; }

            public TreeNode(T value)
            {
                this.Value = value;
                Children = new List<TreeNode<T>>();
            }

            public void AddChild(TreeNode<T> child)
            {
                Children.Add(child);
            }
            public TreeNode<T> Find(T value)
            {
                if (EqualityComparer<T>.Default.Equals(Value, value)) return this;

                foreach (TreeNode<T> child in Children)
                {
                    var Founded = child.Find(value);
                    if (Founded != null) return Founded;
                }
                return null;
            }
        }

        public class Tree<T>
        {
            public TreeNode<T> Root { get; private set; }

            public Tree(T rootValue)
            {
                Root = new TreeNode<T>(rootValue);
            }

            public void PrintTree()
            {
                PrintTree(Root, "", true);
            }

            private void PrintTree(TreeNode<T> node, string indent, bool isLast)
            {
                Console.Write(indent);
                if (isLast)
                {
                    Console.Write("└──");
                    indent += "   ";
                }
                else
                {
                    Console.Write("├──");
                    indent += "│  ";
                }

                Console.WriteLine(node.Value);

                for (int i = 0; i < node.Children.Count; i++)
                {
                    PrintTree(node.Children[i], indent, i == node.Children.Count - 1);
                }

            }
            public TreeNode<T> Find(T value)
            {
                return Root?.Find(value);
            }
        }

        static void Main(string[] args)
        {
            // Create the root
            var Pc = new Tree<string>("PC");

            var C = new TreeNode<string>("C");
            var D = new TreeNode<string>("D");
            Pc.Root.Children.Add(C);
            Pc.Root.Children.Add(D);
            // D Folders
            var Courses = new TreeNode<string>("Courses");

            Courses.AddChild(new TreeNode<string>("BackEnd"));
            Courses.AddChild(new TreeNode<string>("FrontEnd"));
            Courses.AddChild(new TreeNode<string>("English"));
            Courses.AddChild(new TreeNode<string>("DSA"));

            var Movies = new TreeNode<string>("Movies");

            var Gallery = new TreeNode<string>("Gallery");
            Gallery.AddChild(new TreeNode<string>("Me"));
            Gallery.AddChild(new TreeNode<string>("Hamza"));
            Gallery.AddChild(new TreeNode<string>("Videos"));


            D.AddChild(Movies);
            D.AddChild(Gallery);
            D.AddChild(Courses);

            var Projects = new TreeNode<string>("Projects");



            // Print the tree
            Pc.PrintTree();
        }
    }
}
