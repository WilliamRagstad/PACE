namespace PointAndClickEngine.Forms
{
	partial class NewProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProjectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_location = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_selectLocation = new System.Windows.Forms.Button();
            this.button_newProject = new System.Windows.Forms.Button();
            this.textBox_namespace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(148, 52);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.PlaceholderText = "Game Name";
            this.textBox_title.Size = new System.Drawing.Size(278, 35);
            this.textBox_title.TabIndex = 2;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(148, 93);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.PlaceholderText = "Short description of the game";
            this.textBox_description.Size = new System.Drawing.Size(458, 71);
            this.textBox_description.TabIndex = 3;
            // 
            // textBox_location
            // 
            this.textBox_location.Location = new System.Drawing.Point(148, 170);
            this.textBox_location.Name = "textBox_location";
            this.textBox_location.ReadOnly = true;
            this.textBox_location.Size = new System.Drawing.Size(401, 35);
            this.textBox_location.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Location";
            // 
            // button_selectLocation
            // 
            this.button_selectLocation.Location = new System.Drawing.Point(555, 165);
            this.button_selectLocation.Name = "button_selectLocation";
            this.button_selectLocation.Size = new System.Drawing.Size(51, 40);
            this.button_selectLocation.TabIndex = 6;
            this.button_selectLocation.Text = "...";
            this.button_selectLocation.UseVisualStyleBackColor = true;
            this.button_selectLocation.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_newProject
            // 
            this.button_newProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_newProject.BackColor = System.Drawing.Color.Crimson;
            this.button_newProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_newProject.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_newProject.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_newProject.Location = new System.Drawing.Point(455, 285);
            this.button_newProject.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button_newProject.Name = "button_newProject";
            this.button_newProject.Size = new System.Drawing.Size(174, 49);
            this.button_newProject.TabIndex = 7;
            this.button_newProject.Tag = "custom";
            this.button_newProject.Text = "Create";
            this.button_newProject.UseVisualStyleBackColor = false;
            this.button_newProject.Click += new System.EventHandler(this.button_newProject_Click);
            // 
            // textBox_namespace
            // 
            this.textBox_namespace.Location = new System.Drawing.Point(148, 211);
            this.textBox_namespace.Name = "textBox_namespace";
            this.textBox_namespace.PlaceholderText = "project_namespace";
            this.textBox_namespace.Size = new System.Drawing.Size(278, 35);
            this.textBox_namespace.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Namespace";
            // 
            // NewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 349);
            this.Controls.Add(this.textBox_namespace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_newProject);
            this.Controls.Add(this.button_selectLocation);
            this.Controls.Add(this.textBox_location);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewProjectForm";
            this.Text = "PACE | Create Project";
            this.Load += new System.EventHandler(this.NewProjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox_title;
		private System.Windows.Forms.TextBox textBox_description;
		private System.Windows.Forms.TextBox textBox_location;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_selectLocation;
		private System.Windows.Forms.Button button_newProject;
		private System.Windows.Forms.TextBox textBox_namespace;
		private System.Windows.Forms.Label label4;
	}
}