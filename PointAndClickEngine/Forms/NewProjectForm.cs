using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointAndClickEngine.Forms
{
	public partial class NewProjectForm : Form
	{
		public PointAndClickEngine.Models.GameProject CreatedProject;
		public NewProjectForm()
		{
			InitializeComponent();
			EditorConfig.EditorTheme().ApplyOnForm(this);
		}

		private void NewProjectForm_Load(object sender, EventArgs e)
		{
			TopMost = true;
			var defaultProjectFolder = EditorConfig.DefaultProjectsFolder();
			textBox_location.Text = defaultProjectFolder;
			if (!Directory.Exists(defaultProjectFolder))
				Directory.CreateDirectory(defaultProjectFolder);
		}

		private void error(string msg)
		{
			MessageBox.Show(msg, "Failed to create project", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void button_newProject_Click(object sender, EventArgs e)
		{
			if (textBox_title.Text.Trim() == "") error("Missing title.");
			else if (textBox_description.Text.Trim() == "") error("Missing description.");
			else if (textBox_location.Text.Trim() == "" || !Directory.Exists(textBox_location.Text))
				error("Invalid project folder location.");
			else if (textBox_namespace.Text.Trim() == "")
				error("Missing namespace. Must also be valid folder name, recommending to use lowercase and underscores.");
			else
			{
				string rootFolder = Path.Combine(textBox_location.Text, textBox_namespace.Text);
				if (Directory.Exists(rootFolder))
					error($"The specified location already have a folder with name {textBox_namespace.Text}!");
				else
				{
					Directory.CreateDirectory(rootFolder);
					CreatedProject = new Models.GameProject();
					CreatedProject.Title = textBox_title.Text;
					CreatedProject.Description = textBox_description.Text;
					CreatedProject.Version = EditorConfig.ProjectVersion;
					CreatedProject.RootFolder = rootFolder;
					CreatedProject.Save();
					DialogResult = DialogResult.OK;
					Close();
				}
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			var folderDialouge = new FolderBrowserDialog()
			{
				// RootFolder = EngineConfig.DefaultProjectsF older(),
				SelectedPath = textBox_location.Text,
			};
			folderDialouge.ShowDialog();
			textBox_location.Text = folderDialouge.SelectedPath;
		}
	}
}
