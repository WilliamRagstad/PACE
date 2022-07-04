using System;

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
