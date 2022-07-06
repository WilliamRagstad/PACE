using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models.Serialization
{
	public class GameProjectSerializer
	{
		public static string ProjectRootFile = "project.pace";
		private static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFile);

		private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(GameProject));

		public static GameProject LoadProjectFolder(string folderPath) =>
			LoadFile(ProjectRootFromFolder(folderPath));
		public static GameProject LoadFile(string projectRootPath)
		{
			FileStream fs = File.OpenRead(projectRootPath);
			GameProject project = (GameProject)_serializer.Deserialize(fs);
			if (project == null) throw new Exception($"Failed to load project: {projectRootPath}!");
			return project;
		}

		/// <summary>
		/// Save PACE game project in root of folder.
		/// </summary>
		public static void SaveToFolder(GameProject project, string folderPath)
		{
			var root = ProjectRootFromFolder(folderPath);
			if (File.Exists(root)) File.Delete(root);
			FileStream fs = File.Create(root);
			_serializer.Serialize(fs, project);
			fs.Close();
		}
	}
}
