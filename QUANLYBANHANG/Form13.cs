using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QUANLYBANHANG
{
    public partial class Form13 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlConnection conn;
        SqlDataAdapter daNV = null,daHD=null,daKH=null;
        DataTable dtNV = null,dtHD=null,dtKH=null;
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daNV = new SqlDataAdapter("SELECT MaNV,CONCAT(Ho,Ten) as HoTen FROM NhanVien",conn);
            dtNV = new DataTable();
            dtNV.Clear();
            daNV.Fill(dtNV);

            this.cbNV.DataSource = dtNV;
            this.cbNV.ValueMember = "MaNV";
            this.cbNV.DisplayMember = "HoTen";
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string manv = this.cbNV.SelectedValue.ToString();
            conn = new SqlConnection(strConnectionString);
            daHD = new SqlDataAdapter("SELECT *FROM HoaDon WHERE MaNV='" + manv + "'", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            dgvHDTHEONV.DataSource = dtHD;

            daKH = new SqlDataAdapter("SELECT *FROM KhachHang ", conn);
            dtKH = new DataTable();
            dtKH.Clear();
            daKH.Fill(dtKH);
            (dgvHDTHEONV.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = dtKH;
            (dgvHDTHEONV.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";
            (dgvHDTHEONV.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";

            daNV = new SqlDataAdapter("SELECT MaNV,CONCAT(Ho,Ten) as HoTen FROM NhanVien", conn);
            dtNV = new DataTable();
            dtNV.Clear();
            daNV.Fill(dtNV);
            (dgvHDTHEONV.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = dtNV;
            (dgvHDTHEONV.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";
            (dgvHDTHEONV.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";

            int count = 0;
            count = dgvHDTHEONV.RowCount - 1;
            this.txtTONGHD.Text = count.ToString();

        }
    }
}
