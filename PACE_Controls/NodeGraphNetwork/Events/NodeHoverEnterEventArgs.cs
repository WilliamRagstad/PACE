using System;
using PACE_Controls.NodeGraphNetwork;

namespace PACE_Controls.NodeGraphNetwork.Events
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
