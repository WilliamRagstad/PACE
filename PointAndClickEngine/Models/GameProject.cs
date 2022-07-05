using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndClickEngine.Models
{
	public class GameProject
	{
		public string Title { get; set; }
		public string Description { get; set; }

		public static string ProjectRootFile = "project.pace";
		public static GameProject LoadProjectFolder(string folderPath) =>
			LoadFile(Path.Combine(folderPath, ProjectRootFile));
		public static GameProject LoadFile(string projectRootPath)
		{
			GameProject project = new GameProject();
			project.Title = projectRootPath;
			project.Description = projectRootPath;
			return project;
		}
	}
}
