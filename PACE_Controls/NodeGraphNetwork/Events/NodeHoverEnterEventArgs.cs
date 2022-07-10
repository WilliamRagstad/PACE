using System;

namespace PACE_Controls.NodeGraphNetwork.Events
{
	public class NodeHoverEnterEventArgs : EventArgs
	{

		public NodeHoverEnterEventArgs(IGraphNodeHoverable node)
		{
			Node = node;
		}

		public IGraphNodeHoverable Node { get; }
	}
}
