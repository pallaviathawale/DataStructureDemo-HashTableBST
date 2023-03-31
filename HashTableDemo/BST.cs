using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    internal class BST
    {
        MyMapNode root;
        int treeSize = 0;
        public void Insert(int data)
        {
            if (root == null)
            {
                root = new MyMapNode(data);
                treeSize++;
            }
            else
            {
                root.Insert(data);
                treeSize++;
            }
        }
        public int Size()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            return treeSize;
        }
        public void Display()
        {
            if (root == null)
            {
                Console.WriteLine("Binary Search Tree is Empty");
            }
            else
            {
                root.InOrderTraversal();
            }
        }
    }
}


