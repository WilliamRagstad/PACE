using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndClickEngine.Models
{
	/// <summary>
	/// Defaults to standard perferences.
	/// Intended to be saved and loaded from file in appdata.
	/// </summary>
	[Serializable]
	public class EditorPreferences
	{
		/// <summary>
		/// Current editor theme.
		/// </summary>
		public EditorTheme Theme = BuiltinThemes.Default;
	}
}
