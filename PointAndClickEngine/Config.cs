using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndClickEngine
{
	internal static class Config
	{
		public static string ProjectRootFile = "project.pace";
		private static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFile);
	}
}
