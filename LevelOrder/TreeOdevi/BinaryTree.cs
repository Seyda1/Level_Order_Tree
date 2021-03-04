using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TreeOdevi
{
    class queueNode
    {
        public queueNode next;
        public Bst Node;
        public queueNode(Bst Node)
        {
            this.Node = Node;
        }

    }
    class Bst
    {
        public int sayi;
        public Bst left, right;
        public Bst(int sayi, Bst left, Bst right)
        {
            this.sayi = sayi;
            this.left = left;
            this.right = right;
        }
    }
    class BinaryTree
    {

        public Bst Node = new Bst(0, null, null);
      
        public int FindMax()
        {
            Bst current = Node;
            while (current.right != null)
            {
                current = current.right;
            }
            return current.sayi;
        }
        public int FindMin()
        {
            Bst current = Node;
            while (current.left != null)
            {
                current = current.left;
            }
            return current.sayi;

        }
        public void AddTree(TextBox Ekletxt)
        {
            Bst yeninode = new Bst(Convert.ToInt32(Ekletxt.Text), null, null);
            if (Node.sayi == 0)
            { Node.sayi = Convert.ToInt32(Ekletxt.Text); }
            else
            {
                Bst current = Node;
                Bst parent;
                while (true)
                {
                    parent = current;
                    if (yeninode.sayi < current.sayi)
                    {
                        current = current.left;
                        if (current == null)//nul gösterene kadar bak en sona ekle
                        {
                            parent.left = yeninode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = yeninode;
                            break;
                        }
                    }
                }
            }
        }
        public void Bosalt(Bst Node)
        {
            if (Node.left != null)//has a children
            {
                Bosalt(Node.left);
            }

            if (Node.right != null)
            {
                Bosalt(Node.right);
            }
            Node.left = null;
            Node.right = null;
            Node.sayi = 0;//sıfırlamazzsam ilk değeri tutyor
        }
     
        public void LevelOrder(ListBox levellst)
        {
            Queue<Bst> queue = new Queue<Bst>();

            queue.Enqueue(Node);//ilkini queue attım
            while (queue.Count != 0)
            {
                Bst tempNode = queue.Dequeue();//queueden çıkanı elimde tutuyorum left ve right a ulaşmak için
                levellst.Items.Add(tempNode.sayi);//her çıkanın child larını ekliyoruz
                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }
                if (tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }

            }
        }
    }
}
