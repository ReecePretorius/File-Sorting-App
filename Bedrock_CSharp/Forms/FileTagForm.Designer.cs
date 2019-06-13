namespace Bedrock_CSharp
{
    partial class FileTagForm
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
            this.OkBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TagListLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddTagButton = new System.Windows.Forms.Button();
            this.AddFolderbutton = new System.Windows.Forms.Button();
            this.AddTagTextBox = new System.Windows.Forms.TextBox();
            this.AddFolderTextBox = new System.Windows.Forms.TextBox();
            this.SortByNameButton = new System.Windows.Forms.Button();
            this.SortByDateButton = new System.Windows.Forms.Button();
            this.BGPanelRight = new System.Windows.Forms.Panel();
            this.BGPanelLeft = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TagStringComplete = new System.Windows.Forms.TextBox();
            this.NameStringComplete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BGPanelRight.SuspendLayout();
            this.BGPanelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(760, 550);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(75, 23);
            this.OkBtn.TabIndex = 0;
            this.OkBtn.Text = "Ok";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(841, 550);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TagListLayoutPanel
            // 
            this.TagListLayoutPanel.AutoScroll = true;
            this.TagListLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TagListLayoutPanel.Location = new System.Drawing.Point(253, 61);
            this.TagListLayoutPanel.Name = "TagListLayoutPanel";
            this.TagListLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 4, 0, 20);
            this.TagListLayoutPanel.Size = new System.Drawing.Size(663, 482);
            this.TagListLayoutPanel.TabIndex = 2;
            // 
            // AddTagButton
            // 
            this.AddTagButton.Location = new System.Drawing.Point(576, 10);
            this.AddTagButton.Name = "AddTagButton";
            this.AddTagButton.Size = new System.Drawing.Size(75, 23);
            this.AddTagButton.TabIndex = 0;
            this.AddTagButton.Text = "Add";
            this.AddTagButton.UseVisualStyleBackColor = true;
            this.AddTagButton.Click += new System.EventHandler(this.AddTagButton_Click);
            // 
            // AddFolderbutton
            // 
            this.AddFolderbutton.Location = new System.Drawing.Point(148, 10);
            this.AddFolderbutton.Name = "AddFolderbutton";
            this.AddFolderbutton.Size = new System.Drawing.Size(75, 23);
            this.AddFolderbutton.TabIndex = 3;
            this.AddFolderbutton.Text = "Add";
            this.AddFolderbutton.UseVisualStyleBackColor = true;
            // 
            // AddTagTextBox
            // 
            this.AddTagTextBox.Location = new System.Drawing.Point(400, 12);
            this.AddTagTextBox.Name = "AddTagTextBox";
            this.AddTagTextBox.Size = new System.Drawing.Size(170, 20);
            this.AddTagTextBox.TabIndex = 4;
            this.AddTagTextBox.Text = "Enter New Tag(s)";
            // 
            // AddFolderTextBox
            // 
            this.AddFolderTextBox.Location = new System.Drawing.Point(13, 12);
            this.AddFolderTextBox.Name = "AddFolderTextBox";
            this.AddFolderTextBox.Size = new System.Drawing.Size(129, 20);
            this.AddFolderTextBox.TabIndex = 5;
            this.AddFolderTextBox.Text = "Enter New Folder";
            // 
            // SortByNameButton
            // 
            this.SortByNameButton.Location = new System.Drawing.Point(311, 10);
            this.SortByNameButton.Name = "SortByNameButton";
            this.SortByNameButton.Size = new System.Drawing.Size(83, 23);
            this.SortByNameButton.TabIndex = 6;
            this.SortByNameButton.Text = "Sort by Name";
            this.SortByNameButton.UseVisualStyleBackColor = true;
            this.SortByNameButton.Click += new System.EventHandler(this.SortByNameButton_Click);
            // 
            // SortByDateButton
            // 
            this.SortByDateButton.Location = new System.Drawing.Point(230, 10);
            this.SortByDateButton.Name = "SortByDateButton";
            this.SortByDateButton.Size = new System.Drawing.Size(75, 23);
            this.SortByDateButton.TabIndex = 7;
            this.SortByDateButton.Text = "Sort by Date";
            this.SortByDateButton.UseVisualStyleBackColor = true;
            this.SortByDateButton.Click += new System.EventHandler(this.SortByDateButton_Click);
            // 
            // BGPanelRight
            // 
            this.BGPanelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BGPanelRight.Controls.Add(this.SortByDateButton);
            this.BGPanelRight.Controls.Add(this.AddTagButton);
            this.BGPanelRight.Controls.Add(this.SortByNameButton);
            this.BGPanelRight.Controls.Add(this.AddTagTextBox);
            this.BGPanelRight.Location = new System.Drawing.Point(253, 12);
            this.BGPanelRight.Name = "BGPanelRight";
            this.BGPanelRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BGPanelRight.Size = new System.Drawing.Size(663, 43);
            this.BGPanelRight.TabIndex = 9;
            // 
            // BGPanelLeft
            // 
            this.BGPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BGPanelLeft.Controls.Add(this.AddFolderTextBox);
            this.BGPanelLeft.Controls.Add(this.AddFolderbutton);
            this.BGPanelLeft.Location = new System.Drawing.Point(12, 12);
            this.BGPanelLeft.Name = "BGPanelLeft";
            this.BGPanelLeft.Size = new System.Drawing.Size(235, 43);
            this.BGPanelLeft.TabIndex = 10;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.treeView1.Location = new System.Drawing.Point(12, 62);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(235, 481);
            this.treeView1.TabIndex = 11;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // TagStringComplete
            // 
            this.TagStringComplete.Location = new System.Drawing.Point(394, 552);
            this.TagStringComplete.Name = "TagStringComplete";
            this.TagStringComplete.Size = new System.Drawing.Size(360, 20);
            this.TagStringComplete.TabIndex = 12;
            // 
            // NameStringComplete
            // 
            this.NameStringComplete.Location = new System.Drawing.Point(253, 552);
            this.NameStringComplete.Name = "NameStringComplete";
            this.NameStringComplete.Size = new System.Drawing.Size(129, 20);
            this.NameStringComplete.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(383, 555);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 550);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Generate Name";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileTagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(928, 584);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameStringComplete);
            this.Controls.Add(this.TagStringComplete);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.BGPanelLeft);
            this.Controls.Add(this.BGPanelRight);
            this.Controls.Add(this.TagListLayoutPanel);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OkBtn);
            this.Name = "FileTagForm";
            this.Text = "Add Tags";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileTagForm_FormClosing);
            this.Load += new System.EventHandler(this.FileTagForm_Load);
            this.BGPanelRight.ResumeLayout(false);
            this.BGPanelRight.PerformLayout();
            this.BGPanelLeft.ResumeLayout(false);
            this.BGPanelLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.FlowLayoutPanel TagListLayoutPanel;
        private System.Windows.Forms.Button AddTagButton;
        private System.Windows.Forms.Button AddFolderbutton;
        private System.Windows.Forms.TextBox AddTagTextBox;
        private System.Windows.Forms.TextBox AddFolderTextBox;
        private System.Windows.Forms.Button SortByNameButton;
        private System.Windows.Forms.Button SortByDateButton;
        private System.Windows.Forms.Panel BGPanelRight;
        private System.Windows.Forms.Panel BGPanelLeft;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox TagStringComplete;
        private System.Windows.Forms.TextBox NameStringComplete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}