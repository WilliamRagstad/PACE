using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PointAndClickEngine
{
	public class GameObjectSerializer
	{
		private static XmlSerializer _serializer;
		public static T LoadFile<T>(string filePath)
		{
			_serializer = new XmlSerializer(typeof(T));
			if (!File.Exists(filePath)) throw new FileNotFoundException("Cannot load the given file, it does not exist!", filePath);
			using FileStream fs = File.OpenRead(filePath);
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
			try
			{
				if (File.Exists(filePath) && shouldOverride) File.Delete(filePath);
				using FileStream fs = File.Create(filePath);
				_serializer.Serialize(fs, obj);
			}
			catch (Exception ex)
			{
				if (MessageBox.Show($"Failed to save file '{filePath}' due to the error below:\n{ex.Message}", "Save failed", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error) == DialogResult.Retry)
					SaveToFile(obj, filePath, shouldOverride);
			}
		}
	}
}
