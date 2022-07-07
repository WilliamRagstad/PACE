using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointAndClickEngine.Models
{
	[Serializable]
	public class EditorTheme
	{
		public Color FormBackgroundPrimary;
		public Color FormTextPrimary;
		public Color PaceButtonPrimary;

		public void ApplyOnForm(Form form)
		{
			form.BackColor = FormBackgroundPrimary;
			form.ForeColor = FormTextPrimary;
		}
	}
}
