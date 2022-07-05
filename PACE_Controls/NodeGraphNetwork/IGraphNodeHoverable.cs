﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACE_Controls.NodeGraphNetwork.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	public interface IGraphNodeHoverable
	{
		public bool IsHovered(int mouseX, int mouseY);

#nullable enable
		public void OnNodeHoverEnter(object? sender, NodeHoverEnterEventArgs e);
		public void OnNodeHoverLeave(object? sender, NodeHoverLeaveEventArgs e);
#nullable restore
	}
}
