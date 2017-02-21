namespace SmartTest.SystemForm
{
    partial class ListClassForm
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
            this.DG_DSLop = new System.Windows.Forms.DataGridView();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btFilter = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbClassId = new System.Windows.Forms.Label();
            this.tbClassId = new System.Windows.Forms.TextBox();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lnClassName = new System.Windows.Forms.Label();
            this.lbNote = new System.Windows.Forms.Label();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbClassName = new System.Windows.Forms.TextBox();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.plAddClick = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DSLop)).BeginInit();
            this.plAddClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_DSLop
            // 
            this.DG_DSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_DSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.MonHoc,
            this.GhiChu});
            this.DG_DSLop.Location = new System.Drawing.Point(0, 0);
            this.DG_DSLop.Name = "DG_DSLop";
            this.DG_DSLop.Size = new System.Drawing.Size(445, 180);
            this.DG_DSLop.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(451, 0);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(451, 29);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 2;
            this.btEdit.Text = "Sửa";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(451, 58);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Xóa";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(451, 87);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(75, 23);
            this.btFilter.TabIndex = 4;
            this.btFilter.Text = "Lọc";
            this.btFilter.UseVisualStyleBackColor = true;
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(451, 116);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 5;
            this.btPrint.Text = "In";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(451, 145);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 23);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // MaLop
            // 
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // TenLop
            // 
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            // 
            // MonHoc
            // 
            this.MonHoc.HeaderText = "Môn học";
            this.MonHoc.Name = "MonHoc";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // lbClassId
            // 
            this.lbClassId.AutoSize = true;
            this.lbClassId.Location = new System.Drawing.Point(12, 18);
            this.lbClassId.Name = "lbClassId";
            this.lbClassId.Size = new System.Drawing.Size(39, 13);
            this.lbClassId.TabIndex = 7;
            this.lbClassId.Text = "Mã lớp";
            // 
            // tbClassId
            // 
            this.tbClassId.Location = new System.Drawing.Point(67, 15);
            this.tbClassId.Name = "tbClassId";
            this.tbClassId.Size = new System.Drawing.Size(141, 20);
            this.tbClassId.TabIndex = 8;
            // 
            // lbSubject
            // 
            this.lbSubject.AutoSize = true;
            this.lbSubject.Location = new System.Drawing.Point(12, 56);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(49, 13);
            this.lbSubject.TabIndex = 9;
            this.lbSubject.Text = "Môn học";
            // 
            // lnClassName
            // 
            this.lnClassName.AutoSize = true;
            this.lnClassName.Location = new System.Drawing.Point(234, 22);
            this.lnClassName.Name = "lnClassName";
            this.lnClassName.Size = new System.Drawing.Size(43, 13);
            this.lnClassName.TabIndex = 10;
            this.lnClassName.Text = "Tên lớp";
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(234, 59);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(44, 13);
            this.lbNote.TabIndex = 11;
            this.lbNote.Text = "Ghi chú";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(67, 56);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(141, 20);
            this.tbSubject.TabIndex = 12;
            // 
            // tbClassName
            // 
            this.tbClassName.Location = new System.Drawing.Point(283, 18);
            this.tbClassName.Name = "tbClassName";
            this.tbClassName.Size = new System.Drawing.Size(141, 20);
            this.tbClassName.TabIndex = 13;
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(283, 56);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(141, 20);
            this.tbNote.TabIndex = 14;
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(448, 17);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 15;
            this.btOk.Text = "Ghi nhận";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(448, 54);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 16;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // plAddClick
            // 
            this.plAddClick.Controls.Add(this.tbClassId);
            this.plAddClick.Controls.Add(this.btCancel);
            this.plAddClick.Controls.Add(this.lbClassId);
            this.plAddClick.Controls.Add(this.btOk);
            this.plAddClick.Controls.Add(this.lbSubject);
            this.plAddClick.Controls.Add(this.lbNote);
            this.plAddClick.Controls.Add(this.tbNote);
            this.plAddClick.Controls.Add(this.tbSubject);
            this.plAddClick.Controls.Add(this.tbClassName);
            this.plAddClick.Controls.Add(this.lnClassName);
            this.plAddClick.Location = new System.Drawing.Point(0, 186);
            this.plAddClick.Name = "plAddClick";
            this.plAddClick.Size = new System.Drawing.Size(526, 95);
            this.plAddClick.TabIndex = 17;
            // 
            // ListClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 286);
            this.Controls.Add(this.plAddClick);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.DG_DSLop);
            this.Name = "ListClassForm";
            this.Text = "Danh s¸ch lớp";
            ((System.ComponentModel.ISupportInitialize)(this.DG_DSLop)).EndInit();
            this.plAddClick.ResumeLayout(false);
            this.plAddClick.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_DSLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbClassId;
        private System.Windows.Forms.TextBox tbClassId;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lnClassName;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbClassName;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Panel plAddClick;
    }
}