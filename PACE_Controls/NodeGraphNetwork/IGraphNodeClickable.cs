using PACE_Controls.NodeGraphNetwork.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	public interface IGraphNodeClickable : IGraphNodeHoverable
	{
#nullable enable
		public void OnNodeClicked(object? sender, NodeClickedEventArgs e);
#nullable restore
	}
}
