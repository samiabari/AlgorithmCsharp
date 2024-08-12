using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTree
{
    public class Tree<T>
    {
        public TreeNode<T> Root { set; get; } 
        public Tree(T rootData) 
        {
            this.Root = new TreeNode<T>(rootData);
        }


        public void PreOrderTraverse(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            foreach (var child in node.Children)
            {
                PreOrderTraverse(child);
            }
        }

        public void PostOrderTraverse(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            
            foreach (var child in node.Children)
            {
                PostOrderTraverse(child);
            }
            Console.WriteLine(node.Data);

        }

    }
}
