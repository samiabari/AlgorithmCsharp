using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTree
{
    public class TreeNode<T>
    {
     

        public T Data { set; get; }
        public List<TreeNode<T>> Children {  set; get; }

        public TreeNode(T data)
        {
            this.Data= data;
            this.Children = new List<TreeNode<T>>();
        }

        public bool AddChild(TreeNode<T> child)
        {
            Children.Add(child);
            return true;
        }

    }
}
