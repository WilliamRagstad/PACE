
namespace PointAndClickEngine
{
    partial class MainEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainEditorForm));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Hejsan");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.Test = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_title = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tabControl_mapEditor = new System.Windows.Forms.TabControl();
            this.tabPage_map1 = new System.Windows.Forms.TabPage();
            this.nodeGraphNetwork1 = new PACE_Controls.NodeGraphNetwork();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabControl_mapEditor.SuspendLayout();
            this.tabPage_map1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Test});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1481, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(62, 34);
            this.File.Text = "File";
            // 
            // Test
            // 
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(67, 34);
            this.Test.Text = "Test";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_title,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 42);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1481, 47);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_title
            // 
            this.toolStripLabel_title.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripLabel_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.toolStripLabel_title.Name = "toolStripLabel_title";
            this.toolStripLabel_title.Size = new System.Drawing.Size(107, 41);
            this.toolStripLabel_title.Text = "PACE";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(169, 41);
            this.toolStripButton1.Text = "Check Button";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tabControl_mapEditor
            // 
            this.tabControl_mapEditor.Controls.Add(this.tabPage_map1);
            this.tabControl_mapEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_mapEditor.Location = new System.Drawing.Point(0, 0);
            this.tabControl_mapEditor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabControl_mapEditor.Name = "tabControl_mapEditor";
            this.tabControl_mapEditor.SelectedIndex = 0;
            this.tabControl_mapEditor.Size = new System.Drawing.Size(981, 735);
            this.tabControl_mapEditor.TabIndex = 3;
            // 
            // tabPage_map1
            // 
            this.tabPage_map1.Controls.Add(this.nodeGraphNetwork1);
            this.tabPage_map1.Location = new System.Drawing.Point(4, 39);
            this.tabPage_map1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage_map1.Name = "tabPage_map1";
            this.tabPage_map1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tabPage_map1.Size = new System.Drawing.Size(973, 692);
            this.tabPage_map1.TabIndex = 0;
            this.tabPage_map1.Text = "tabPage1";
            this.tabPage_map1.UseVisualStyleBackColor = true;
            // 
            // nodeGraphNetwork1
            // 
            this.nodeGraphNetwork1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nodeGraphNetwork1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nodeGraphNetwork1.Location = new System.Drawing.Point(5, 6);
            this.nodeGraphNetwork1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nodeGraphNetwork1.Name = "nodeGraphNetwork1";
            this.nodeGraphNetwork1.Size = new System.Drawing.Size(963, 680);
            this.nodeGraphNetwork1.TabIndex = 0;
            this.nodeGraphNetwork1.Text = "nodeGraphNetwork1";
            this.nodeGraphNetwork1.Click += new System.EventHandler(this.nodeGraphNetwork1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 89);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_mapEditor);
            this.splitContainer1.Size = new System.Drawing.Size(1481, 735);
            this.splitContainer1.SplitterDistance = 493;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Group 1";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Group 2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(493, 735);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // MainEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 824);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Point-and-Click Engine | Game Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainEditorForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl_mapEditor.ResumeLayout(false);
            this.tabPage_map1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Test;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_title;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabControl tabControl_mapEditor;
        private System.Windows.Forms.TabPage tabPage_map1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private PACE_Controls.NodeGraphNetwork nodeGraphNetwork1;
    }
}

