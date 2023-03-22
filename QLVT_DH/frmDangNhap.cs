using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT_DH
{
    public partial class frmDangNhap : Form
    {
       
        private void layDSPM(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn_publisher.State == ConnectionState.Closed)
                Program.conn_publisher.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Program.conn_publisher);
            da.Fill(dt);
            Console.WriteLine(dt);
            foreach (DataRow dataRow in dt.Rows)
            {
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
            }
            Program.conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbCN.DataSource = Program.bds_dspm;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            Console.WriteLine(cmbCN.ValueMember);

        }
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi_CSDLGOC() == 0) return;
            layDSPM("SELECT * FROM Get_subcribes");
            cmbCN.SelectedIndex = 1; cmbCN.SelectedIndex = 0;
        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbCN.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Login name và password không được để trống", "", MessageBoxButtons.OK);
                return;
            }
            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return;
            Program.mChinhanh = cmbCN.SelectedIndex;
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            String strLenh = "EXEC SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.mlogin + "'";

            Program.myreader = Program.ExecSqlDataReader(strLenh);
            if (Program.myreader == null) return;
            Program.myreader.Read();

            Program.username = Program.myreader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu.\nBạn xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }
            Program.mHoten = Program.myreader.GetString(1);
            Program.mGroup = Program.myreader.GetString(2);
            Program.myreader.Close();
            Program.conn.Close();
            MessageBox.Show("Đăng nhập thành công tài khoản \n- Mã NV: " + Program.username + "\n- Tên: " + Program.mHoten + "\n- Nhóm: " + Program.mGroup, "", MessageBoxButtons.OK);
            Program.frmChinh.HienThiMenu();
            Close();
        }

        private void txtTK_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
