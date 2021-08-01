using System.Windows.Forms;

namespace PointAndClickEngine.Util
{
    public class ExtendedForm : Form
    {
        /// <summary>
        /// Switch to another window form
        /// </summary>
        /// <param name="next">The next form to be displayed</param>
        /// <param name="showAfter">If false, close the current form for good. If true, re-display the form after the next form has been closed.</param>
        public void SwitchTo(Form next, bool showAfter = false)
        {
            Hide();
            new MainEditorForm().ShowDialog();
            if (showAfter) Show();
            else Close();
        }
    }
}
