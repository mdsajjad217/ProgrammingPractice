using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericTree
{
    public class TreeNode
    {
        public TreeNode()
        {
            children = new List<TreeNode>();
        }

        public int data;
        public List<TreeNode> children;
    }
}