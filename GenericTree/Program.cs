using System;

namespace GenericTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode rootNode = BuildTree.LevelWiseBuild(true);
            PrintTree.LevelWisePrint(rootNode);
            PrintTree.PrintAtLevelK(rootNode, 3);
            TreeCount.CountTotalNodes(rootNode);
            TreeCount.CountTotalLeafNodes(rootNode);
            TreeCount.CountTreeHeight(rootNode);
            DeleteTree.TreeDelete(rootNode);
        }
    }
}
