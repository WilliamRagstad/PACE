using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PACE_Controls
{
	public partial class ListViewExt : ListView
	{
		public ListViewExt()
		{
			InitializeComponent();
		}

		public ListViewExt(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
	}
}
