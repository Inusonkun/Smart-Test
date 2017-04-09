namespace SmartTest.SystemForm.SUBJECT
{
    partial class Subject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btStaff = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.grbDetail = new System.Windows.Forms.GroupBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtSubjectID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCommit = new System.Windows.Forms.Button();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgrvSubject = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btStaff);
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Location = new System.Drawing.Point(546, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 222);
            this.panel1.TabIndex = 1;
            // 
            // btStaff
            // 
            this.btStaff.BackColor = System.Drawing.Color.Aqua;
            this.btStaff.ForeColor = System.Drawing.Color.Black;
            this.btStaff.Location = new System.Drawing.Point(3, 121);
            this.btStaff.Name = "btStaff";
            this.btStaff.Size = new System.Drawing.Size(83, 23);
            this.btStaff.TabIndex = 6;
            this.btStaff.Text = "CBCT";
            this.btStaff.UseVisualStyleBackColor = false;
            this.btStaff.Click += new System.EventHandler(this.btStaff_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(3, 179);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(83, 23);
            this.btClose.TabIndex = 5;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(3, 150);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(83, 23);
            this.btPrint.TabIndex = 4;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(3, 95);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(83, 23);
            this.btFind.TabIndex = 3;
            this.btFind.Text = "Tìm";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(3, 66);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(83, 23);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(3, 37);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(83, 23);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(3, 8);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // grbDetail
            // 
            this.grbDetail.Controls.Add(this.label4);
            this.grbDetail.Controls.Add(this.txtStaff);
            this.grbDetail.Controls.Add(this.txtKhoa);
            this.grbDetail.Controls.Add(this.txtSubjectName);
            this.grbDetail.Controls.Add(this.txtSubjectID);
            this.grbDetail.Controls.Add(this.label3);
            this.grbDetail.Controls.Add(this.label2);
            this.grbDetail.Controls.Add(this.label1);
            this.grbDetail.Controls.Add(this.btCancel);
            this.grbDetail.Controls.Add(this.btCommit);
            this.grbDetail.Location = new System.Drawing.Point(2, 242);
            this.grbDetail.Name = "grbDetail";
            this.grbDetail.Size = new System.Drawing.Size(637, 111);
            this.grbDetail.TabIndex = 2;
            this.grbDetail.TabStop = false;
            this.grbDetail.Text = "Chi tiết";
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(61, 65);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(137, 20);
            this.txtKhoa.TabIndex = 7;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(328, 26);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(144, 20);
            this.txtSubjectName.TabIndex = 6;
            // 
            // txtSubjectID
            // 
            this.txtSubjectID.Location = new System.Drawing.Point(61, 25);
            this.txtSubjectID.Name = "txtSubjectID";
            this.txtSubjectID.Size = new System.Drawing.Size(137, 20);
            this.txtSubjectID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên môn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã môn";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(545, 63);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(83, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(544, 21);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(83, 23);
            this.btCommit.TabIndex = 0;
            this.btCommit.Text = "Ghi nhận";
            this.btCommit.UseVisualStyleBackColor = true;
            this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
            // 
            // txtStaff
            // 
            this.txtStaff.Location = new System.Drawing.Point(328, 61);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(144, 20);
            this.txtStaff.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CBCT";
            // 
            // dtgrvSubject
            // 
            this.dtgrvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvSubject.Location = new System.Drawing.Point(2, 4);
            this.dtgrvSubject.Name = "dtgrvSubject";
            this.dtgrvSubject.Size = new System.Drawing.Size(541, 222);
            this.dtgrvSubject.TabIndex = 3;
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 353);
            this.Controls.Add(this.dtgrvSubject);
            this.Controls.Add(this.grbDetail);
            this.Controls.Add(this.panel1);
            this.Name = "Subject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "M«n thi";
            this.Load += new System.EventHandler(this.Subject_Load);
            this.panel1.ResumeLayout(false);
            this.grbDetail.ResumeLayout(false);
            this.grbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.GroupBox grbDetail;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtSubjectID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btStaff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.DataGridView dtgrvSubject;
    }
}