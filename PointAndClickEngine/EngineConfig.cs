using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndClickEngine.Models;

namespace PointAndClickEngine
{
	internal static class EngineConfig
	{
		public static string ProjectRootFile = "project.pace";
		public static string DefaultProjectsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PACE Projects");
		public static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFile);

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
}
