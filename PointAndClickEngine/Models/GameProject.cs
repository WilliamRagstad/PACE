using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace PointAndClickEngine.Models
{
	[Serializable]
	public class GameProject
	{
		public string Title { get; set; }
		public string Description { get; set; }
	}
}
