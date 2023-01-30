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
    public partial class Form14 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlConnection conn;
        SqlDataAdapter daHD=null, daSANPHAM=null, daCHITIETHD=null;
        DataTable dtHD = null,dtSANPHAM=null, dtCHITIETHD=null;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daHD = new SqlDataAdapter("SELECT *FROM HoaDon", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            this.cmHOADON.DataSource = dtHD;
            this.cmHOADON.ValueMember = "MaHD";
            this.cmHOADON.DisplayMember = "MaHD";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            string mahd = this.cmHOADON.Text.ToString();
            daSANPHAM = new SqlDataAdapter("SELECT *FROM SanPham", conn);
            daCHITIETHD = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon where MaHD='"+mahd+"'", conn);
            dtCHITIETHD = new DataTable();
            dtSANPHAM = new DataTable();
            dtSANPHAM.Clear();
            daSANPHAM.Fill(dtSANPHAM);
            dtCHITIETHD.Clear();
            daCHITIETHD.Fill(dtCHITIETHD);

            conn = new SqlConnection(strConnectionString);
            daHD = new SqlDataAdapter("SELECT *FROM HoaDon", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);


            (dgvHDTHEOCT.Columns["MaHD"] as DataGridViewComboBoxColumn).DataSource = dtHD;
            (dgvHDTHEOCT.Columns["MaHD"] as DataGridViewComboBoxColumn).DisplayMember = "MaHD";
            (dgvHDTHEOCT.Columns["MaHD"] as DataGridViewComboBoxColumn).ValueMember = "MaHD";

            (dgvHDTHEOCT.Columns["MaSP"] as DataGridViewComboBoxColumn).DataSource = dtSANPHAM;
            (dgvHDTHEOCT.Columns["MaSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (dgvHDTHEOCT.Columns["MaSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";

            dgvHDTHEOCT.DataSource = dtCHITIETHD;
        }
    }
}
