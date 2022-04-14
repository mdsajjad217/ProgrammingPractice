using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingSolutions
{
    public class TreeNode
    {
        public int? value;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int?[] values) : this(values, 0) { }

        public TreeNode(int? value)
        {
            this.value = value;
            this.left = null;
            this.right = null;
        }

        TreeNode(int?[] values, int index)
        {
            Load(this, values, index);
        }

        void Load(TreeNode tree, int?[] values, int index)
        {
            this.value = values[index];
            if (index * 2 + 1 < values.Length)
            {
                this.left = this.value != null ? new TreeNode(values, index * 2 + 1) : null;
            }
            if (index * 2 + 2 < values.Length)
            {
                this.right = this.value != null ? new TreeNode(values, index * 2 + 2) : null;
            }
        }
    }
}
