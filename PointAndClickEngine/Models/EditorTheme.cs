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
		public Color? FormBackgroundPrimary;
		public Color? FormTextPrimary;
		public Color? ButtonBackgroundPrimary;
		public Color? ButtonBorder;
		public Color? MenuStripBackground;
		public Color? MenuStripText;

		#region Theme Application Logic
		public void ApplyOnForm(Form form)
		{
			form.BackColor = FormBackgroundPrimary ?? form.BackColor;
			form.ForeColor = FormTextPrimary ?? form.ForeColor;
			foreach (Control c in form.Controls)
				ApplyOnControl(c);
		}

		public void ApplyOnControl(Control control)
		{
			var tag = (string)control.Tag ?? "";
			if (tag.Contains("custom")) return;

			if (control is MenuStrip ms)
			{
				ms.BackColor = MenuStripBackground ?? ms.BackColor;
				ms.ForeColor = MenuStripText ?? ms.ForeColor;
			}
			else if (control is Label l)
			{
				l.ForeColor = FormTextPrimary ?? l.ForeColor;
			}
			else if (control is Button btn)
			{
				btn.ForeColor = FormTextPrimary ?? btn.ForeColor;
				btn.BackColor = ButtonBackgroundPrimary ?? btn.BackColor;
				btn.FlatAppearance.BorderColor = ButtonBorder ?? btn.FlatAppearance.BorderColor;
			}
		}
		#endregion
	}
}
