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
    public partial class Form15 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlConnection conn;
        SqlDataAdapter daTP = null, daKHACHHANG = null,daTHANHPHO, daHD=null,daNV=null,daCTHD=null,daSP=null;
        DataTable dtTP = null, dtKHACHHANG = null,dtTHANHPHO,dtHD=null,dtNV=null,dtCTHD=null,dtSP=null;

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            int r = dgvHD.CurrentCell.RowIndex;
            string mahd = dgvHD.Rows[r].Cells[0].Value.ToString();
            daCTHD = new SqlDataAdapter("SELECT *FROM ChiTietHoaDon where MaHD='"+mahd+"'",conn);
            dtCTHD = new DataTable();
            dtCTHD.Clear();
            daCTHD.Fill(dtCTHD);
            dgvCTHD.DataSource=dtCTHD;

            daHD = new SqlDataAdapter("SELECT *FROM HoaDon", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            (dgvCTHD.Columns["MaHD"] as DataGridViewComboBoxColumn).DataSource = dtHD;
            (dgvCTHD.Columns["MaHD"] as DataGridViewComboBoxColumn).ValueMember = "MaHD";
            (dgvCTHD.Columns["MaHD"] as DataGridViewComboBoxColumn).DisplayMember = "MaHD";

            daSP = new SqlDataAdapter("SELECT *FROM SanPham",conn);
            dtSP = new DataTable();
            dtSP.Clear();
            daSP.Fill(dtSP);
            (dgvCTHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DataSource = dtSP;
            (dgvCTHD.Columns["MaSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";
            (dgvCTHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";

            int count = 0;
            count = dgvCTHD.RowCount-1;
            this.txTONGCT.Text = count.ToString();


        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKH.CurrentCell.RowIndex;
            string makh = dgvKH.Rows[r].Cells[0].Value.ToString();

            daHD = new SqlDataAdapter("SELECT *FROM HoaDon WHERE MaKH='" + makh + "'", conn);
            dtHD = new DataTable();
            dtHD.Clear();
            daHD.Fill(dtHD);
            dgvHD.DataSource = dtHD;

            daKHACHHANG = new SqlDataAdapter("SELECT *FROM KhachHang ", conn);
            dtKHACHHANG = new DataTable();
            dtKHACHHANG.Clear();
            daKHACHHANG.Fill(dtKHACHHANG);
            (dgvHD.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = dtKHACHHANG;
            (dgvHD.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";
            (dgvHD.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";

            daNV = new SqlDataAdapter("SELECT MaNV,CONCAT(Ho,Ten) as HoTen FROM NhanVien", conn);
            dtNV = new DataTable();
            dtNV.Clear();
            daNV.Fill(dtNV);
            (dgvHD.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = dtNV;
            (dgvHD.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";
            (dgvHD.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "HoTen";

            int count = 0;
            count = dgvHD.RowCount-1;
            this.txtTONGHD.Text = count.ToString();
            
        }

        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string matp = this.cbTHANHPHO.SelectedValue.ToString();//Lấy Mã Thành Phố

            conn = new SqlConnection(strConnectionString);
            daKHACHHANG = new SqlDataAdapter("SELECT *FROM KhachHang where ThanhPho='"+matp+"'", conn);
            dtKHACHHANG = new DataTable();
            dtKHACHHANG.Clear();
            daKHACHHANG.Fill(dtKHACHHANG);
            dgvKH.DataSource = dtKHACHHANG;

            daTHANHPHO = new SqlDataAdapter("SELECT *FROM ThanhPho", conn);
            dtTHANHPHO = new DataTable();
            dtTHANHPHO.Clear();
            daTHANHPHO.Fill(dtTHANHPHO);

            //Đưa Dữ Liệu lên combobox
            (dgvKH.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DataSource = dtTHANHPHO;
            (dgvKH.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
            (dgvKH.Columns["ThanhPho"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

            int count = 0;
            count= dgvKH.RowCount - 1;
            this.txtTONGKH.Text = count.ToString();
            //----------------------------------------------------------
            //lây mã khách hàng từ bảng khách hàng
          




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daTP = new SqlDataAdapter("SELECT *FROM ThanhPho", conn);
            dtTP = new DataTable();
            dtTP.Clear();
            daTP.Fill(dtTP);
            //đưa dữ liệu vào comboxbox
            this.cbTHANHPHO.DataSource = dtTP;
            this.cbTHANHPHO.ValueMember = "ThanhPho";
            this.cbTHANHPHO.DisplayMember = "TenThanhPho";
        }
    }
}
