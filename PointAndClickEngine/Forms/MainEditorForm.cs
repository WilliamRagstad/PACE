using System;
using System.Windows.Forms;

namespace PointAndClickEngine
{
	public partial class MainEditorForm : Form
	{
		public MainEditorForm()
		{
			InitializeComponent();
		}

		private void nodeGraphNetwork1_Click(object sender, EventArgs e)
		{
			nodeGraphNetwork1.CreateNode();
		}

		private void MainEditorForm_Load(object sender, EventArgs e)
		{

		}
	}
}
