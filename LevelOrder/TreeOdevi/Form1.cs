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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BinaryTree binarytree = new BinaryTree();
        private void button3_Click(object sender, EventArgs e)//Mın butonu,yanlışlıkla açılınca button3 diye kaldı.
        {
            Mıntxt.Text = Convert.ToString(binarytree.FindMin());
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eklebtn_Click(object sender, EventArgs e)
        {
            binarytree.AddTree(Ekletxt);
        }

        private void Maxbtn_Click(object sender, EventArgs e)
        { Maxtxt.Text=Convert.ToString(binarytree.FindMax());
        }
           

        private void Bosaltbtn_Click(object sender, EventArgs e)
        {
            levellist.Items.Clear();
            binarytree.Bosalt(binarytree.Node);
        }

        private void Levelbtn_Click(object sender, EventArgs e)
        {
            binarytree.LevelOrder(levellist);
        }
    }
}
