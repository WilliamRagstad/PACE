using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACE_Controls.Events
{
	public class NodeClickedEventArgs : EventArgs
	{

		public NodeClickedEventArgs(GraphNode node)
		{
			Node = node;
		}

		public GraphNode Node { get; }
	}
}
