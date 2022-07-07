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
		public Color? MenuStripBorder;
		public Color? TreeViewBackground;

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
			else if (control is ToolStrip ts)
			{
				ts.BackColor = MenuStripBackground ?? ts.BackColor;
				ts.ForeColor = MenuStripText ?? ts.ForeColor;
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
			else if (control is SplitContainer sc)
			{
				sc.BackColor = FormBackgroundPrimary ?? sc.BackColor;
				sc.ForeColor = FormTextPrimary ?? sc.ForeColor;
				foreach (Control c in sc.Panel1.Controls)
					ApplyOnControl(c);
				foreach (Control c in sc.Panel2.Controls)
					ApplyOnControl(c);
			}
			else if (control is TreeView tw)
			{
				tw.BackColor = TreeViewBackground ?? tw.BackColor;
				tw.ForeColor = FormTextPrimary ?? tw.ForeColor;
			}
			else if (control is TabControl tc)
			{
				tc.BackColor = FormBackgroundPrimary ?? tc.BackColor;
				tc.ForeColor = FormTextPrimary ?? tc.ForeColor;
				foreach (TabPage p in tc.TabPages)
					ApplyOnControl(p);
			}
			else if (control is TabPage tp)
			{
				tp.BackColor = FormBackgroundPrimary ?? tp.BackColor;
				tp.ForeColor = FormTextPrimary ?? tp.ForeColor;
			}
		}
		#endregion
	}
}
