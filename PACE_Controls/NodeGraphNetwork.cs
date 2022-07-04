using PACE_Controls.Events;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace PACE_Controls
{
	[Serializable]
	public class NodeGraphNetwork : Control, ISerializable, ICloneable
	{
		public List<GraphNode> GraphNodes { get; private set; }
		public NodeGraphNetwork()
		{
			GraphNodes = new List<GraphNode>();
			CreateNode();
		}

		protected NodeGraphNetwork(SerializationInfo info, StreamingContext context)
		{
			if (info == null) throw new ArgumentNullException(nameof(info));
			info.AddValue("GraphNodes", GraphNodes);
		}

		public GraphNode CreateNode()
		{
			var r = new Random();
			int x = r.Next(Width);
			int y = r.Next(Height);
			Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
			Color hc = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
			int radius = r.Next(10) + 10;
			GraphNode node = new GraphNode(x, y, radius, c, hc);
			GraphNodes.Add(node);
			OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
			return node;
		}
		public GraphNode CreateNode(int x, int y)
		{
			var r = new Random();
			Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
			Color hc = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
			int radius = r.Next(10) + 10;
			GraphNode node = new GraphNode(x, y, radius, c, hc);
			GraphNodes.Add(node);
			OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
			return node;
		}
		public GraphNode CreateNode(int x, int y, Color color, Color hoverColor)
		{
			var r = new Random();
			int radius = r.Next(10) + 10;
			GraphNode node = new GraphNode(x, y, radius, color, hoverColor);
			GraphNodes.Add(node);
			OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
			return node;
		}
		public GraphNode CreateNode(int x, int y, Color color, Color hoverColor, int radius)
		{
			GraphNode node = new GraphNode(x, y, radius, color, hoverColor);
			GraphNodes.Add(node);
			OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
			return node;
		}
		public void AddNode(GraphNode node)
		{
			GraphNodes.Add(node);
			OnPaint(new PaintEventArgs(CreateGraphics(), ClientRectangle));
		}

		private GraphNode? getNodeByMousePosition()
		{
			Point mousePoint = new Point(MousePosition.X, MousePosition.Y);
			return GraphNodes.Find(n => n.IsInside(mousePoint, PointToScreen(new Point(n.X, n.Y))));
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			GraphNodes.ForEach(n => n.OnPaint(e));
		}

		/// <summary>
		/// Listen for general click events in the control and
		/// calculate if the user clicked on a GraphNode.
		/// </summary>
		/// <param name="_">Ignored event args</param>
		protected override void OnClick(EventArgs e)
		{
			GraphNode found = getNodeByMousePosition();
			if (found != null) found.OnNodeClicked(this, new NodeClickedEventArgs(found));
			base.OnClick(e);
		}

		private GraphNode previousHoveredNode;
		protected override void OnMouseMove(MouseEventArgs e)
		{
			GraphNode found = getNodeByMousePosition();
			if (found != previousHoveredNode)
			{
				if (previousHoveredNode != null) previousHoveredNode.OnNodeHoverLeave(this, new NodeHoverLeaveEventArgs(found));
				if (found != null) found.OnNodeHoverEnter(this, new NodeHoverEnterEventArgs(found));
			}
			base.OnMouseMove(e);
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			GraphNodes = (List<GraphNode>)info.GetValue("GraphNodes", typeof(List<GraphNode>));
		}
	}
}
