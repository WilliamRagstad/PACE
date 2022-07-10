using System;
using System.Drawing;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models
{
	[Serializable]
	[XmlRoot("Room", IsNullable = false)]
	public class GameRoom
	{
		public string Title;
		public string Description;
		public Image Background;
		/// TODO: Add interactible objects, characters, sound, music, sprites (static gifs), etc.

		public EditorMetadata Metadata;

		#region Editor Metadata
		[Serializable]
		[XmlType("RoomMetadata")]
		public class EditorMetadata
		{
			[XmlElement("Location")]
			public Point MapLocation;
			[XmlElement("Color")]
			public Color DotColor;
		}
		#endregion
	}
}
