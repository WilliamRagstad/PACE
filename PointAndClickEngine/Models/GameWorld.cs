using System;
using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;

namespace PointAndClickEngine.Models
{
	[Serializable]
	[XmlRoot("World", IsNullable = false)]
	public class GameWorld
	{
		public string Title;
		public string Description;
		public List<GameRoom> Rooms;

		public EditorMetadata Metadata;

		#region Editor Metadata
		[Serializable]
		[XmlType("WorldMetadata")]
		public class EditorMetadata
		{
			[XmlElement("BackgroundImage")]
			public Image MapImage;
		}
		#endregion
	}
}
