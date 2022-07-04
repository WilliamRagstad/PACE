using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;
using System.Windows.Forms;
using PACE_Controls.Events;

namespace PACE_Controls
{
	[Serializable]
	public class NodeGraphNetwork : Control, ISerializable, ICloneable
	{
		public List<GraphNode> GraphNodes { get; private set; }
		public NodeGraphNetwork()
		{
			GraphNodes = new List<GraphNode>();
			MouseMove += HandleMouseMove;
		}

		protected NodeGraphNetwork(SerializationInfo info, StreamingContext context)
		{
			if (info == null) throw new ArgumentNullException(nameof(info));
			info.AddValue("GraphNodes", GraphNodes);
		}

		public GraphNode CreateNode(int x, int y, int radius, Color color, Color hoverColor)
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
#nullable enable
		private GraphNode? getNodeByMousePosition()
		{
			Point mousePoint = new Point(MousePosition.X, MousePosition.Y);
			return GraphNodes.Find(n => n.IsInside(mousePoint, PointToScreen(new Point(n.X, n.Y))));
		}
#nullable restore
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
			found?.OnNodeClicked(this, new NodeClickedEventArgs(found));
			base.OnClick(e);
		}

		private GraphNode _previousHoveredNode;

		private void HandleMouseMove(object sender, MouseEventArgs e)
		{
			GraphNode found = getNodeByMousePosition();
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
