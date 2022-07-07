﻿using System;
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
		public Color? PaceButtonPrimary;
		public Color? MenuStripBackground;
		public Color? MenuStripText;
		public void ApplyOnForm(Form form)
		{
			form.BackColor = FormBackgroundPrimary ?? form.BackColor;
			form.ForeColor = FormTextPrimary ?? form.ForeColor;
			foreach (Control c in form.Controls)
				ApplyOnControl(c);
		}

		public void ApplyOnControl(Control control)
		{
			if (control is MenuStrip ms)
			{
				ms.BackColor = MenuStripBackground ?? ms.BackColor;
				ms.ForeColor = MenuStripText ?? ms.ForeColor;
			}
		}
	}
}
