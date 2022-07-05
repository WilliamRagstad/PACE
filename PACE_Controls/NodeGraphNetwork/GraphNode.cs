using System.Windows.Forms;

namespace PACE_Controls
{
	public abstract class GraphNode
	{
		public GraphNode(int id, int x, int y)
		{
			ID = id;
			X = x;
			Y = y;
		}

		public int ID { get; }
		public int X { get; }
		public int Y { get; }

		public abstract void OnPaint(PaintEventArgs e);
	}
}
