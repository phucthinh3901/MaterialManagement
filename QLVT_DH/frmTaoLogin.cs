using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DH
{
    public partial class frmTaoLogin : Form
    {
        public frmTaoLogin()
        {
            InitializeComponent();
        }

        private void btnDangki_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được thiếu!", "", MessageBoxButtons.OK);
                txtLogin.Focus();
                return;
            }

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txtPassword.Focus();
                return;
            }
            if (txtRePassword.Text.Trim() == "")
            {
                MessageBox.Show("Nhập lại mật khẩu không được thiếu!", "", MessageBoxButtons.OK);
                txtRePassword.Focus();
                return;
            }
            if (txtPassword.Text != txtRePassword.Text)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng!", "", MessageBoxButtons.OK);
                txtRePassword.Focus();
                return;
            }

            string role = "";
            if (rdoCongty.Checked) role = "CONGTY";
            if (rdoChiNhanh.Checked) role = "CHINHANH";
            if (rdoUser.Checked) role = "USER";


            string strlenh = "EXEC [dbo].[SP_Kt_Loginname] '" + txtLogin.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows == true)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.\nBạn xem lại tên đăng nhập.\n ", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();
            string strlenh1 = "EXEC [dbo].[SP_Kt_Username] '" + cmbNhanvien.SelectedValue + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh1);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (Program.myReader.HasRows == true)
            {
                MessageBox.Show("Mã nhân viên đã tạo login.\nBạn xem lại mã nhân viên.\n ", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();
            Program.ExecSqlNonQuery("EXEC [dbo].[SP_TAOLOGIN] '" + txtLogin.Text + "','" + txtPassword.Text + "','" + cmbNhanvien.SelectedValue + "','" + role + "'");
            MessageBox.Show("Tạo tài khoản thành công", "Thành công", MessageBoxButtons.OK);
            txtLogin.Text = "";
            txtPassword.Text = "";
            txtRePassword.Text = "";

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            qLVT_DATHANGDs.EnforceConstraints = false;

            this.nhanVien1TableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'qLVT_DATHANGDs.NhanVien1' table. You can move, or remove it, as needed.
            this.nhanVien1TableAdapter.Fill(this.qLVT_DATHANGDs.NhanVien1);
            if (Program.mGroup.Equals("CONGTY"))
            {
                rdoCongty.Checked = true;
                rdoChiNhanh.Enabled = rdoUser.Enabled = false;
            }
            if (Program.mGroup.Equals("CHINHANH"))
            {
                rdoCongty.Enabled = false;
                rdoChiNhanh.Enabled = rdoUser.Enabled = true;
            }            
        }

        private void cmbNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
