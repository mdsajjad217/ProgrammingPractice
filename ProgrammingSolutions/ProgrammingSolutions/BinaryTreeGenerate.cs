using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingSolutions
{
    public class BinaryTreeGenerate
    {
        public TreeNode rootNode;
        public int?[] values = null;

        public BinaryTreeGenerate(int?[] values)
        {
            this.values = values;
            rootNode = Generate();
        }

        public TreeNode Generate()
        {
            var queue = new Queue<TreeNode>();
            rootNode = new TreeNode(values[0]);
            queue.Enqueue(rootNode);
            int i = 1;
            while (queue.Any() && i < values.Length)
            {
                TreeNode node = queue.Dequeue();
                node.left = new TreeNode(values[i]);
                queue.Enqueue(node.left);
                i++;

                if (i <= values.Length)
                {
                    node.right = new TreeNode(values[i]);
                    queue.Enqueue(node.right);
                    i++;
                }
            }

            return rootNode;
        }

        public int?[] PreorderTraversal()
        {
            var stack = new Stack<TreeNode>();
            TreeNode temp = rootNode;
            var outPutArray = new int?[values.Length];
            int i = 0;
            while (stack.Any() || temp != null)
            {
                if (temp != null)
                {
                    outPutArray[i++] = temp.value;
                    stack.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    temp = stack.Pop();
                    temp = temp.right;
                }
            }

            return outPutArray;
        }

        public int?[] InorderTraversal()
        {
            var stack = new Stack<TreeNode>();
            TreeNode temp = rootNode;
            var outPutArray = new int?[values.Length];
            int i = 0;

            while (stack.Any() || temp != null)
            {
                if (temp != null)
                {
                    stack.Push(temp);
                    temp = temp.left;
                }
                else
                {
                    temp = stack.Pop();
                    outPutArray[i++] = temp.value;
                    temp = temp.right;
                }
            }

            return outPutArray;
        }

        public int?[] LevelorderTraversal()
        {
            var queue = new Queue<TreeNode>();
            TreeNode temp = rootNode;
            var outPutArray = new int?[values.Length];
            int i = 0;
            //8, 3, 5, 4, 9, 7, 2
            queue.Enqueue(temp);
            while (queue.Any())
            {
                temp = queue.Dequeue();
                if (temp != null)
                {
                    outPutArray[i++] = temp.value;
                }
                if (temp.left != null)
                {
                    queue.Enqueue(temp.left);
                }
                if (temp.right != null)
                {
                    queue.Enqueue(temp.right);
                }
            }

            return outPutArray;
        }

        public int LeafNodeCount()
        {
            return LeafNodeCountRecursive(rootNode);
        }

        public int LeafNodeCountRecursive(TreeNode node)
        {
            if (node == null)
                return 0;

            int x = LeafNodeCountRecursive(node.left);
            int y = LeafNodeCountRecursive(node.right);

            if (node.left == null && node.right == null)
                return x + y + 1;
            else
                return x + y;

        }
    }
}
