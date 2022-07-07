using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models
{
	[Serializable]
	public class GameProject
	{
		public string Title;
		public string Description;
		public int Version;
		[XmlIgnore]
		public string RootFolder; // Set when loading a project

		public GameProject(string rootFolder) { RootFolder = rootFolder; }
	}
}
