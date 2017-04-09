namespace SmartTest.SystemForm
{
    partial class DSKhoaForm
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
            this.pnControl = new System.Windows.Forms.Panel();
            this.btSubject = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.lbTenKhoa = new System.Windows.Forms.Label();
            this.lbMaKhoa = new System.Windows.Forms.Label();
            this.dtgrDSKhoa = new System.Windows.Forms.DataGridView();
            this.pnControl.SuspendLayout();
            this.grbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDSKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // pnControl
            // 
            this.pnControl.Controls.Add(this.btSubject);
            this.pnControl.Controls.Add(this.btClose);
            this.pnControl.Controls.Add(this.btPrint);
            this.pnControl.Controls.Add(this.btFind);
            this.pnControl.Controls.Add(this.btDelete);
            this.pnControl.Controls.Add(this.btEdit);
            this.pnControl.Controls.Add(this.btAdd);
            this.pnControl.Location = new System.Drawing.Point(560, 3);
            this.pnControl.Name = "pnControl";
            this.pnControl.Size = new System.Drawing.Size(108, 224);
            this.pnControl.TabIndex = 1;
            // 
            // btSubject
            // 
            this.btSubject.BackColor = System.Drawing.Color.Aquamarine;
            this.btSubject.Location = new System.Drawing.Point(10, 123);
            this.btSubject.Name = "btSubject";
            this.btSubject.Size = new System.Drawing.Size(95, 25);
            this.btSubject.TabIndex = 6;
            this.btSubject.Text = "Môn thi";
            this.btSubject.UseVisualStyleBackColor = false;
            this.btSubject.Click += new System.EventHandler(this.btSubject_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(10, 185);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(95, 25);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(10, 154);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(95, 25);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(10, 93);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(95, 25);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(10, 62);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(95, 25);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(10, 33);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(95, 25);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(10, 4);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(95, 25);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.btCancel);
            this.grbDetail.Controls.Add(this.btCommit);
            this.grbDetail.Controls.Add(this.txtGhiChu);
            this.grbDetail.Controls.Add(this.txtTenKhoa);
            this.grbDetail.Controls.Add(this.txtMaKhoa);
            this.grbDetail.Controls.Add(this.lbGhiChu);
            this.grbDetail.Controls.Add(this.lbTenKhoa);
            this.grbDetail.Controls.Add(this.lbMaKhoa);
            this.grbDetail.Location = new System.Drawing.Point(2, 233);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(666, 99);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            this.grbDetail.Enter += new System.EventHandler(this.grbDetail_Enter);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(574, 46);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(86, 28);
            this.btCancel.TabIndex = 7;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(574, 16);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(86, 28);
            this.btCommit.TabIndex = 6;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(114, 67);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(438, 20);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(293, 21);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(259, 20);
            this.txtTenKhoa.TabIndex = 4;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(114, 23);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(92, 20);
            this.txtMaKhoa.TabIndex = 3;
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Location = new System.Drawing.Point(59, 70);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(44, 13);
            this.lbGhiChu.TabIndex = 2;
            this.lbGhiChu.Text = "Ghi chú";
            // 
            // lbTenKhoa
            // 
            this.lbTenKhoa.AutoSize = true;
            this.lbTenKhoa.Location = new System.Drawing.Point(234, 24);
            this.lbTenKhoa.Name = "lbTenKhoa";
            this.lbTenKhoa.Size = new System.Drawing.Size(53, 13);
            this.lbTenKhoa.TabIndex = 1;
            this.lbTenKhoa.Text = "Tên khoa";
            // 
            // lbMaKhoa
            // 
            this.lbMaKhoa.AutoSize = true;
            this.lbMaKhoa.Location = new System.Drawing.Point(59, 26);
            this.lbMaKhoa.Name = "lbMaKhoa";
            this.lbMaKhoa.Size = new System.Drawing.Size(49, 13);
            this.lbMaKhoa.TabIndex = 0;
            this.lbMaKhoa.Text = "Mã khoa";
            // 
            // dtgrDSKhoa
            // 
            this.dtgrDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrDSKhoa.Location = new System.Drawing.Point(2, 3);
            this.dtgrDSKhoa.Name = "dtgrDSKhoa";
            this.dtgrDSKhoa.Size = new System.Drawing.Size(552, 224);
            this.dtgrDSKhoa.TabIndex = 3;
            // 
            // DSKhoaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 335);
            this.Controls.Add(this.dtgrDSKhoa);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.pnControl);
            this.Name = "DSKhoaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh s¸ch khoa";
            this.Load += new System.EventHandler(this.DSKhoaForm_Load);
            this.pnControl.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrDSKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnControl;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.Label lbTenKhoa;
        private System.Windows.Forms.Label lbMaKhoa;
        private System.Windows.Forms.Button btSubject;
        private System.Windows.Forms.DataGridView dtgrDSKhoa;
    }
}