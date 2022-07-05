
namespace PACE_Controls
{
    partial class UserControl1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nodeGraphNetwork1 = new PACE_Controls.NodeGraphNetwork.NodeGraphNetwork();
            this.SuspendLayout();
            // 
            // nodeGraphNetwork1
            // 
            this.nodeGraphNetwork1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nodeGraphNetwork1.Location = new System.Drawing.Point(106, 75);
            this.nodeGraphNetwork1.Name = "nodeGraphNetwork1";
            this.nodeGraphNetwork1.Size = new System.Drawing.Size(119, 82);
            this.nodeGraphNetwork1.TabIndex = 0;
            this.nodeGraphNetwork1.Text = "nodeGraphNetwork1";
            this.nodeGraphNetwork1.Click += new System.EventHandler(this.nodeGraphNetwork1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nodeGraphNetwork1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(541, 288);
            this.ResumeLayout(false);

        }

        #endregion

        private NodeGraphNetwork.NodeGraphNetwork nodeGraphNetwork1;
    }
}
