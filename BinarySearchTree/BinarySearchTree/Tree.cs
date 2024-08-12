using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree<T> where T : IComparable<T>
    {
        public TreeNode<T> Root { set; get; }
       
        public void Insert(T data)
        {
            this.Root = Insert(Root, data);
        }


        public TreeNode<T> Insert(TreeNode<T> node, T data)
        {
            if (node == null)
            {
                return new TreeNode<T>(data);
            }
            else if (node.Data.CompareTo(data) < 0)
            {
                node.Left = Insert(node.Left, data);
            }
            else if (node.Data.CompareTo(data) > 0)
            {
                node.Right = Insert(node.Right, data);
            }
            return node;
        }

        public void PreOrderTraverse(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            PreOrderTraverse(node.Left);
            PreOrderTraverse(node.Right);
        }

        public void InOrderTraverse(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            InOrderTraverse(node.Left);
            Console.WriteLine(node.Data);
            InOrderTraverse(node.Right);
        }
        public void PostOrderTraverse(TreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }

            PostOrderTraverse(node.Left);
            PostOrderTraverse(node.Right);
            Console.WriteLine(node.Data);
        }


        public void LevelOrder(TreeNode<T> root)
        {
            if (root == null)
                return;

            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Data); // Visit the node

                if (node.Left != null)
                    queue.Enqueue(node.Left); // Add left child to the queue

                if (node.Right != null)
                    queue.Enqueue(node.Right); // Add right child to the queue
            }
        }
    }
}
