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
    
    public partial class Form12 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlConnection conn;
        SqlDataAdapter daSP = null;
        DataTable dtSP = null;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daSP = new SqlDataAdapter("SELECT *FROM SanPham",conn);
            dtSP = new DataTable();
            dtSP.Clear();
            daSP.Fill(dtSP);
            this.cbSP.DataSource = dtSP;
            this.cbSP.ValueMember = "MaSP";
            this.cbSP.DisplayMember = "MaSP";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               // dgvCHITIETHD = null;
                string masp = this.cbSP.SelectedValue.ToString();
                SqlConnection conn = new SqlConnection(strConnectionString);
                SqlDataAdapter daHD = new SqlDataAdapter("SELECT distinct HoaDon.MaHD, MaKH, MaNV, NgayLapHD, NgayNhanHang from HoaDon, ChiTietHoaDon where HoaDon.MaHD = ChiTietHoaDon.MaHD and MaSP='"+masp+"'",conn);
                DataTable dtHD = new DataTable();
                dtHD.Clear();
                daHD.Fill(dtHD);
                dgvCHITIETHD.DataSource = dtHD;
                //
                SqlDataAdapter daKHACHHANG = new SqlDataAdapter("SELECT *FROM KHACHHANG ", conn);
               // SqlDataAdapter daCHITIETHD = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon where MaSP='" + masp + "'", conn);
                DataTable dtKHACHHANG = new DataTable();
                //DataTable dtSANPHAM = new DataTable();
                dtKHACHHANG.Clear();
                daKHACHHANG.Fill(dtKHACHHANG);
                (dgvCHITIETHD.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = dtKHACHHANG;
                (dgvCHITIETHD.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember ="TenCty";
                (dgvCHITIETHD.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember ="MaKH";
                // dtCHITIETHD.Clear();
                // daCHITIETHD.Fill(dtCHITIETHD);

                //  SqlConnection conn = new SqlConnection(strConnectionString);
                SqlDataAdapter daNHANVIEN= new SqlDataAdapter("SELECT MaNV, CONCAT(Ho,Ten) as HoTen from NhanVien", conn);
                DataTable dtNHANVIEN = new DataTable();
                dtNHANVIEN.Clear();
                daNHANVIEN.Fill(dtNHANVIEN);
                (dgvCHITIETHD.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = dtNHANVIEN;
                (dgvCHITIETHD.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";
                (dgvCHITIETHD.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";
                //  dgvCHITIETHD.DataSource = dtHOADON;
                //đếm số lượng hóa đơn
                int count = 0;
                count = dgvCHITIETHD.RowCount - 1;
                this.textBox1.Text = count.ToString();
            }
            catch (SqlException) {
                MessageBox.Show("Lỗi rồi");
            }
        }
    }
}
