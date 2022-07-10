using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PACE_Controls.NodeGraphNetwork.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	public class NodeGraphNetwork : Control
	{
		public Image MapImage { get; set; }
		private List<GraphNode> _nodes;
		private Point _offset = new Point(0, 0);
		private float _scale = 1.0f;
		private bool _needsRedraw = true; // Initial
		public NodeGraphNetwork()
		{
			_nodes = new List<GraphNode>();
			MouseMove += HandleMouseMove;
			Click += HandleClick;
			Resize += HandleResize;
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
			if (_needsRedraw)
			{
				base.OnPaint(e);
				if (MapImage != null)
					e.Graphics.DrawImage(MapImage, _offset);
			}
			_nodes.ForEach(n => n.OnPaint(e, _needsRedraw));
			_needsRedraw = false;
		}

		private List<IGraphNodeHoverable> _getHoveredNodes()
		{
			Point mousePoint = PointToClient(new Point(MousePosition.X, MousePosition.Y));
			return _nodes
				.FindAll(n => n is IGraphNodeHoverable h && h.IsHovered(mousePoint.X, mousePoint.Y))
				.ConvertAll(n => n as IGraphNodeHoverable) as List<IGraphNodeHoverable>;
		}

		private T _lastOf<T>(List<T> list)
		{
			if (list.Count > 0) return list[list.Count - 1];
			return default(T);
		}

		private void HandleClick(object sender, EventArgs e)
		{
			var matches = _getHoveredNodes()
				.FindAll(n => n is IGraphNodeClickable)
				.ConvertAll(n => n as IGraphNodeClickable);
			var last = _lastOf(matches);
			last?.OnNodeClicked(this, new NodeClickedEventArgs(last));
		}

		private IGraphNodeHoverable _previousHoveredNode;
		private void HandleMouseMove(object sender, MouseEventArgs e)
		{
			var found = _lastOf(_getHoveredNodes());
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
			// Update cursor
			if (found != null) Cursor.Current = Cursors.Hand;
			else Cursor.Current = Cursors.Default;
			_previousHoveredNode = found;
		}

		private void HandleResize(object sender, EventArgs e)
		{
			_needsRedraw = true;
		}
	}
}
