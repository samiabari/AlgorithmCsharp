namespace BasicTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree<string> tree = new Tree<string>("Root Node");
           

            // Create child nodes
            TreeNode<string> child1 = new TreeNode<string>("Child 1");
            TreeNode<string> child2 = new TreeNode<string>("Child 2");
            TreeNode<string> child3 = new TreeNode<string>("Child 3");
            child2.AddChild(child3);
            tree.Root.Children.Add(child1);
            tree.Root.Children.Add(child2);
            tree.PreOrderTraverse(tree.Root);
            tree.PostOrderTraverse(tree.Root);
        }
    }
}
