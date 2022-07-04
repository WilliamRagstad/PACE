using System;

namespace PACE_Controls.Events
{
	public class NodeHoverEnterEventArgs : EventArgs
	{

		public NodeHoverEnterEventArgs(GraphNode node)
		{
			Node = node;
		}

		public GraphNode Node { get; }
	}
}
