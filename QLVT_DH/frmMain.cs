using DevExpress.XtraBars;
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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            rbbBaoCao.Visible = rbbDanhSach.Visible = false;
            BtnCreate.Enabled = btnLogout.Enabled = btnLoginn.Enabled = false;
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void PhanQuyen()
        {
            if (Program.mGroup.Equals("CONGTY"))
            {
                
            }
            else if (Program.mGroup.Equals("CHINHANH"))
            {
                rbbDanhSach.Visible = rbbBaoCao.Visible =  true;
                BtnCreate.Enabled = btnLogout.Enabled = true;

            }
            else if (Program.mGroup.Equals("USER"))
            {
                
            }
        }
      
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnLoginn_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLoginn_ItemClick_1(object sender, ItemClickEventArgs e)
        {
      
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
           
            MANV.Text = "MÃ NV: " + Program.username;
            HOTEN.Text = "Họ tên nhân viên: " + Program.mHoten.Trim('\r', '\n');//remove newlines from both sides of a string
            NHOM.Text = "Nhóm: " + Program.mGroup;
            rbbBaoCao.Visible = rbbDanhSach.Visible = btnLogout.Enabled = BtnCreate.Enabled = true;
            
        }

        private void NHOM_Click(object sender, EventArgs e)
        {

        }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           //   btnTaoTK.Visible = false;
        }
        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất khỏi tài khoản \n- Mã NV: " + Program.username + "\n- Tên: " + Program.mHoten + "\n- Nhóm: " + Program.mGroup, "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
                // Clear user info in status bar
                Program.frmChinh.MANV.Text = "Mã : trống";
                Program.frmChinh.HOTEN.Text = "Họ tên: trống";
                Program.frmChinh.NHOM.Text = "Nhóm: trống";
                rbbDanhSach.Visible = rbbBaoCao.Visible = btnTaoTK.Enabled = btnLogout.Enabled = BtnCreate.Enabled = btnLoginn.Enabled = false;
                rbbHeThong.Visible = btnLoginn.Enabled  = true;
            }
            Form frm = this.CheckExists(typeof(frmDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                frmDangNhap f = new frmDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void BtnCreate_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmTaoLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmTaoLogin f = new frmTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}