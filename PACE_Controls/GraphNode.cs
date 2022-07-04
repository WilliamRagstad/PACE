using PACE_Controls.Events;
using System;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace PACE_Controls
{
	[Serializable]
	public class GraphNode : ICloneable, ISerializable
	{
		public GraphNode() { }
		public GraphNode(int x, int y, int radius, Color color, Color hoverColor)
		{
			X = x;
			Y = y;
			Radius = radius;
			Color = color;
			HoverColor = hoverColor;

			Initialize();
		}

		protected GraphNode(SerializationInfo info, StreamingContext context)
		{
			if (info == null) throw new ArgumentNullException(nameof(info));

			X = info.GetInt32("X");
			Y = info.GetInt32("Y");
			Radius = info.GetInt32("Radius");
			Color = (Color)info.GetValue("Color", typeof(Color));
			HoverColor = (Color)info.GetValue("HoverColor", typeof(Color));

			Initialize();
		}

		private void Initialize()
		{
			currentColor = Color;
			NodeHoverEnter += (sender, e) => currentColor = HoverColor;
			NodeHoverLeave += (sender, e) => currentColor = Color;
		}

		/// <summary>
		/// Implementation as referenced in: https://docs.microsoft.com/en-us/visualstudio/code-quality/ca2240?view=vs-2019
		/// </summary>
		/// <returns>GraphNode object data</returns>
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("X", X);
			info.AddValue("Y", Y);
			info.AddValue("Radius", Radius);
			info.AddValue("Color", Color);
			info.AddValue("HoverColor", HoverColor);
		}

		public int X { get; }
		public int Y { get; }
		public int Radius { get; }
		public Color Color { get; }
		public Color HoverColor { get; }

		private Color currentColor;

		public bool IsInside(Point mousePoint, Point nodePoint)
		{

			return Math.Abs(nodePoint.X - mousePoint.X) <= Radius && Math.Abs(nodePoint.Y - mousePoint.Y) <= Radius;
		}

		/// <summary>
		/// Implementation as referenced in: https://stackoverflow.com/questions/21116554/proper-way-to-implement-icloneable
		/// </summary>
		/// <returns>Clone of a GraphNode object</returns>
		public object Clone()
		{
			return MemberwiseClone();
		}

		public event EventHandler<NodeClickedEventArgs> NodeClicked;
		public event EventHandler<NodeHoverEnterEventArgs> NodeHoverEnter;
		public event EventHandler<NodeHoverLeaveEventArgs> NodeHoverLeave;

		public void OnPaint(PaintEventArgs e)
		{
			e.Graphics.FillEllipse(new SolidBrush(currentColor), X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
		}

		public void OnNodeClicked(object? sender, NodeClickedEventArgs e)
		{
			NodeClicked.Invoke(sender, e);
		}
		public void OnNodeHoverEnter(object? sender, NodeHoverEnterEventArgs e)
		{
			NodeHoverEnter.Invoke(sender, e);
		}
		public void OnNodeHoverLeave(object? sender, NodeHoverLeaveEventArgs e)
		{
			NodeHoverLeave.Invoke(sender, e);
		}
	}
}
