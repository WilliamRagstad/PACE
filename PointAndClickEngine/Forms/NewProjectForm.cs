using System;
using System.IO;
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
			var folder = EditorConfig.DefaultProjectsFolder();
			textBox_location.Text = folder;
			ProjectHelper.EnsureFolder(folder);
		}

		private void button_newProject_Click(object sender, EventArgs e)
		{
			CreatedProject = new Models.GameProject()
			{
				Title = textBox_title.Text,
				Description = textBox_description.Text,
				Version = EditorConfig.ProjectVersion,
				Namespace = textBox_namespace.Text,
				RootFolder = Path.Combine(textBox_location.Text, textBox_namespace.Text)
			};
			try
			{
				ProjectHelper.ValidateProject(CreatedProject);
				CreatedProject.Save(); // Save project root file
				ProjectHelper.SetupFolderStructure(CreatedProject);
				DialogResult = DialogResult.OK;
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Failed to create project", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
