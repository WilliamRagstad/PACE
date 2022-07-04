using PointAndClickEngine.Util;
using System;
using System.Windows.Forms;

namespace PointAndClickEngine
{
	public partial class StartupForm : ExtendedForm
	{
		public StartupForm()
		{
			InitializeComponent();
		}

		private void button_newProject_Click(object sender, EventArgs e)
		{
			SwitchTo(new MainEditorForm());
		}

		private void linkLabel_about_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show(@"Welcome to the Point-And-Click adventure game Engine (PACE)!
This is a project developed by William Rågstad and is free to use.", "PACE | About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}