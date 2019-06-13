using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bedrock_CSharp
{
    public partial class BedRock : Form
    {

        //  _____ _       _           _  __      __        _       _     _           
        // / ____| |     | |         | | \ \    / /       (_)     | |   | |          
        //| |  __| | ___ | |__   __ _| |  \ \  / /_ _ _ __ _  __ _| |__ | | ___  ___ 
        //| | |_ | |/ _ \| '_ \ / _` | |   \ \/ / _` | '__| |/ _` | '_ \| |/ _ \/ __|
        //| |__| | | (_) | |_) | (_| | |    \  / (_| | |  | | (_| | |_) | |  __/\__ \
        // \_____|_|\___/|_.__/ \__,_|_|     \/ \__,_|_|  |_|\__,_|_.__/|_|\___||___/
        //                                                                    
                                                                            
        static DirectoryInfo rootDirectoryPath = new DirectoryInfo(@"C:\Users\username\Desktop\testDir\");
        public static String currentDirectory;
        static Point contextMenu1Location;
        static Point contextMenu2Location;

        //TODO:this needs to be a ArrayList implementation for easier management
        //static string[] selectedThumbnails = new string[2];
        static ArrayList selectedThumbnails = new ArrayList();

        ///////////////////////////////////////////////////////////////////////////////////////////////////

        public BedRock()
        {
            InitializeComponent();
            ListDirectory(treeViewFiles, GetRootDirectoryPath());
        }

        public void DisplayImageButton(Image newImage, String fileName, String filePath)
        {
            PictureBox thumbnail = new PictureBox();
            thumbnail.Name = fileName;
            thumbnail.Size = new System.Drawing.Size(newImage.Width, newImage.Height);
            thumbnail.Image = newImage;
            thumbnail.Tag = filePath;
            thumbnail.MouseClick += new MouseEventHandler(thumbnail_Click);
            thumbnail.MouseDoubleClick += new MouseEventHandler(thumbnail_DoubleClick);
            flowLayoutPanel1.Controls.Add(thumbnail);
        }

        private void thumbnail_Click(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p != null && e.Button.ToString().ToUpper() == "LEFT")
            {
                if (selectedThumbnails.Contains(p.Tag.ToString()))
                {
                    //p.BorderStyle = BorderStyle.None;
                    selectedThumbnails.Remove(p.Tag.ToString());
                    //MessageBox.Show("removed a file, count is: " + selectedThumbnails.Count.ToString());
                    p.Paint += new PaintEventHandler(thumbnail_Paint);
                }
                else
                {
                    //p.BorderStyle = BorderStyle.Fixed3D;
                    selectedThumbnails.Add(p.Tag.ToString());
                    //MessageBox.Show("added a file, count is: " + selectedThumbnails.Count.ToString());
                    p.Paint += new PaintEventHandler(thumbnail_Paint);
                }
                p.Refresh();
                selectedCounterLbl.Text = selectedThumbnails.Count.ToString() + " Files Selected";
            }
            if (e.Button.ToString().ToUpper() == "RIGHT")
            {
                contextMenu2Location.X = p.Location.X;
                contextMenu2Location.Y = p.Location.Y;
                contextMenuStrip2.Show(p, new Point(e.X, e.Y));
            }
        }

        //This method is a mess
        private void thumbnail_DoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            //MessageBox.Show("Double clicked an image");
            ShowImage(p);

        }

        private void thumbnail_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            var borderWidth = 4;
            var borderColor = Color.Purple;
            if (selectedThumbnails.Contains(p.Tag.ToString()))
            {
                ControlPaint.DrawBorder(e.Graphics, 
                                        p.ClientRectangle, 
                                        borderColor, borderWidth, ButtonBorderStyle.Solid, 
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid,
                                        borderColor, borderWidth, ButtonBorderStyle.Solid);
            }
            else
            {
                ControlPaint.DrawBorder(e.Graphics, p.ClientRectangle, Color.Red, ButtonBorderStyle.None);
            }
        }

        public void ListDirectory(TreeView treeView, String path)
        {
            treeViewFiles.Nodes.Clear();
            var rootDirectory = new DirectoryInfo(path);

            treeViewFiles.Nodes.Add(CreateDirectoryNode(rootDirectory));
        }

        public static TreeNode CreateDirectoryNode(DirectoryInfo directory)
        {
            var directoryNode = new TreeNode(directory.Name);
            foreach (var dir in directory.GetDirectories())
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(dir));
                directoryNode.Name = dir.Name;
                MessageBox.Show("Name is: " + directoryNode.Name);
            }
            foreach (var file in directory.GetFiles())
            {
                directoryNode.Nodes.Add(new TreeNode(file.Name));
            }

            return directoryNode;
            
        }




        // _________        __      ___                  _    _                 _ _               
        //|__    ___|       \ \    / (_)                | |  | |               | | |              
        //    | |_ __ ___  __\ \  / / _  _____      __  | |__| | __ _ _ __   __| | | ___ _ __ ___ 
        //    | | '__/ _ \/ _ \ \/ / | |/ _ \ \ /\ / /  |  __  |/ _` | '_ \ / _` | |/ _ \ '__/ __|
        //    | | | |  __/  __/\  /  | |  __/\ V V  /   | |  | | (_| | | | | (_| | |  __/ |  \__ \
        //    |_|_|  \___|\___| \/   |_|\___| \_/\_/    |_|  |_|\__,_|_| |_|\__,_|_|\___|_|  |___/
        //                                                                                
                                                                                        
        private void treeViewFiles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            totalCounterLbl.Text = "";
            flowLayoutPanel1.Controls.Clear();
            treeViewFiles.SelectedNode = e.Node;
            //MessageBox.Show(e.Node.FullPath + "%%%%%%%%%");

            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\username\Desktop\" + e.Node.FullPath);
            if (directory.Extension == "" && directory.Name != "testDir")
            {
                selectedThumbnails.Clear();
                FileInfo[] files = directory.GetFiles();
                currentDirectory = @"C:\Users\username\Desktop\" + e.Node.FullPath;
                totalCounterLbl.Text = files.Length.ToString() + " Files in Folder";
                ResizeImages(files);
            }
            else
            {
                //MessageBox.Show(directory.Name);
            }
        }

        private void treeViewFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString().ToUpper() == "RIGHT")
            {
                TreeNode selectedNode = treeViewFiles.GetNodeAt(e.X, e.Y);
                if (selectedNode != null)
                {
                    //MessageBox.Show(selectedNode.Text);
                    selectedNode.BackColor = Color.LightBlue;
                    selectedNode.ForeColor = Color.White;
                    contextMenuStrip1.Show(treeViewFiles, new Point(e.X, e.Y));
                }
            }
        }

        private void treeViewFiles_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString().ToUpper() == "RIGHT")
            {
                TreeNode selectedNode = treeViewFiles.GetNodeAt(e.X, e.Y);
                if (selectedNode != null)
                {
                    contextMenu1Location.X = e.X;
                    contextMenu1Location.Y = e.Y;
                    selectedNode.BackColor = Color.White;
                    selectedNode.ForeColor = Color.Black;
                }                                
            }
        }




        //  _____             _            _                           __     _    _                 _ _
        // / ____|           | |          | |  _    _                 /_ |   | |  | |               | | |              
        //| |     ___ _ __   | |______  _ | |_| \  / | ___ _ __  _   _ | |   | |__| | __ _ _ __    _| | | ___ _ __ ___ 
        //| |    / _ \| '_ \| __/ _ \ \/ / ___| |\/| |/ _ \ '_ \| | | || |   |  __  |/ _` | '_ \ / _` | |/ _ \ '__/ __|
        //| |___| (_) | | | | ||  __/>  <| |_ | |  | |  __/ | | | |_| || |   | |  | | (_| | | | | (_| | |  __/ |  \__ \
        // \_____\___/|_| |_|\__\___/_/\_\\__||_|  |_|\___|_| |_|\__,_||_|   |_|  |_|\__,_|_| |_|\__,_|_|\___|_|  |___/
        //

        //INCOMPLETE (working)
        private void newFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeViewFiles.GetNodeAt(contextMenu1Location.X, contextMenu1Location.Y);
            FolderNameForm newFolderDialog = new FolderNameForm(selectedNode, "create");
            newFolderDialog.ShowDialog();
            ListDirectory(treeViewFiles, GetRootDirectoryPath());

            //TODO: check for empty string
        }

        //INCOMPLETE (working)
        private void renameFolderToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            TreeNode selectedNode = treeViewFiles.GetNodeAt(contextMenu1Location.X, contextMenu1Location.Y);
            FolderNameForm renameDialog = new FolderNameForm(selectedNode, "rename");
            renameDialog.ShowDialog();
            ListDirectory(treeViewFiles, GetRootDirectoryPath());

            //TODO: check for empty string.
        }

        //TODO
        private void deleteFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //TODO
        private void addFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }




        //  _____             _            _                           _ _      _    _                 _ _
        // / ____|           | |          | |  _    _                 |__ \    | |  | |               | | |              
        //| |     ___ _ __   | |______  _ | |_| \  / | ___ _ __  _   _   ) |   | |__| | __ _ _ __    _| | | ___ _ __ ___ 
        //| |    / _ \| '_ \| __/ _ \ \/ / ___| |\/| |/ _ \ '_ \| | | | / /    |  __  |/ _` | '_ \ / _` | |/ _ \ '__/ __|
        //| |___| (_) | | | | ||  __/>  <| |_ | |  | |  __/ | | | |_| |/ /_    | |  | | (_| | | | | (_| | |  __/ |  \__ \
        // \_____\___/|_| |_|\__\___/_/\_\\__||_|  |_|\___|_| |_|\__,_|____|   |_|  |_|\__,_|_| |_|\__,_|_|\___|_|  |___/
        //
        
        private void openFileToolStripMenuItem_Click(object sender, MouseEventArgs e)
        {
            var picBox = flowLayoutPanel1.GetChildAtPoint(new Point(contextMenu2Location.X, contextMenu2Location.Y));

            if (picBox != null)
            {
                ShowImage(picBox);
            }
        }

        //TODO
        private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open the windows explorer location of the selected file.
        }

        //TODO
        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //deletes the selected file(s).
        }

        //TODO
        private void addTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //adds tags to the selected file(s).
            if (selectedThumbnails.Count != 0)
            {
                for (int i = 0; i < selectedThumbnails.Count; i++)
                {
                    String path = selectedThumbnails[i].ToString();

                    MessageBox.Show(path);
                    //MessageBox.Show(name);
                }
                FileTagForm tagDialog = new FileTagForm();
                tagDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("No files selected");
            }
        }

        //TODO
        private void removeTagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //removes tags from the selecetd file(s).
        }

        //TODO
        private void addToFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Add/Move selected file(s) to a specified folder.
        }




        // _    _      _                    __  __      _   _               _     
        //| |  | |    | |                  |  \/  |    | | | |             | |    
        //| |__| | ___| |_ __   ___ _ __   | \  / | ___| |_| |__   ___   __| |___ 
        //|  __  |/ _ \ | '_ \ / _ \ '__|  | |\/| |/ _ \ __| '_ \ / _ \ / _` / __|
        //| |  | |  __/ | |_) |  __/ |     | |  | |  __/ |_| | | | (_) | (_| \__ \
        //|_|  |_|\___|_| .__/ \___|_|     |_|  |_|\___|\__|_| |_|\___/ \__,_|___/
        //              | |                                                       
        //              |_|     

        //Image Resizing Methods
        private void ResizeImages(FileInfo[] files)
        {
            foreach (FileInfo file in files)
            {//can use PictureBox instead of Button.
                Image img = Image.FromFile(file.FullName);
                var newImage = ScaleImage(img, 240, 240);
                String filePath = file.FullName;
                String fileName = file.Name;
                img.Dispose();

                DisplayImageButton(newImage, fileName, filePath);
            }
        }

        public static Image ScaleImage(Image img, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / img.Width;
            var ratioY = (double)maxHeight / img.Height;

            //Scale width or height to max size (240px)
            var ratio = Math.Min(ratioX, ratioY);

            //Scale to fit Height only.
            //var ratio = ratioY;

            //Scale to fit width only.
            //var ratio = ratioX;

            var newWidth = (int)(img.Width * ratio);
            var newHeight = (int)(img.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);
            Graphics.FromImage(newImage).DrawImage(img, 0, 0, newWidth, newHeight);

            return newImage;
        }

        public void ShowImage(Control picBox)
        {
            String key = picBox.Tag.ToString();
            //MessageBox.Show("clicked button number: " + key);
            var form = new displayImageForm();
            PictureBox fullImage = new PictureBox();
            fullImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            Image img = Image.FromFile(key);
            Image imgFit = ScaleImage(img, form.Width, form.Height);
            img.Dispose();

            if (form.Height > imgFit.Height)
            {
                form.Height = imgFit.Height;
            }
            if (form.Width > imgFit.Width)
            {
                form.Width = imgFit.Width;
            }

            fullImage.Height = imgFit.Height;
            fullImage.Width = imgFit.Width;

            fullImage.Image = imgFit;
            form.Controls.Add(fullImage);

            form.ShowDialog(this);
        }

        public static String GetRootDirectoryPath()
        {
            String path = rootDirectoryPath.ToString();
            return path;
        }

        private void SetRootDirectoryPath()
        {
            rootDirectoryPath = new DirectoryInfo(@"C:\Users\username\Desktop\testDir\");
        }

    }
}
