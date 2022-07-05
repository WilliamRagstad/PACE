using System;

namespace PACE_Controls.NodeGraphNetwork.Events
{
	public class NodeHoverLeaveEventArgs : EventArgs
	{

		public NodeHoverLeaveEventArgs(GraphNode node)
		{
			Node = node;
		}

		public GraphNode Node { get; }
	}
}
