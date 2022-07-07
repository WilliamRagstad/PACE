using PointAndClickEngine.Models;
using PointAndClickEngine.Util;
using System;
using System.IO;
using System.Windows.Forms;

namespace PointAndClickEngine.Forms
{
	public partial class StartupForm : ExtendedForm
	{
		public StartupForm()
		{
			InitializeComponent();
			EngineConfig.EditorTheme().ApplyOnForm(this);
		}

		private void StartEditor(GameProject project)
		{
			SwitchTo(new MainEditorForm(project));
		}

		private void button_newProject_Click(object sender, EventArgs e)
		{
			var projectDialog = new NewProjectForm();
			if (projectDialog.ShowDialog() == DialogResult.OK)
				StartEditor(projectDialog.CreatedProject);
		}

		private void button_loadProject_Click(object sender, EventArgs e)
		{
			var folderDialog = new FolderBrowserDialog()
			{
				Description = "Select a game project folder"
			};
			var projectFolder = folderDialog.ShowDialog();
			if (projectFolder == DialogResult.OK)
			{
				if (!Directory.Exists(folderDialog.SelectedPath))
				{
					MessageBox.Show("The selected folder does not exist!", "Invalid folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				var projectFile = EngineConfig.ProjectRootFromFolder(folderDialog.SelectedPath);
				var project = GameObjectSerializer.LoadFile<GameProject>(projectFile);
				if (project.Version < EngineConfig.OldestSupportedProjectVersion)
				{
					MessageBox.Show($"Project is too old! Version {project.Version} is not supported by this editor, only {EngineConfig.OldestSupportedProjectVersion} and above.");
				}
				project.RootFolder = folderDialog.SelectedPath;
				StartEditor(project);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show($@"Welcome to the Point-And-Click adventure game Engine (PACE)!
This is a project developed by William Rågstad and is free to use.

Version {EngineConfig.Version}", "PACE | About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
