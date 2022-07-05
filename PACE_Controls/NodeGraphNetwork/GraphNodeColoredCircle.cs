using System;
using System.Drawing;
using System.Windows.Forms;
using PACE_Controls.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	public class GraphNodeColoredCircle : GraphNode
	{
		public int Radius { get; }
		public Color Color { get; }
		public Color HoverColor { get; }

		private Color currentColor;

		public event EventHandler<NodeClickedEventArgs> NodeClicked;
		public event EventHandler<NodeHoverEnterEventArgs> NodeHoverEnter;
		public event EventHandler<NodeHoverLeaveEventArgs> NodeHoverLeave;

		public GraphNodeColoredCircle(int id, int x, int y, int radius, Color color, Color hoverColor) : base(id, x, y)
		{
			Radius = radius;
			Color = color;
			HoverColor = hoverColor;
			currentColor = Color;

			// Show hover colors per default
			NodeHoverEnter += (sender, e) => currentColor = HoverColor;
			NodeHoverLeave += (sender, e) => currentColor = Color;
		}

		public bool IsInside(Point mousePoint, Point nodePoint) =>
			Math.Abs(nodePoint.X - mousePoint.X) <= Radius && Math.Abs(nodePoint.Y - mousePoint.Y) <= Radius;

		public override void OnPaint(PaintEventArgs e) =>
			e.Graphics.FillEllipse(new SolidBrush(currentColor), X - Radius, Y - Radius, 2 * Radius, 2 * Radius);



#nullable enable
		public void OnNodeClicked(object? sender, NodeClickedEventArgs e) => NodeClicked?.Invoke(sender, e);
		public void OnNodeHoverEnter(object? sender, NodeHoverEnterEventArgs e) => NodeHoverEnter?.Invoke(sender, e);
		public void OnNodeHoverLeave(object? sender, NodeHoverLeaveEventArgs e) => NodeHoverLeave?.Invoke(sender, e);
#nullable restore
	}
}
