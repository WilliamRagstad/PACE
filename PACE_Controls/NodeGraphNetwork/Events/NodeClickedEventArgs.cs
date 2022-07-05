using System;

namespace PACE_Controls.NodeGraphNetwork.Events
{
	public class NodeClickedEventArgs : EventArgs
	{

		public NodeClickedEventArgs(IGraphNodeClickable node)
		{
			Node = node;
		}

		public IGraphNodeClickable Node { get; }
	}
}
