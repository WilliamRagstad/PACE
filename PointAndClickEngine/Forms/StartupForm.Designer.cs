
namespace PointAndClickEngine.Forms
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.pictureBox_banner = new System.Windows.Forms.PictureBox();
            this.button_newProject = new System.Windows.Forms.Button();
            this.button_loadProject = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_banner)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_banner
            // 
            this.pictureBox_banner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_banner.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_banner.Image = global::PointAndClickEngine.Properties.Resources.pace_startup_banner;
            this.pictureBox_banner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_banner.InitialImage = null;
            this.pictureBox_banner.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_banner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBox_banner.Name = "pictureBox_banner";
            this.pictureBox_banner.Size = new System.Drawing.Size(553, 207);
            this.pictureBox_banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_banner.TabIndex = 0;
            this.pictureBox_banner.TabStop = false;
            // 
            // button_newProject
            // 
            this.button_newProject.BackColor = System.Drawing.Color.Crimson;
            this.button_newProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_newProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_newProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_newProject.Location = new System.Drawing.Point(123, 258);
            this.button_newProject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_newProject.Name = "button_newProject";
            this.button_newProject.Size = new System.Drawing.Size(303, 80);
            this.button_newProject.TabIndex = 1;
            this.button_newProject.Text = "New Project";
            this.button_newProject.UseVisualStyleBackColor = false;
            this.button_newProject.Click += new System.EventHandler(this.button_newProject_Click);
            // 
            // button_loadProject
            // 
            this.button_loadProject.BackColor = System.Drawing.Color.Crimson;
            this.button_loadProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_loadProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_loadProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_loadProject.Location = new System.Drawing.Point(123, 350);
            this.button_loadProject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_loadProject.Name = "button_loadProject";
            this.button_loadProject.Size = new System.Drawing.Size(303, 80);
            this.button_loadProject.TabIndex = 2;
            this.button_loadProject.Text = "Load Project";
            this.button_loadProject.UseVisualStyleBackColor = true;
            this.button_loadProject.Click += new System.EventHandler(this.button_loadProject_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(123, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(553, 610);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_loadProject);
            this.Controls.Add(this.button_newProject);
            this.Controls.Add(this.pictureBox_banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "StartupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PACE | Projects";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_banner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_banner;
        private System.Windows.Forms.Button button_newProject;
        private System.Windows.Forms.Button button_loadProject;
		private System.Windows.Forms.Button button1;
	}
}
