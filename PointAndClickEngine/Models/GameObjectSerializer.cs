using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models
{
	public class GameObjectSerializer
	{
		private static XmlSerializer _serializer;
		public static T LoadFile<T>(string filePath)
		{
			_serializer = new XmlSerializer(typeof(T));
			if (!File.Exists(filePath)) throw new FileNotFoundException("Cannot load the given file, it does not exist!", filePath);
			FileStream fs = File.OpenRead(filePath);
			T obj = (T)_serializer.Deserialize(fs);
			if (obj == null) throw new Exception($"Failed to load file: {filePath}!");
			return obj;
		}

		/// <summary>
		/// Save PACE game project in root of folder.
		/// </summary>
		public static void SaveToFile<T>(T obj, string filePath, bool shouldOverride = true)
		{
			_serializer = new XmlSerializer(typeof(T));
			if (File.Exists(filePath) && shouldOverride) File.Delete(filePath);
			FileStream fs = File.Create(filePath);
			_serializer.Serialize(fs, obj);
			fs.Close();
		}
	}
}
