using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    internal class MyMapNode
    {
        internal int data;
        internal MyMapNode leftNode;
        internal MyMapNode rightNode;
        public MyMapNode(int data)
        {
            this.data = data;
            leftNode = null;
            rightNode = null;
        }
        public void Insert(int data)
        {
            int rootData = this.data;
            if (data >= rootData)
            {
                if (rightNode == null)
                {
                    rightNode = new MyMapNode(data);
                }
                else
                {
                    rightNode.Insert(data);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new MyMapNode(data);
                }
                else
                {
                    leftNode.Insert(data);
                }
            }
        }
        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }
            Console.Write(data + "\n");
            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }
    }
}
