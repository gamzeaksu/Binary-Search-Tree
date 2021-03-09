using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapıları_Ödev_7
{
    class bstNode
    {
        public int data;
        public bstNode leftNode;
        public bstNode rightNode;
        public bstNode(int data,bstNode left,bstNode right)
        {
            this.data = data;
            leftNode = left;
            rightNode = right;
        }
    }
}
