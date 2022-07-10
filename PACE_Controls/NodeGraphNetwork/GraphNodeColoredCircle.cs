using System;
using System.Drawing;
using System.Windows.Forms;
using PACE_Controls.NodeGraphNetwork.Events;

namespace PACE_Controls.NodeGraphNetwork
{
	public class GraphNodeColoredCircle : GraphNode, IGraphNodeClickable
	{
		public int Radius { get; }
		public Color Color { get; }
		public Color HoverColor { get; }
		public Color BorderColor { get; }
		public int BorderWidth { get; }

		private Color previousColor;
		private Color currentColor;

		public event EventHandler<NodeClickedEventArgs> NodeClicked;

		public GraphNodeColoredCircle(int id, int x, int y, int radius, Color color, Color hoverColor) : base(id, x, y)
		{
			Radius = radius;
			Color = color;
			HoverColor = hoverColor;
			BorderColor = Color.White;
			BorderWidth = 2;

			currentColor = Color;
		}

		public override void OnPaint(PaintEventArgs e, bool parentDrawn)
		{
			if (parentDrawn || previousColor != currentColor)
			{
				int borderRadius = Radius + BorderWidth;
				e.Graphics.FillEllipse(new SolidBrush(BorderColor), X - borderRadius, Y - borderRadius, 2 * borderRadius, 2 * borderRadius);
				e.Graphics.FillEllipse(new SolidBrush(currentColor), X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
				previousColor = currentColor;
			}
		}

		public bool IsHovered(int mouseX, int mouseY) =>
			Math.Abs(X - mouseX) <= Radius && Math.Abs(Y - mouseY) <= Radius;


#nullable enable
		public void OnNodeClicked(object? sender, NodeClickedEventArgs e) => NodeClicked?.Invoke(sender, e);
		public void OnNodeHoverEnter(object? sender, NodeHoverEnterEventArgs e) => currentColor = HoverColor;
		public void OnNodeHoverLeave(object? sender, NodeHoverLeaveEventArgs e) => currentColor = Color;
#nullable restore
	}
}
