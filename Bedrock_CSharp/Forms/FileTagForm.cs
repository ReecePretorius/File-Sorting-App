using Bedrock_CSharp.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bedrock_CSharp
{
    public partial class FileTagForm : Form
    {
        static string tagFilePath = @"C:\Users\username\source\repos\BedRock_cSharp\Bedrock_CSharp\Data\TagList.txt";
        string[] tagList = File.ReadAllLines(tagFilePath);
        static ArrayList selectedTags = new ArrayList();

        public FileTagForm()
        {
            InitializeComponent();
        }

        private void FileTagForm_Load(object sender, EventArgs e)
        {
            displayTags(tagList);
            ListDirectory(treeView1, BedRock.GetRootDirectoryPath());
            displayFolders();
        }

        private void FileTagForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            selectedTags.Clear();
        }

        public void ListDirectory(TreeView treeView, String path)
        {
            treeView1.Nodes.Clear();
            var rootDirectory = new DirectoryInfo(path);

            treeView1.Nodes.Add(BedRock.CreateDirectoryNode(rootDirectory));
        }

        private void displayFolders()
        {
            //TODO: on form load we want to display all the folders created.
        }

        private void displayTags(String[] list)
        {
            TagListLayoutPanel.Controls.Clear();
            //string[] list = File.ReadAllLines(tagFilePath);
            //MessageBox.Show(list[0]);

            for (int i = 0; i < list.Length; i++)
            {
                PictureBox pBox = new PictureBox();
                var image = new Bitmap(pBox.Width, pBox.Height);
                var font = new Font("Arial", 16, FontStyle.Bold, GraphicsUnit.Pixel);

                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                var graphics = Graphics.FromImage(image);
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
                graphics.DrawString(list[i], font, Brushes.White, pBox.DisplayRectangle, sf);

                //PictureBox pBox properties
                pBox.Image = image;
                pBox.Tag = list[i];
                if (selectedTags.Contains(pBox.Tag.ToString()))
                {
                    pBox.BackColor = Color.MediumPurple;
                }
                else
                {
                    pBox.BackColor = Color.DarkGray;
                }
                pBox.MouseEnter += new EventHandler(tag_MouseEnter);
                pBox.MouseLeave += new EventHandler(tag_MouseLeave);
                pBox.MouseClick += new MouseEventHandler(tag_Click);
                TagListLayoutPanel.Controls.Add(pBox);

                //Disposing
                graphics.Dispose();
                font.Dispose();
            }
        }

        private void tag_MouseEnter(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            p.BackColor = Color.Purple;
        }

        private void tag_MouseLeave(object sender, EventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (!selectedTags.Contains(p.Tag.ToString()))
            {
                p.BackColor = Color.DarkGray;
            }
            else
            {
                p.BackColor = Color.MediumPurple;
            }
        }

        private void tag_Click(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            //MessageBox.Show(p.Tag.ToString());
            if (e.Button.ToString().ToUpper() == "LEFT")
            {
                if (!selectedTags.Contains(p.Tag.ToString()))
                {
                    selectedTags.Add(p.Tag.ToString());
                    TagStringComplete.Text += p.Tag.ToString();
                    p.BackColor = Color.MediumPurple;
                }
                else
                {
                    selectedTags.Remove(p.Tag.ToString());
                    //p.BackColor = Color.Purple;
                }
            }
            else if (e.Button.ToString().ToUpper() == "RIGHT")
            {
                MessageBox.Show("Right clicked a tag");
            }
            
            
            
        }

        private void AddTagButton_Click(object sender, EventArgs e)
        {
            if (FolderController.checkForInvalidChars(AddTagTextBox.Text) == false && AddTagTextBox.Text.Length > 0)
            {
                Boolean contains = false;
                for (int i = 0; i < tagList.Length; i++)
                {
                    if (tagList[i].ToLower().Equals(AddTagTextBox.Text.ToLower()))
                    {
                        MessageBox.Show("Tag list already contains the tag: " + AddTagTextBox.Text);
                        contains = true;
                    }
                }
                if (contains == false)
                {
                    //Add the tag to the tagList.txt file.
                    File.AppendAllText(tagFilePath, AddTagTextBox.Text + "\n");
                    tagList = File.ReadAllLines(tagFilePath);
                    displayTags(tagList);
                }
            }
            else
            {
                MessageBox.Show("Tag is empty or contains invalid characters");
            }
        }

        private void SortByNameButton_Click(object sender, EventArgs e)
        {
            Array.Sort(tagList);
            displayTags(tagList);
        }

        private void SortByDateButton_Click(object sender, EventArgs e)
        {
            displayTags(File.ReadAllLines(tagFilePath));
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            selectedTags.Clear();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            selectedTags.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BedRock.currentDirectory);
            String genName = FileController.GenerateFileName(BedRock.currentDirectory);
            NameStringComplete.Text = genName;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
