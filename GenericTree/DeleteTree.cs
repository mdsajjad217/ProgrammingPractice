using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericTree
{
    public static class DeleteTree
    {
        public static void TreeDelete(TreeNode root)
        {
            if (root.children != null)
            {
                foreach (TreeNode child in root.children)
                {
                    TreeDelete(child);
                }
            }

            root = null;
        }
    }
}