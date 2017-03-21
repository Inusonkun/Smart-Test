namespace SmartTest.SystemForm
{
    partial class ReportUAListForm
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
            this.crtrp_ReportUAccList = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtrp_ReportUAccList
            // 
            this.crtrp_ReportUAccList.ActiveViewIndex = -1;
            this.crtrp_ReportUAccList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtrp_ReportUAccList.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtrp_ReportUAccList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtrp_ReportUAccList.Location = new System.Drawing.Point(0, 0);
            this.crtrp_ReportUAccList.Name = "crtrp_ReportUAccList";
            this.crtrp_ReportUAccList.Size = new System.Drawing.Size(812, 261);
            this.crtrp_ReportUAccList.TabIndex = 0;
            this.crtrp_ReportUAccList.Load += new System.EventHandler(this.crtrp_ReportUAccList_Load);
            // 
            // ReportUAListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 261);
            this.Controls.Add(this.crtrp_ReportUAccList);
            this.Name = "ReportUAListForm";
            this.Text = "User Account List";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtrp_ReportUAccList;
    }
}