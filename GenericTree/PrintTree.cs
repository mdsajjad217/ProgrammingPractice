using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public class PrintTree
    {
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

        public static void PrintAtLevelK(TreeNode root, int level)
        {
            Console.WriteLine($"Elements at level: {level}");
            PrintAtLevelKRecursive(root, level);
            Console.WriteLine();
        }

        public static void PrintAtLevelKRecursive(TreeNode root, int level)
        {
            if (level == 1)
            {
                Console.Write($"{root.data}, ");
                return;
            }
            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    PrintAtLevelKRecursive(child, level - 1);
                }
            }
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
