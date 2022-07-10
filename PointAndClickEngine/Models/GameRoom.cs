﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		[XmlRoot("Data", IsNullable = false)]
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
