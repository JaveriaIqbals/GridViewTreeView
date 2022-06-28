using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingEx
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Add("Class Room : Math");
            this.treeView1.Nodes[0].Nodes.Add("abc");
            this.treeView1.Nodes[0].Nodes[0].Nodes.Add("age : 20");
            this.treeView1.Nodes[0].Nodes[0].Nodes.Add("SSN : 123");
            this.treeView1.Nodes[0].Nodes[0].Nodes.Add("Address : CA");

            this.treeView1.Nodes[0].Nodes.Add("def");
            this.treeView1.Nodes[0].Nodes.Add("ghi");

            this.treeView1.Nodes.Add("Class Room : Arts");
            this.treeView1.Nodes.Add("Class Room : Social Studies");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.treeView1.SelectedNode.Remove();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            TreeNode tNode = new TreeNode(this.textBox1.Text);
            if (this.treeView1.SelectedNode != null)
            {
               this.treeView1.SelectedNode.Nodes.Add(tNode);
            }
            else
                treeView1.Nodes.Add(tNode);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
