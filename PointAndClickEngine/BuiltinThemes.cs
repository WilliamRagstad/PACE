using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndClickEngine.Models;

namespace PointAndClickEngine
{
	public static class BuiltinThemes
	{
		public static EditorTheme Default = new EditorTheme()
		{
			FormBackgroundPrimary = Color.FromKnownColor(KnownColor.Control)
		};

		public static EditorTheme Dark = new EditorTheme()
		{
			FormBackgroundPrimary = Color.FromArgb(45, 45, 45)
		};
	}
}
