namespace SmartTest.SystemForm
{
    partial class UserAccount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btFind = new System.Windows.Forms.Button();
            this.btPrint = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.lbUserID = new System.Windows.Forms.Label();
            this.txtbUserID = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtTransaction = new System.Windows.Forms.TextBox();
            this.lbNameStaff = new System.Windows.Forms.Label();
            this.lbTransactionCode = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.lbExpireDate = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.cbChangePass = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCommit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expire_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChangePass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAC_Check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.NameS,
            this.Staff_ID,
            this.Expire_Date,
            this.ChangePass,
            this.MAC_Check});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.btCommit);
            this.groupBox1.Controls.Add(this.cbChangePass);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.lbExpireDate);
            this.groupBox1.Controls.Add(this.lbStaffID);
            this.groupBox1.Controls.Add(this.lbTransactionCode);
            this.groupBox1.Controls.Add(this.lbNameStaff);
            this.groupBox1.Controls.Add(this.txtTransaction);
            this.groupBox1.Controls.Add(this.txtbName);
            this.groupBox1.Controls.Add(this.txtbUserID);
            this.groupBox1.Controls.Add(this.lbUserID);
            this.groupBox1.Location = new System.Drawing.Point(-1, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail Information";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 3);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(12, 32);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(75, 23);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(12, 61);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            // 
            // btFind
            // 
            this.btFind.Location = new System.Drawing.Point(12, 90);
            this.btFind.Name = "btFind";
            this.btFind.Size = new System.Drawing.Size(75, 23);
            this.btFind.TabIndex = 5;
            this.btFind.Text = "Find";
            this.btFind.UseVisualStyleBackColor = true;
            this.btFind.Click += new System.EventHandler(this.btFind_Click);
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(12, 119);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(75, 23);
            this.btPrint.TabIndex = 6;
            this.btPrint.Text = "Print";
            this.btPrint.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(12, 148);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // lbUserID
            // 
            this.lbUserID.AutoSize = true;
            this.lbUserID.Location = new System.Drawing.Point(6, 55);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(43, 13);
            this.lbUserID.TabIndex = 0;
            this.lbUserID.Text = "User ID";
            // 
            // txtbUserID
            // 
            this.txtbUserID.Location = new System.Drawing.Point(66, 52);
            this.txtbUserID.Name = "txtbUserID";
            this.txtbUserID.Size = new System.Drawing.Size(100, 20);
            this.txtbUserID.TabIndex = 1;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(259, 52);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(121, 20);
            this.txtbName.TabIndex = 2;
            // 
            // txtTransaction
            // 
            this.txtTransaction.Location = new System.Drawing.Point(493, 55);
            this.txtTransaction.Name = "txtTransaction";
            this.txtTransaction.Size = new System.Drawing.Size(100, 20);
            this.txtTransaction.TabIndex = 3;
            this.txtTransaction.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbNameStaff
            // 
            this.lbNameStaff.AutoSize = true;
            this.lbNameStaff.Location = new System.Drawing.Point(188, 55);
            this.lbNameStaff.Name = "lbNameStaff";
            this.lbNameStaff.Size = new System.Drawing.Size(35, 13);
            this.lbNameStaff.TabIndex = 4;
            this.lbNameStaff.Text = "Name";
            // 
            // lbTransactionCode
            // 
            this.lbTransactionCode.AutoSize = true;
            this.lbTransactionCode.Location = new System.Drawing.Point(397, 55);
            this.lbTransactionCode.Name = "lbTransactionCode";
            this.lbTransactionCode.Size = new System.Drawing.Size(90, 13);
            this.lbTransactionCode.TabIndex = 5;
            this.lbTransactionCode.Text = "Transaction code";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Location = new System.Drawing.Point(6, 101);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(43, 13);
            this.lbStaffID.TabIndex = 6;
            this.lbStaffID.Text = "Staff ID";
            // 
            // lbExpireDate
            // 
            this.lbExpireDate.AutoSize = true;
            this.lbExpireDate.Location = new System.Drawing.Point(188, 101);
            this.lbExpireDate.Name = "lbExpireDate";
            this.lbExpireDate.Size = new System.Drawing.Size(62, 13);
            this.lbExpireDate.TabIndex = 7;
            this.lbExpireDate.Text = "Expire Date";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(66, 98);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 20);
            this.txtStaffID.TabIndex = 9;
            // 
            // cbChangePass
            // 
            this.cbChangePass.AutoSize = true;
            this.cbChangePass.Location = new System.Drawing.Point(400, 100);
            this.cbChangePass.Name = "cbChangePass";
            this.cbChangePass.Size = new System.Drawing.Size(112, 17);
            this.cbChangePass.TabIndex = 10;
            this.cbChangePass.Text = "Change Password";
            this.cbChangePass.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btAdd);
            this.panel1.Controls.Add(this.btEdit);
            this.panel1.Controls.Add(this.btPrint);
            this.panel1.Controls.Add(this.btDelete);
            this.panel1.Controls.Add(this.btFind);
            this.panel1.Location = new System.Drawing.Point(648, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 182);
            this.panel1.TabIndex = 2;
            // 
            // btCommit
            // 
            this.btCommit.Location = new System.Drawing.Point(661, 45);
            this.btCommit.Name = "btCommit";
            this.btCommit.Size = new System.Drawing.Size(75, 23);
            this.btCommit.TabIndex = 12;
            this.btCommit.Text = "Commit";
            this.btCommit.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(661, 91);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Code
            // 
            this.Code.DataPropertyName = "Code";
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            // 
            // NameS
            // 
            this.NameS.DataPropertyName = "NameS";
            this.NameS.HeaderText = "Name";
            this.NameS.Name = "NameS";
            // 
            // Staff_ID
            // 
            this.Staff_ID.DataPropertyName = "Staff_ID";
            this.Staff_ID.HeaderText = "Staff_ID";
            this.Staff_ID.Name = "Staff_ID";
            // 
            // Expire_Date
            // 
            this.Expire_Date.DataPropertyName = "Expire_Date";
            this.Expire_Date.HeaderText = "Expire_Date";
            this.Expire_Date.Name = "Expire_Date";
            // 
            // ChangePass
            // 
            this.ChangePass.DataPropertyName = "ChangePass";
            this.ChangePass.HeaderText = "Change Pass";
            this.ChangePass.Name = "ChangePass";
            // 
            // MAC_Check
            // 
            this.MAC_Check.DataPropertyName = "MAC_Check";
            this.MAC_Check.HeaderText = "MAC_Check";
            this.MAC_Check.Name = "MAC_Check";
            // 
            // UserAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 321);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.UserAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbExpireDate;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Label lbTransactionCode;
        private System.Windows.Forms.Label lbNameStaff;
        private System.Windows.Forms.TextBox txtTransaction;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbUserID;
        private System.Windows.Forms.Label lbUserID;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btFind;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.CheckBox cbChangePass;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCommit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChangePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAC_Check;
    }
}