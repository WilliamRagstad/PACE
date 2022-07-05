using System;

namespace PACE_Controls.NodeGraphNetwork.Events
{
	public class NodeHoverLeaveEventArgs : EventArgs
	{

		public NodeHoverLeaveEventArgs(IGraphNodeHoverable node)
		{
			Node = node;
		}

		public IGraphNodeHoverable Node { get; }
	}
}
