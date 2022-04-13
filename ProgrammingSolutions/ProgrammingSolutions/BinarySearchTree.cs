using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingSolutions
{
    public class BinarySearchTree : BinaryTreeGenerate
    {
        public BinarySearchTree(int?[] values) : base(values)
        {

        }

        public TreeNode Search(int key)
        {
            //return RecursiveSearch(rootNode, key);
            return IterativeSearch(rootNode, key);
        }

        private TreeNode RecursiveSearch(TreeNode node, int key)
        {
            if (node == null)
                return null;

            if (node.value == key)
                return node;

            if (key < node.value)
                return RecursiveSearch(node.left, key);

            else if (key > node.value)
                return RecursiveSearch(node.right, key);

            return null;
        }

        private TreeNode IterativeSearch(TreeNode node, int key)
        {
            while (node != null)
            {
                if (key == node.value)
                    return node;
                else if (key < node.value)
                    node = node.left;
                else if (key > node.value)
                    node = node.right;
            }

            return null;
        }

        public TreeNode Insert(int key)
        {
            TreeNode node = rootNode;
            TreeNode tailNode = rootNode;
            while (node != null)
            {
                tailNode = node;
                if (key == node.value)
                    return node;
                else if (key < node.value)
                    node = node.left;
                else if (key > node.value)
                    node = node.right;
            }
            TreeNode newNode = new TreeNode(key);
            if (newNode.value < tailNode.value)
                tailNode.left = newNode;
            else if (newNode.value > tailNode.value)
                tailNode.right = newNode;

            return rootNode;
        }

        public TreeNode GenerateFromPreOrder()
        {
            TreeNode p = rootNode;
            int i = 0;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while (i < values.Length)
            {
                if (values[i] < p.value)
                {
                    TreeNode node = new TreeNode(values[i]);
                    p.left = node;
                    stack.Push(p);
                    p = node;
                    i++;
                }
                else
                {
                    if (values[i] < stack.Peek().value || stack.Any() == false)
                    {
                        TreeNode node = new TreeNode(values[i]);
                        p.right = node;
                        p = node;
                        i++;
                    }
                    else
                    {
                        p = stack.Pop();
                    }
                }
            }

            return rootNode;
        }
    }
}
