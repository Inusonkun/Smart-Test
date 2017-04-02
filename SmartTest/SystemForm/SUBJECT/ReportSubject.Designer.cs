namespace SmartTest.SystemForm.SUBJECT
{
    partial class ReportSubject
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crtrpSubject = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtrpSubject
            // 
            this.crtrpSubject.ActiveViewIndex = -1;
            this.crtrpSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtrpSubject.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtrpSubject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtrpSubject.ForeColor = System.Drawing.Color.Black;
            this.crtrpSubject.Location = new System.Drawing.Point(0, 0);
            this.crtrpSubject.Name = "crtrpSubject";
            this.crtrpSubject.Size = new System.Drawing.Size(769, 340);
            this.crtrpSubject.TabIndex = 0;
            this.crtrpSubject.Load += new System.EventHandler(this.crtrpSubject_Load);
            // 
            // ReportSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(769, 340);
            this.Controls.Add(this.crtrpSubject);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "ReportSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M«n thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtrpSubject;
    }
}