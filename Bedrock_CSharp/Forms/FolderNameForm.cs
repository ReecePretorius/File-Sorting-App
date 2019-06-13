using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedrock_CSharp
{
    public partial class FolderNameForm : Form
    {
        private TreeNode node;
        private string task;

        public FolderNameForm(TreeNode selectedNode, string Task)
        {
            InitializeComponent();
            node = selectedNode;
            task = Task;
            //MessageBox.Show("path is: " + node.FullPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {//Ok Button
            String newName = textBox1.Text;

            if (task == "create")
            {
                MessageBox.Show(node.FullPath + "<--path");
                FolderController.CreateNewFolder(node, newName);
            }
            else if (task == "rename")
            {
                FolderController.RenameFolder(node, newName);
            }
            this.Dispose();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//Cancel Button
            this.Dispose();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
