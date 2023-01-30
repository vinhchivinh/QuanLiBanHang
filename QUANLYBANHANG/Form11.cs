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
    public partial class Form11 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlConnection conn;
        SqlDataAdapter daHD = null, daKH = null, daNV = null;
        DataTable dtHD = null, dtKH = null, dtNV = null;

        private void btnOK_Click(object sender, EventArgs e)
        {
            string maKH = this.cmbKH.SelectedValue.ToString();
            conn = new SqlConnection(strConnectionString);
            daHD = new SqlDataAdapter("SELECT *FROM HoaDon WHERE MaKH='" + maKH + "'", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            dgvHDTHEOKH.DataSource = dtHD;

            daKH = new SqlDataAdapter("SELECT *FROM KhachHang ",conn);
            dtKH = new DataTable();
            dtKH.Clear();
            daKH.Fill(dtKH);
            (dgvHDTHEOKH.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = dtKH;
            (dgvHDTHEOKH.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember="MaKH";
            (dgvHDTHEOKH.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";

            daNV = new SqlDataAdapter("SELECT MaNV,CONCAT(Ho,Ten) as HoTen FROM NhanVien", conn);
            dtNV = new DataTable();
            dtNV.Clear();
            daNV.Fill(dtNV);
            (dgvHDTHEOKH.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = dtNV;
            (dgvHDTHEOKH.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";
            (dgvHDTHEOKH.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";

            int count = 0;
            count = dgvHDTHEOKH.RowCount-1;
            this.txtTONGHD.Text = count.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvHDTHEOKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daKH = new SqlDataAdapter("Select *from KhachHang", conn);
            dtKH = new DataTable();
            dtKH.Clear();
            daKH.Fill(dtKH);
            this.cmbKH.DataSource = dtKH;
            this.cmbKH.ValueMember = "MaKH";
            this.cmbKH.DisplayMember = "TenCty";
        }

        public Form11()
        {
            InitializeComponent();
        }

        private void cmbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
