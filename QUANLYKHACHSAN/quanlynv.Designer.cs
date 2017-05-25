namespace QUANLYKHACHSAN
{
    partial class quanlynv
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
            this.components = new System.ComponentModel.Container();
            this.dgvNhan_Vien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMa_NV = new System.Windows.Forms.TextBox();
            this.txtTen_NV = new System.Windows.Forms.TextBox();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.MA_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOI_TINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIA_CHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MA_KHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorNhanVien = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhan_Vien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNhan_Vien
            // 
            this.dgvNhan_Vien.AllowUserToAddRows = false;
            this.dgvNhan_Vien.AllowUserToDeleteRows = false;
            this.dgvNhan_Vien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhan_Vien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA_NV,
            this.TEN_NV,
            this.GIOI_TINH,
            this.SDT,
            this.DIA_CHI,
            this.MA_KHAU});
            this.dgvNhan_Vien.Location = new System.Drawing.Point(18, 214);
            this.dgvNhan_Vien.Name = "dgvNhan_Vien";
            this.dgvNhan_Vien.ReadOnly = true;
            this.dgvNhan_Vien.Size = new System.Drawing.Size(585, 242);
            this.dgvNhan_Vien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SDT:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(407, 72);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(407, 101);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(407, 130);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mật khẩu:";
            // 
            // txtMa_NV
            // 
            this.txtMa_NV.Location = new System.Drawing.Point(68, 47);
            this.txtMa_NV.Name = "txtMa_NV";
            this.txtMa_NV.Size = new System.Drawing.Size(191, 20);
            this.txtMa_NV.TabIndex = 11;
            // 
            // txtTen_NV
            // 
            this.txtTen_NV.Location = new System.Drawing.Point(68, 73);
            this.txtTen_NV.Name = "txtTen_NV";
            this.txtTen_NV.Size = new System.Drawing.Size(191, 20);
            this.txtTen_NV.TabIndex = 12;
            this.txtTen_NV.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Location = new System.Drawing.Point(68, 104);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(47, 17);
            this.rdbNam.TabIndex = 13;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(159, 104);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 14;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(68, 127);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(191, 20);
            this.txtSDT.TabIndex = 15;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(68, 179);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(191, 20);
            this.txtMK.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(68, 153);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(191, 20);
            this.txtDiaChi.TabIndex = 19;
            // 
            // MA_NV
            // 
            this.MA_NV.DataPropertyName = "MANV";
            this.MA_NV.HeaderText = "Mã Nhân Viên";
            this.MA_NV.Name = "MA_NV";
            this.MA_NV.ReadOnly = true;
            // 
            // TEN_NV
            // 
            this.TEN_NV.DataPropertyName = "TENNV";
            this.TEN_NV.HeaderText = "Tên Nhân Viên";
            this.TEN_NV.Name = "TEN_NV";
            this.TEN_NV.ReadOnly = true;
            // 
            // GIOI_TINH
            // 
            this.GIOI_TINH.DataPropertyName = "GIOITINH";
            this.GIOI_TINH.HeaderText = "Giới Tính";
            this.GIOI_TINH.Name = "GIOI_TINH";
            this.GIOI_TINH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // DIA_CHI
            // 
            this.DIA_CHI.DataPropertyName = "DIACHI";
            this.DIA_CHI.HeaderText = "Địa Chỉ";
            this.DIA_CHI.Name = "DIA_CHI";
            this.DIA_CHI.ReadOnly = true;
            // 
            // MA_KHAU
            // 
            this.MA_KHAU.DataPropertyName = "MK";
            this.MA_KHAU.HeaderText = "Mật Khẩu";
            this.MA_KHAU.Name = "MA_KHAU";
            this.MA_KHAU.ReadOnly = true;
            // 
            // errorNhanVien
            // 
            this.errorNhanVien.ContainerControl = this;
            // 
            // quanlynv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 468);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.rdbNu);
            this.Controls.Add(this.rdbNam);
            this.Controls.Add(this.txtTen_NV);
            this.Controls.Add(this.txtMa_NV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNhan_Vien);
            this.Name = "quanlynv";
            this.Text = "quanlynv";
            this.Load += new System.EventHandler(this.quanlynv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhan_Vien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhan_Vien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMa_NV;
        private System.Windows.Forms.TextBox txtTen_NV;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOI_TINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIA_CHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA_KHAU;
        private System.Windows.Forms.ErrorProvider errorNhanVien;
    }
}