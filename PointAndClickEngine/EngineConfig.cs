using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndClickEngine
{
	internal static class EngineConfig
	{
		public static string ProjectRootFile = "project.pace";
		public static string DefaultProjectsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PACE Projects");
		public static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFile);
	}
}
