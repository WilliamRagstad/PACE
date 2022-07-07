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
		public static string Version = "1.0.0-Alpha";
		public static EditorPreferences EditorPreferences = _loadEditorPreferences();
		public static string PaceDataFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PACE");
		public static string DefaultProjectsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PACE Projects");
		public static string ProjectRootFilename = "project.xml";
		public static string EditorPreferencesFilepath = Path.Combine(PaceDataFolder, "preferences.xml");

		public static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFilename);

		private static EditorPreferences _loadEditorPreferences()
		{
			EditorPreferences preferences;
			if (File.Exists(EditorPreferencesFilepath))
				preferences = GameObjectSerializer.LoadFile<EditorPreferences>(EditorPreferencesFilepath);
			else
			{
				preferences = new EditorPreferences();
				// Create preferences file in PACE app data
				Directory.CreateDirectory(PaceDataFolder);
				GameObjectSerializer.SaveToFile(preferences, EditorPreferencesFilepath);
			}
			return preferences;
		}
	}
}
