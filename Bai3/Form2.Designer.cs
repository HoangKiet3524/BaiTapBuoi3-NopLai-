namespace Bai3
{
    partial class frmThongTinSinhVien
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
            this.grpThongTinSinhVien = new System.Windows.Forms.GroupBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtDiemTB = new System.Windows.Forms.MaskedTextBox();
            this.txtTenSV = new System.Windows.Forms.MaskedTextBox();
            this.txtMaSV = new System.Windows.Forms.MaskedTextBox();
            this.lblDiemTrungBinh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblTenSinhVien = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTinSinhVien
            // 
            this.grpThongTinSinhVien.Controls.Add(this.cmbKhoa);
            this.grpThongTinSinhVien.Controls.Add(this.rbNu);
            this.grpThongTinSinhVien.Controls.Add(this.rbNam);
            this.grpThongTinSinhVien.Controls.Add(this.txtDiemTB);
            this.grpThongTinSinhVien.Controls.Add(this.txtTenSV);
            this.grpThongTinSinhVien.Controls.Add(this.txtMaSV);
            this.grpThongTinSinhVien.Controls.Add(this.lblDiemTrungBinh);
            this.grpThongTinSinhVien.Controls.Add(this.lblKhoa);
            this.grpThongTinSinhVien.Controls.Add(this.lblGioiTinh);
            this.grpThongTinSinhVien.Controls.Add(this.lblTenSinhVien);
            this.grpThongTinSinhVien.Controls.Add(this.lblMaSinhVien);
            this.grpThongTinSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTinSinhVien.Location = new System.Drawing.Point(50, 12);
            this.grpThongTinSinhVien.Name = "grpThongTinSinhVien";
            this.grpThongTinSinhVien.Size = new System.Drawing.Size(655, 341);
            this.grpThongTinSinhVien.TabIndex = 0;
            this.grpThongTinSinhVien.TabStop = false;
            this.grpThongTinSinhVien.Text = "Thông Tin Sinh Viên";
            this.grpThongTinSinhVien.Enter += new System.EventHandler(this.grpThongTinSinhVien_Enter);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(243, 237);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(283, 33);
            this.cmbKhoa.TabIndex = 10;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(371, 188);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(58, 29);
            this.rbNu.TabIndex = 9;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(243, 185);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(74, 29);
            this.rbNam.TabIndex = 8;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(243, 287);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(283, 30);
            this.txtDiemTB.TabIndex = 7;
            this.txtDiemTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtDiemTB_MaskInputRejected);
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(243, 125);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(283, 30);
            this.txtTenSV.TabIndex = 6;
            this.txtTenSV.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtTenSV_MaskInputRejected);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(243, 63);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(283, 30);
            this.txtMaSV.TabIndex = 5;
            this.txtMaSV.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtMaSV_MaskInputRejected);
            // 
            // lblDiemTrungBinh
            // 
            this.lblDiemTrungBinh.AutoSize = true;
            this.lblDiemTrungBinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiemTrungBinh.Location = new System.Drawing.Point(42, 297);
            this.lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            this.lblDiemTrungBinh.Size = new System.Drawing.Size(75, 20);
            this.lblDiemTrungBinh.TabIndex = 4;
            this.lblDiemTrungBinh.Text = "Điểm TB";
            this.lblDiemTrungBinh.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.BackColor = System.Drawing.SystemColors.Control;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(42, 244);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(47, 20);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa";
            this.lblKhoa.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(42, 194);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới Tính";
            // 
            // lblTenSinhVien
            // 
            this.lblTenSinhVien.AutoSize = true;
            this.lblTenSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSinhVien.Location = new System.Drawing.Point(42, 132);
            this.lblTenSinhVien.Name = "lblTenSinhVien";
            this.lblTenSinhVien.Size = new System.Drawing.Size(113, 20);
            this.lblTenSinhVien.TabIndex = 1;
            this.lblTenSinhVien.Text = "Tên Sinh Viên";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSinhVien.Location = new System.Drawing.Point(42, 70);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(108, 20);
            this.lblMaSinhVien.TabIndex = 0;
            this.lblMaSinhVien.Text = "Mã Sinh Viên";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Location = new System.Drawing.Point(140, 376);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 39);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCapNhat.Location = new System.Drawing.Point(342, 376);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(95, 39);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Fuchsia;
            this.btnThoat.Location = new System.Drawing.Point(531, 376);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 39);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmThongTinSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpThongTinSinhVien);
            this.Name = "frmThongTinSinhVien";
            this.Text = "Thông Tin Sinh Viên";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grpThongTinSinhVien.ResumeLayout(false);
            this.grpThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinSinhVien;
        private System.Windows.Forms.Label lblDiemTrungBinh;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblTenSinhVien;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.MaskedTextBox txtDiemTB;
        private System.Windows.Forms.MaskedTextBox txtTenSV;
        private System.Windows.Forms.MaskedTextBox txtMaSV;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}