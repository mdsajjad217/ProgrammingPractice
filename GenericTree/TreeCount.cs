using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTree
{
    public static class TreeCount
    {
        public static void CountTotalNodes(TreeNode root)
        {
            int totalNodes = CountTotalNodesRecursive(root);
            Console.WriteLine($"Total Nodes: {totalNodes}");
        }

        public static int CountTotalNodesRecursive(TreeNode root)
        {
            if (root == null)
                return 0;

            int selfCount = 1;
            int childrenCount = 0;
            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    childrenCount += CountTotalNodesRecursive(child);
                }
            }

            return selfCount + childrenCount;
        }

        public static void CountTotalLeafNodes(TreeNode root)
        {
            int totalLeafNodes = CountTotalLeafNodesRecursive(root);
            Console.WriteLine($"Total Leaf Nodes: {totalLeafNodes}");
        }

        public static int CountTotalLeafNodesRecursive(TreeNode root)
        {
            if (root == null)
                return 1;

            int leafCount = 0;
            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    leafCount += CountTotalLeafNodesRecursive(child);
                }
            }
            else
            {
                leafCount = 1;
            }

            return leafCount;
        }

        public static void CountTreeHeight(TreeNode root)
        {
            int treeHeight = CountTreeHeightRecursive(root);
            Console.WriteLine($"Tree height: {treeHeight}");
        }

        public static int CountTreeHeightRecursive(TreeNode root)
        {
            if (root == null)
                return 0;

            int selfCount = 1;
            int maxChildrenHeight = 0;
            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    maxChildrenHeight = Math.Max(maxChildrenHeight, CountTreeHeightRecursive(child));
                }
            }

            return selfCount + maxChildrenHeight;
        }
    }
}
