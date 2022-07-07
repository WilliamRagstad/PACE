﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointAndClickEngine.Models;

namespace PointAndClickEngine
{
	public static class ThemeManager
	{
		public static EditorTheme Load(string themeName)
		{
			switch (themeName.ToLower())
			{
				case "default":
					return Builtins.Default;
				case "dark":
					return Builtins.Dark;
				default:
					MessageBox.Show($"Warning: The theme '{themeName}' could not be loaded!", "Invalid theme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return Builtins.Default;
			}
		}
		public static class Builtins
		{
			public static EditorTheme Default = new EditorTheme();
			public static EditorTheme Dark = new EditorTheme()
			{
				FormBackgroundPrimary = Color.FromArgb(45, 45, 45),
				FormTextPrimary = Color.FromKnownColor(KnownColor.ButtonFace),
			};
		}
	}
}