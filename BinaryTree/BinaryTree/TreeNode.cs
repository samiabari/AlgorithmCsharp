using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class TreeNode<T>
    {
        public T Data { set; get; }
        public TreeNode<T> Left { set; get; }
        public TreeNode<T> Right { set; get; }

        public TreeNode(T data)
        {
            this.Data = data;
            this.Left = null;
            this.Right = null;
        }


    }
}
