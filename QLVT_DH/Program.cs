using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT_DH
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr_publisher = "Data Source=DESKTOP-BO97P1U;Initial Catalog=QLVT_DATHANG;Integrated Security=True";
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";
        public static String mHoten = "";
        public static String mGroup = "";
        public static int mChinhanh = 0;
        public static String connstr = "";
        public static String database = "QLVT_DATHANG";
        //de dung ve sau
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123456";
        public static SqlDataReader myreader;
        public static BindingSource bds_dspm = new BindingSource();
        public static frmMain frmChinh;
        public static SqlConnection conn_publisher = new SqlConnection();
        internal static SqlDataReader myReader;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open) ;
            {
                Program.conn.Close();
            }
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID="
                                + Program.mlogin + ";Password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại username và password!\n" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(String cmd)
        {

            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600; 
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                return 0;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Program.conn.Close();
                return e.State; // trang thai raiseeror tu sql server
            }
        }
        public static int ExecSqlNonQuerySiteChu(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn_publisher);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn_publisher.State == ConnectionState.Closed) Program.conn_publisher.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                return 0;
            }
            catch (SqlException e)
            {
                Program.conn_publisher.Close();
                return e.State; // trang thai raiseeror tu sql server, state tu sql server
            }
        }
        public static int KetNoi_CSDLGOC()
        {
            if (conn_publisher != null && conn_publisher.State == ConnectionState.Open)
            {
                conn_publisher.Close();
            }
            try
            {
                conn_publisher.ConnectionString = Program.connstr_publisher;
                conn_publisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối về cơ sở dữ liệu gốc.\nBạn xem lại tên server của Publisher, và tên CSDL trong chuỗi kết nối.\n" + e.Message);
                return 0;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();

            frmChinh = new frmMain();
            Application.Run(frmChinh);




        }
    }
}
