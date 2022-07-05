using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACE_Controls.NodeGraphNetwork.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	internal interface IGraphNodeClickable : IGraphNodeHoverable
	{
#nullable enable
		public void OnNodeClicked(object? sender, NodeClickedEventArgs e);
#nullable restore
	}
}
