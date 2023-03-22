
namespace QLVT_DH
{
    partial class frmTaoLogin
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
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangki = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoCongty = new System.Windows.Forms.RadioButton();
            this.rdoChiNhanh = new System.Windows.Forms.RadioButton();
            this.rdoUser = new System.Windows.Forms.RadioButton();
            this.cmbNhanvien = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.qLVT_DATHANGDs = new QLVT_DH.QLVT_DATHANGDs();
            this.nhanVien1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVien1TableAdapter = new QLVT_DH.QLVT_DATHANGDsTableAdapters.NhanVien1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(215, 134);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(423, 22);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(215, 217);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(423, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(215, 300);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.Size = new System.Drawing.Size(423, 22);
            this.txtRePassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // btnDangki
            // 
            this.btnDangki.Location = new System.Drawing.Point(221, 417);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(105, 52);
            this.btnDangki.TabIndex = 6;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = true;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(465, 417);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 52);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Chọn Quyền Truy Cập";
            // 
            // rdoCongty
            // 
            this.rdoCongty.AutoSize = true;
            this.rdoCongty.Location = new System.Drawing.Point(244, 363);
            this.rdoCongty.Name = "rdoCongty";
            this.rdoCongty.Size = new System.Drawing.Size(82, 21);
            this.rdoCongty.TabIndex = 9;
            this.rdoCongty.TabStop = true;
            this.rdoCongty.Text = "Công Ty";
            this.rdoCongty.UseVisualStyleBackColor = true;
            // 
            // rdoChiNhanh
            // 
            this.rdoChiNhanh.AutoSize = true;
            this.rdoChiNhanh.Location = new System.Drawing.Point(391, 363);
            this.rdoChiNhanh.Name = "rdoChiNhanh";
            this.rdoChiNhanh.Size = new System.Drawing.Size(93, 21);
            this.rdoChiNhanh.TabIndex = 10;
            this.rdoChiNhanh.TabStop = true;
            this.rdoChiNhanh.Text = "Chi nhánh";
            this.rdoChiNhanh.UseVisualStyleBackColor = true;
            // 
            // rdoUser
            // 
            this.rdoUser.AutoSize = true;
            this.rdoUser.Location = new System.Drawing.Point(556, 363);
            this.rdoUser.Name = "rdoUser";
            this.rdoUser.Size = new System.Drawing.Size(59, 21);
            this.rdoUser.TabIndex = 11;
            this.rdoUser.TabStop = true;
            this.rdoUser.Text = "User";
            this.rdoUser.UseVisualStyleBackColor = true;
            // 
            // cmbNhanvien
            // 
            this.cmbNhanvien.DataSource = this.nhanVien1BindingSource;
            this.cmbNhanvien.DisplayMember = "Ho Va Ten";
            this.cmbNhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanvien.FormattingEnabled = true;
            this.cmbNhanvien.Location = new System.Drawing.Point(215, 65);
            this.cmbNhanvien.Name = "cmbNhanvien";
            this.cmbNhanvien.Size = new System.Drawing.Size(423, 24);
            this.cmbNhanvien.TabIndex = 12;
            this.cmbNhanvien.ValueMember = "MANV";
            this.cmbNhanvien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanvien_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mã nhân viên";
            // 
            // qLVT_DATHANGDs
            // 
            this.qLVT_DATHANGDs.DataSetName = "QLVT_DATHANGDs";
            this.qLVT_DATHANGDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVien1BindingSource
            // 
            this.nhanVien1BindingSource.DataMember = "NhanVien1";
            this.nhanVien1BindingSource.DataSource = this.qLVT_DATHANGDs;
            // 
            // nhanVien1TableAdapter
            // 
            this.nhanVien1TableAdapter.ClearBeforeFill = true;
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 499);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNhanvien);
            this.Controls.Add(this.rdoUser);
            this.Controls.Add(this.rdoChiNhanh);
            this.Controls.Add(this.rdoCongty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Name = "frmTaoLogin";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLVT_DATHANGDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVien1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdoCongty;
        private System.Windows.Forms.RadioButton rdoChiNhanh;
        private System.Windows.Forms.RadioButton rdoUser;
        private System.Windows.Forms.ComboBox cmbNhanvien;
        private System.Windows.Forms.Label label5;
        private QLVT_DATHANGDs qLVT_DATHANGDs;
        private System.Windows.Forms.BindingSource nhanVien1BindingSource;
        private QLVT_DATHANGDsTableAdapters.NhanVien1TableAdapter nhanVien1TableAdapter;
    }
}