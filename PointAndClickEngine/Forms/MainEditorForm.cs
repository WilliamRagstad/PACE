﻿using System;
using System.Drawing;
using System.Windows.Forms;
using PACE_Controls.NodeGraphNetwork;
using PointAndClickEngine.Models;

namespace PointAndClickEngine
{
	public partial class MainEditorForm : Form
	{
		public GameProject Project { get; }

		public MainEditorForm(GameProject project)
		{
			Project = project;
			InitializeComponent();
			EditorConfig.EditorTheme().ApplyOnForm(this);
			UpdateEditor();
		}

		/// <summary>
		/// Update the game editor form when <c>Project</c> has changed.
		/// </summary>
		public void UpdateEditor()
		{
			Text = $"PACE | Game Editor - {Project.Title}";
		}

		#region Helper functions

		private Random _random = new Random();
		private Color randomColor() => Color.FromArgb(_random.Next(255), _random.Next(255), _random.Next(255));
		private int randomMax(int max) => _random.Next(max);
		private int _idCounter = 0;

		#endregion


		private void nodeGraphNetwork1_Click(object sender, EventArgs e)
		{
			nodeGraphNetwork1.AddNode(new GraphNodeColoredCircle(
				_idCounter++,
				randomMax(nodeGraphNetwork1.Width),
				randomMax(nodeGraphNetwork1.Height),
				randomMax(10) + 10,
				randomColor(), randomColor()));
		}

		private void MainEditorForm_Load(object sender, EventArgs e)
		{

		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Project.Save();
		}
	}
}
