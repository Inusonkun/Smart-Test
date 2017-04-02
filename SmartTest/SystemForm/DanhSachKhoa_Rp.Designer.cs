namespace SmartTest.SystemForm
{
    partial class DanhSachKhoa_Rp
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
            this.crtrpDanhSachKhoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crtrpDanhSachKhoa
            // 
            this.crtrpDanhSachKhoa.ActiveViewIndex = -1;
            this.crtrpDanhSachKhoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtrpDanhSachKhoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtrpDanhSachKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtrpDanhSachKhoa.Location = new System.Drawing.Point(0, 0);
            this.crtrpDanhSachKhoa.Name = "crtrpDanhSachKhoa";
            this.crtrpDanhSachKhoa.Size = new System.Drawing.Size(732, 381);
            this.crtrpDanhSachKhoa.TabIndex = 0;
            this.crtrpDanhSachKhoa.Load += new System.EventHandler(this.crtrpDanhSachKhoa_Load);
            // 
            // DanhSachKhoa_Rp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 381);
            this.Controls.Add(this.crtrpDanhSachKhoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DanhSachKhoa_Rp";
            this.Text = "Danh s¸ch khoa";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtrpDanhSachKhoa;
    }
}