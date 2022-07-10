using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models
{
	[Serializable]
	[XmlRoot("Project", IsNullable = false)]
	public class GameProject
	{
		public string Title;
		public string Description;
		public int Version;
		public string Namespace;
		[XmlIgnore]
		public string RootFolder; // Set when loading a project
		public List<GameWorld> Worlds;

		public void Save()
		{
			ProjectHelper.EnsureFolder(RootFolder);
			GameObjectSerializer.SaveToFile(this, Path.Combine(RootFolder, EditorConfig.ProjectRootFilename));
		}
	}
}
