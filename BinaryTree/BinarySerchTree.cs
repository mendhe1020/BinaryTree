using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinarySerchTree<T> where T : IComparable
    {
        //Variables
        int count = 0;
        bool result = false;
        Node<T> Root;
        Node<T> Current;
        //UC-1 
        public void InsertData(T data)
        {
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                count++;
                return;
            }
            if (this.Current.data.CompareTo(data) > 0)
            {
                if (this.Current.leftNode == null)
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
            }
            else
            {
                if (this.Current.rightNode == null)
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
            }
        }
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        //UC-2 - Gets the Size of Binary Search Tree
        public int GetSize()
        {
            return count;
        }
        //UC-3 - Search Element in Binary Search Tree
        public bool SearchTree(int data, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            else
            {
                if (this.Current.data.Equals(data))
                {
                    result = true;
                }
                else if (this.Current.data.CompareTo(data) > 0)
                {
                    this.Current = this.Current.leftNode;
                    SearchTree(data, Current);
                }
                return result;
            }
        }
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Element in Binary Search Tree is: " + node.data);
                Display(node.rightNode);
            }
        }
    }
}
