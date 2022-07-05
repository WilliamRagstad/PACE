using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using PACE_Controls.NodeGraphNetwork.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	public class NodeGraphNetwork : Control
	{
		private List<GraphNode> _nodes;
		public NodeGraphNetwork()
		{
			_nodes = new List<GraphNode>();
			MouseMove += HandleMouseMove;
			Click += HandleClick;
		}

		public void AddNode(GraphNode node)
		{
			_nodes.Add(node);
			_redraw();
		}

		public void RemoveNodes(Predicate<GraphNode> pred)
		{
			_nodes.RemoveAll(pred);
			_redraw();
		}

		private void _redraw() => OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			_nodes.ForEach(n => n.OnPaint(e));
		}

		private List<IGraphNodeHoverable> _getHoveredNodes()
		{
			Point mousePoint = PointToClient(new Point(MousePosition.X, MousePosition.Y));
			return _nodes
				.FindAll(n => n is IGraphNodeHoverable h && h.IsHovered(mousePoint.X, mousePoint.Y))
				.ConvertAll(n => n as IGraphNodeHoverable) as List<IGraphNodeHoverable>;
		}

		private IGraphNodeHoverable? _getTopHoveredNode()
		{
			var matches = _getHoveredNodes();
			if (matches.Count > 0)
			{
				// Last node is always on top of the others in depth
				return matches[matches.Count - 1];
			}
			return null;
		}

		private void HandleClick(object sender, EventArgs e)
		{
			var matches = _getHoveredNodes()
				.FindAll(n => n is IGraphNodeClickable)
				.ConvertAll(n => n as IGraphNodeClickable);
			if (matches.Count > 0)
			{
				// Last node is always on top of the others in depth
				var last = matches[matches.Count - 1];
				last.OnNodeClicked(this, new NodeClickedEventArgs(last as GraphNode));
			}
		}

		private GraphNode _previousHoveredNode;

		private void HandleMouseMove(object sender, MouseEventArgs e)
		{
			var matches = _getHoveredNodes();
			if (found == null && _previousHoveredNode != null)
			{
				_previousHoveredNode?.OnNodeHoverLeave(this, new NodeHoverLeaveEventArgs(found));
				this.InvokePaint(this, new PaintEventArgs(CreateGraphics(), ClientRectangle));
			}
			if (found != null && !found.Equals(_previousHoveredNode))
			{
				_previousHoveredNode?.OnNodeHoverLeave(this, new NodeHoverLeaveEventArgs(found));
				found.OnNodeHoverEnter(this, new NodeHoverEnterEventArgs(found));
				this.InvokePaint(this, new PaintEventArgs(CreateGraphics(), ClientRectangle));
			}
			_previousHoveredNode = found;
		}
	}
}
