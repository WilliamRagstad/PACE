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
		public static EditorTheme EditorTheme() => ThemeManager.Load(EditorPreferences.ThemeName);
		public static string PaceDataFolder() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PACE");
		public static string DefaultProjectsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PACE Projects");
		public static string ProjectRootFilename = "project.xml";
		public static string EditorPreferencesFilepath() => Path.Combine(PaceDataFolder(), "preferences.xml");

		public static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFilename);

		private static EditorPreferences _loadEditorPreferences()
		{
			EditorPreferences preferences;
			string pref = EditorPreferencesFilepath();
			if (File.Exists(pref))
				preferences = GameObjectSerializer.LoadFile<EditorPreferences>(pref);
			else
			{
				preferences = new EditorPreferences();
				// Create preferences file in PACE app data
				if (!Directory.Exists(PaceDataFolder()))
					Directory.CreateDirectory(PaceDataFolder());
				GameObjectSerializer.SaveToFile(preferences, pref);
			}
			return preferences;
		}
	}
}
