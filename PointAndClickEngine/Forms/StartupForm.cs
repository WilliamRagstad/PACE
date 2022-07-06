using PointAndClickEngine.Models;
using PointAndClickEngine.Util;
using System;
using System.IO;
using System.Windows.Forms;

namespace PointAndClickEngine
{
	public partial class StartupForm : ExtendedForm
	{
		public StartupForm()
		{
			InitializeComponent();
		}

		private void StartEditor(GameProject project)
		{
			SwitchTo(new MainEditorForm(project));
		}

		private void button_newProject_Click(object sender, EventArgs e)
		{
			var project = new Models.GameProject();
			// Show new project creator form/window that returns a GameProject object.
			StartEditor(project);
		}

		private void linkLabel_about_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show(@"Welcome to the Point-And-Click adventure game Engine (PACE)!
This is a project developed by William Rågstad and is free to use.", "PACE | About", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				StartEditor(GameObjectSerializer.LoadFile<GameProject>(folderDialog.SelectedPath));
			}
		}
	}
}
