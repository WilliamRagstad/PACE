using System;
using System.IO;
using PointAndClickEngine.Models;

namespace PointAndClickEngine
{
	/// <summary>
	/// Static class holding the global application state and hard-coded values.
	/// </summary>
	internal static class EditorConfig
	{
		public static string Version = "1.0.0-Alpha";
		public static int ProjectVersion = 1;
		public static int OldestSupportedProjectVersion = 1;
		public static EditorPreferences EditorPreferences = _loadEditorPreferences();
		public static EditorTheme EditorTheme() => ThemeManager.Load(EditorPreferences.ThemeName);
		public static string PaceDataFolder() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PACE");
		public static string DefaultProjectsFolder() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "PACE Projects");
		public static string ProjectRootFilename = "project.xml";
		public static string EditorPreferencesFilepath() => Path.Combine(PaceDataFolder(), "preferences.xml");

		public static string ProjectRootFromFolder(string folderPath) =>
			Path.Combine(folderPath, ProjectRootFilename);

		private static EditorPreferences _loadEditorPreferences()
		{
			string pref = EditorPreferencesFilepath();
			string data = PaceDataFolder();
			if (File.Exists(pref))
			{
				try
				{
					return GameObjectSerializer.LoadFile<EditorPreferences>(pref);
				}
				catch (Exception ex) { /* Create a new preferences file */ }
			}
			var preferences = new EditorPreferences();
			// Create preferences file in PACE app data
			if (!Directory.Exists(data)) Directory.CreateDirectory(data);
			GameObjectSerializer.SaveToFile(preferences, pref);
			return preferences;
		}
	}
}
