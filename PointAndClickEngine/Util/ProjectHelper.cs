using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndClickEngine.Models;

namespace PointAndClickEngine
{
	internal class ProjectHelper
	{
		public static void EnsureFolder(string folder)
		{
			if (!Directory.Exists(folder))
				Directory.CreateDirectory(folder);
		}

		/// <summary>
		/// Throws exceptions if any field in the project is invalid.
		/// </summary>
		/// <param name="project"></param>
		public static void ValidateProject(GameProject project)
		{
			if (project.Title.Trim() == "")
				throw new Exception("Missing title.");
			if (project.Description.Trim() == "")
				throw new Exception("Missing description.");
			if (project.RootFolder.Trim() == "")
				throw new Exception("Invalid project folder location.");
			if (project.Namespace.Trim() == "")
				throw new Exception("Missing namespace. Must also be valid folder name, recommending to use lowercase and underscores.");
			if (Directory.Exists(project.RootFolder))
				throw new Exception($"The specified location already have a folder with name {project.Namespace}!");
		}

		public static void SetupFolderStructure(GameProject project)
		{
			EnsureFolder(project.RootFolder);
			EnsureFolder(Path.Combine(project.RootFolder, "resources", "assets"));
			EnsureFolder(Path.Combine(project.RootFolder, "resources", "backgrounds"));
			EnsureFolder(Path.Combine(project.RootFolder, "resources", "sprites"));
			EnsureFolder(Path.Combine(project.RootFolder, "resources", "music"));
			EnsureFolder(Path.Combine(project.RootFolder, "resources", "sounds"));
			EnsureFolder(Path.Combine(project.RootFolder, "objects")); // All game objects
			EnsureFolder(Path.Combine(project.RootFolder, "bin")); // All binary data
		}
	}
}
