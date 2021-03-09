using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeriYapıları_Ödev_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bstNode rootNode = new bstNode(0, null, null);
        void preOrder(bstNode node)
        {
            listBox1.Items.Add(node.data);
          
            if (node.leftNode != null)
            {
                preOrder(node.leftNode);
            }
            if (node.rightNode != null)
            {
                preOrder(node.rightNode);
            }
        }

        void postOrder(bstNode node)
        {
            if (node.leftNode != null)
            {
                preOrder(node.leftNode);
            }
            if (node.rightNode != null)
            {
                preOrder(node.rightNode);
            }
            listBox1.Items.Add(node.data);
        }

        void inOrder(bstNode node)
        {
            if (node.leftNode != null)
            {
                preOrder(node.leftNode);
            }

            listBox1.Items.Add(node.data);
            if (node.rightNode != null)
            {
                preOrder(node.rightNode);
            }
        }
        void levelOrder()
        {
            Queue<bstNode> queue = new Queue<bstNode>();
            queue.Enqueue(rootNode);
            while (queue.Count != 0)
            {
                bstNode tempNode = queue.Dequeue();
                listBox1.Items.Add(tempNode.data);
             
                if (tempNode.leftNode != null)
                {
                    queue.Enqueue(tempNode.leftNode);
                }
                if (tempNode.rightNode != null)
                {
                    queue.Enqueue(tempNode.rightNode);
                }
            }

        }  
       
        void bul(int sayi, bstNode node)
        {
            if (node.data == 0)
            {
                txtSonuc.Text = "Ağaç boş";
            }
            else if ((sayi < node.data) && (node.leftNode != null))
            {
                bul(sayi, node.leftNode);

            }
            else if ((sayi > node.data) && (node.rightNode != null))
            {
                bul(sayi, node.rightNode);
            }
            else if (sayi == node.data)
            {
                Sonuc(node);
            }
            else
            {
                txtSonuc.Text = "Sayı yok";
            }
        }

        void Sonuc(bstNode node)
        {
            txtSonuc.Text = "Sayı bulundu";

            if (node.leftNode == null)
                txtSonuc.Text += "\nLeft child yok";
            else
                txtSonuc.Text += "\nLeft child: " + node.leftNode.data;

            if (node.rightNode == null)
                txtSonuc.Text += "\nRight child yok";
            else
                txtSonuc.Text += "\nRight child: " + node.rightNode.data;

            listBox1.Items.Clear();
            preOrder(rootNode);
            txtSonuc.Text += "\nPre-Order Sırası: "+listBox1.Items.IndexOf(node.data);  
            listBox1.Items.Clear();
            inOrder(rootNode);
            txtSonuc.Text += "\nIn-Order Sırası: " + listBox1.Items.IndexOf(node.data);
            listBox1.Items.Clear();
            postOrder(rootNode);
            txtSonuc.Text += "\nPost-Order Sırası: " + listBox1.Items.IndexOf(node.data);
            listBox1.Items.Clear();
            levelOrder();
            txtSonuc.Text += "\nLevel-Order Sırası: " + listBox1.Items.IndexOf(node.data);
            //listBox1.Items.Clear();
        }
        private void ekle(int sayi, bstNode node)
        {
            listBox1.Items.Add(sayi);
            bstNode yeniNode = new bstNode(sayi, null, null);
            if (node.data == 0)
            {
                node.data = sayi;
            }
            else
            {
                bstNode aktif = node;
                bstNode parent;
                while (true)
                {
                    parent = aktif;
                    if (sayi < aktif.data)
                    {
                        aktif = aktif.leftNode;
                        if (aktif == null)
                        {
                            parent.leftNode = yeniNode;
                            break;
                        }
                    }
                    else
                    {
                        aktif = aktif.rightNode;
                        if (aktif == null)
                        {
                            parent.rightNode = yeniNode;
                            return;
                        }
                    }
                }
            }
        }
        int max(bstNode node)
        {
           
            while(node.rightNode !=null)
            {
                node = node.rightNode;
            }
            return node.data;
        }
        int min(bstNode node )
        {
           
            while(node.leftNode!=null)
            {
                node = node.leftNode;
            }
            return node.data;
        }
        bstNode deleteNode(bstNode node, int x)
        {
            if (node == null)
            {
                txtSonuc.Text = "Sayı ağaçta yok";
                return null;
            }
            if (x == node.data)
            {
                if (node.leftNode == null && node.rightNode == null)
                {
                    return null;
                }
                if (node.rightNode != null)
                {
                    node.data = min(node.rightNode);
                    node.rightNode = deleteNode(node.rightNode, min(node.rightNode));

                    return node;
                }
                else if (node.leftNode != null)
                {
                    node.data = max(node.leftNode);
                    node.leftNode = deleteNode(node.leftNode, max(node.leftNode));
                    return node;
                }
            }
            if (x > node.data)
            {
                node.rightNode = deleteNode(node.rightNode, x);
                return node;
            }
            node.leftNode = deleteNode(node.leftNode, x);
            return node;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnPre_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            preOrder(rootNode);
        }

        private void BtnIn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            inOrder(rootNode);
        }

        private void BtnPost_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            postOrder(rootNode);
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            bul(Convert.ToInt16(txtBul.Text), rootNode);
            txtBul.Text = "";
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            ekle(Convert.ToInt16(txtEkle.Text), rootNode);
            txtEkle.Text = "";
            
        }

        private void BtnLevel_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            levelOrder();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            rootNode=deleteNode(rootNode, Convert.ToInt16(txtSil.Text));
            txtSil.Text = "";
        }

  
    }
}

