using System.Drawing;
using System.Windows.Forms;

namespace Bedrock_CSharp
{
    partial class BedRock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabNavigator = new System.Windows.Forms.TabControl();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.treeViewFiles = new System.Windows.Forms.TreeView();
            this.tabTags = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedCounterLbl = new System.Windows.Forms.Label();
            this.totalCounterLbl = new System.Windows.Forms.Label();
            this.tabNavigator.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(262, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(948, 649);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabNavigator
            // 
            this.tabNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabNavigator.Controls.Add(this.tabFiles);
            this.tabNavigator.Controls.Add(this.tabTags);
            this.tabNavigator.Location = new System.Drawing.Point(0, 25);
            this.tabNavigator.Name = "tabNavigator";
            this.tabNavigator.SelectedIndex = 0;
            this.tabNavigator.Size = new System.Drawing.Size(246, 208);
            this.tabNavigator.TabIndex = 1;
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.treeViewFiles);
            this.tabFiles.Location = new System.Drawing.Point(4, 22);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiles.Size = new System.Drawing.Size(238, 182);
            this.tabFiles.TabIndex = 0;
            this.tabFiles.Text = "Files";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // treeViewFiles
            // 
            this.treeViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewFiles.BackColor = System.Drawing.Color.DimGray;
            this.treeViewFiles.Location = new System.Drawing.Point(0, 0);
            this.treeViewFiles.Name = "treeViewFiles";
            this.treeViewFiles.Size = new System.Drawing.Size(238, 191);
            this.treeViewFiles.TabIndex = 0;
            this.treeViewFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFiles_AfterSelect);
            this.treeViewFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeViewFiles_MouseDown);
            this.treeViewFiles.MouseUp += new System.Windows.Forms.MouseEventHandler(this.treeViewFiles_MouseUp);
            // 
            // tabTags
            // 
            this.tabTags.Location = new System.Drawing.Point(4, 22);
            this.tabTags.Name = "tabTags";
            this.tabTags.Padding = new System.Windows.Forms.Padding(3);
            this.tabTags.Size = new System.Drawing.Size(238, 643);
            this.tabTags.TabIndex = 1;
            this.tabTags.Text = "Tags";
            this.tabTags.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.renameFolderToolStripMenuItem,
            this.deleteFolderToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addFilesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 98);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newFolderToolStripMenuItem.Text = "New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // renameFolderToolStripMenuItem
            // 
            this.renameFolderToolStripMenuItem.Name = "renameFolderToolStripMenuItem";
            this.renameFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.renameFolderToolStripMenuItem.Text = "Rename Folder";
            this.renameFolderToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.renameFolderToolStripMenuItem_Click);
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteFolderToolStripMenuItem.Text = "Delete Folder";
            this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.deleteFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // addFilesToolStripMenuItem
            // 
            this.addFilesToolStripMenuItem.Name = "addFilesToolStripMenuItem";
            this.addFilesToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addFilesToolStripMenuItem.Text = "Add Files";
            this.addFilesToolStripMenuItem.Click += new System.EventHandler(this.addFilesToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTagsToolStripMenuItem,
            this.removeTagsToolStripMenuItem,
            this.addToFolderToolStripMenuItem,
            this.toolStripMenuItem2,
            this.openFileToolStripMenuItem,
            this.openFileLocationToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deleteFileToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(174, 148);
            // 
            // addTagsToolStripMenuItem
            // 
            this.addTagsToolStripMenuItem.Name = "addTagsToolStripMenuItem";
            this.addTagsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addTagsToolStripMenuItem.Text = "Add Tag(s)";
            this.addTagsToolStripMenuItem.Click += new System.EventHandler(this.addTagsToolStripMenuItem_Click);
            // 
            // removeTagsToolStripMenuItem
            // 
            this.removeTagsToolStripMenuItem.Name = "removeTagsToolStripMenuItem";
            this.removeTagsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.removeTagsToolStripMenuItem.Text = "Remove Tag(s)";
            this.removeTagsToolStripMenuItem.Click += new System.EventHandler(this.removeTagsToolStripMenuItem_Click);
            // 
            // addToFolderToolStripMenuItem
            // 
            this.addToFolderToolStripMenuItem.Name = "addToFolderToolStripMenuItem";
            this.addToFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.addToFolderToolStripMenuItem.Text = "Add to Folder";
            this.addToFolderToolStripMenuItem.Click += new System.EventHandler(this.addToFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileLocationToolStripMenuItem
            // 
            this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
            this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openFileLocationToolStripMenuItem.Text = "Open File Location";
            this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(170, 6);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete File";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // selectedCounterLbl
            // 
            this.selectedCounterLbl.AutoSize = true;
            this.selectedCounterLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.selectedCounterLbl.Location = new System.Drawing.Point(262, 6);
            this.selectedCounterLbl.Name = "selectedCounterLbl";
            this.selectedCounterLbl.Size = new System.Drawing.Size(82, 13);
            this.selectedCounterLbl.TabIndex = 2;
            this.selectedCounterLbl.Text = "0 Files Selected";
            // 
            // totalCounterLbl
            // 
            this.totalCounterLbl.AutoSize = true;
            this.totalCounterLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.totalCounterLbl.Location = new System.Drawing.Point(351, 5);
            this.totalCounterLbl.Name = "totalCounterLbl";
            this.totalCounterLbl.Size = new System.Drawing.Size(80, 13);
            this.totalCounterLbl.TabIndex = 3;
            this.totalCounterLbl.Text = "0 Files in Folder";
            // 
            // BedRock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1210, 673);
            this.Controls.Add(this.totalCounterLbl);
            this.Controls.Add(this.selectedCounterLbl);
            this.Controls.Add(this.tabNavigator);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "BedRock";
            this.Text = "Form1";
            this.tabNavigator.ResumeLayout(false);
            this.tabFiles.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabNavigator;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.TabPage tabTags;
        private System.Windows.Forms.TreeView treeViewFiles;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem newFolderToolStripMenuItem;
        private ToolStripMenuItem renameFolderToolStripMenuItem;
        private ToolStripMenuItem deleteFolderToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem addFilesToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem addTagsToolStripMenuItem;
        private ToolStripMenuItem removeTagsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem openFileLocationToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem deleteFileToolStripMenuItem;
        private ToolStripMenuItem addToFolderToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label selectedCounterLbl;
        private Label totalCounterLbl;
    }
}

