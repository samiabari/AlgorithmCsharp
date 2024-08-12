namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode<string> root = new TreeNode<string>("Samia");
           
            Tree<string> t = new Tree<string>(root);
            t.InsertLeft(root, "Lefti");
            t.InsertRight(root, "righti");

            t.LevelOrder(t.Root);
        }
    }
}
