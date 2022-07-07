using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models
{
	/// <summary>
	/// Defaults to standard perferences.
	/// Intended to be saved and loaded from file in appdata.
	/// </summary>
	[Serializable]
	[XmlRoot("Preferences", IsNullable = false)]
	public class EditorPreferences
	{
		[XmlElement("Language")]
		public string Language = "sv";
		/// <summary>
		/// Current editor theme.
		/// </summary>
		[XmlElement("Theme", IsNullable = false)]
		public string ThemeName = nameof(ThemeManager.Builtins.Default);
		[XmlElement("EditorCommand", IsNullable = false)]
		public string StartCodeEditorCommand = "code $file"; // VSCode
	}
}
