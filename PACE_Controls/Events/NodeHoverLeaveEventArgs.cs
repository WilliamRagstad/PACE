using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACE_Controls.Events
{
    public class NodeHoverLeaveEventArgs : EventArgs
    {

        public NodeHoverLeaveEventArgs(GraphNode node)
        {
            Node = node;
        }

        public GraphNode Node { get; }
    }
}
