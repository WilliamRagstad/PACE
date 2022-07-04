using System;
using System.Drawing;
using System.Windows.Forms;

namespace PointAndClickEngine
{
	public partial class MainEditorForm : Form
	{
		public MainEditorForm()
		{
			InitializeComponent();
		}

		#region Helper functions
		private Random _random = new Random();
		private Color randomColor() => Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255));
		#endregion

		private int randomMax(int max) => _random.Next(max);

		private void nodeGraphNetwork1_Click(object sender, EventArgs e)
		{
			nodeGraphNetwork1.CreateNode(
				randomMax(nodeGraphNetwork1.Width),
				randomMax(nodeGraphNetwork1.Height),
				randomMax(10) + 10,
				randomColor(), randomColor());
		}

		private void MainEditorForm_Load(object sender, EventArgs e)
		{

		}

	}
}
