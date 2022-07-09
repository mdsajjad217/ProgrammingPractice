using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericTree
{
    public static class BuildTree
    {
        public static TreeNode RecursiveBuild()
        {
            TreeNode root = new TreeNode();

            Console.WriteLine("Value of node?");
            string dataString = Console.ReadLine();
            int data = Convert.ToInt32(dataString);

            root.data = data;

            Console.WriteLine("How many children?");
            int noOfChildren = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < noOfChildren; i++)
            {
                TreeNode child = RecursiveBuild();
                if (root.children == null)
                    root.children = new List<TreeNode>();
                root.children.Add(child);
            }

            return root;
        }

        public static void RecursivePrint(TreeNode root)
        {
            Console.Write(root.data + " : ");

            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    Console.Write(child.data + ", ");
                }
            }
            Console.WriteLine();
            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    RecursivePrint(child);
                }
            }
        }

        public static TreeNode LevelWiseBuild(bool manualBuild = false)
        {
            TreeNode root = new TreeNode();
            if (manualBuild == true)
            {
                root.data = 1;
                root.children = new List<TreeNode> {
                    new TreeNode { data = 2,
                        children = new List<TreeNode> { new TreeNode { data = 4 }, new TreeNode { data = 5 } } }
                    , new TreeNode { data = 3, children = new List<TreeNode> { new TreeNode { data = 6, children = new List<TreeNode> { new TreeNode { data = 7 } } } } }
                };

                return root;
            }

            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            Console.WriteLine("Value of node?");
            string dataString = Console.ReadLine();
            int data = Convert.ToInt32(dataString);

            root.data = data;
            nodeQueue.Enqueue(root);

            while (nodeQueue.Any())
            {
                TreeNode node = nodeQueue.Dequeue();
                Console.WriteLine($"How many children of {node.data}?");
                int noOfChildren = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < noOfChildren; i++)
                {
                    Console.WriteLine("Value of node?");
                    string childDataString = Console.ReadLine();
                    int childData = Convert.ToInt32(childDataString);
                    TreeNode child = new TreeNode();
                    child.data = childData;
                    if (root.children == null)
                        root.children = new List<TreeNode>();
                    node.children.Add(child);
                    nodeQueue.Enqueue(child);
                }
            }

            return root;
        }

        public static void LevelWisePrint(TreeNode root)
        {
            Queue<TreeNode> nodeQueue = new Queue<TreeNode>();
            nodeQueue.Enqueue(root);
            while (nodeQueue.Any())
            {
                TreeNode node = nodeQueue.Dequeue();
                Console.Write(node.data + " : ");

                if (node.children != null)
                {
                    foreach (TreeNode child in node.children)
                    {
                        Console.Write(child.data + ", ");
                        nodeQueue.Enqueue(child);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}