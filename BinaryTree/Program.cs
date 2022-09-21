namespace BinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySerchTree<int> binarySearchTree = new BinarySerchTree<int>();
            binarySearchTree.InsertData(56);
            binarySearchTree.InsertData(30);
            binarySearchTree.InsertData(70);
            binarySearchTree.Display(binarySearchTree.GetRoot());
        }
    }
}