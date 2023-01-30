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
    public partial class panel : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlDataAdapter daHOADON=null;
        SqlDataAdapter daNHANVIEN = null;
        DataTable dtNHANVIEN = null;
        SqlDataAdapter daKHACHHANG = null;
        DataTable dtKHACHHANG=null;
        SqlConnection conn;
        DataTable dtHOADON=null;
        bool them;
        void LoadData()
        {
            conn = new SqlConnection(strConnectionString);
            daHOADON = new SqlDataAdapter("SELECT *FROM HoaDon",conn);
            dtHOADON = new DataTable();
            dtHOADON.Clear();
            daHOADON.Fill(dtHOADON);

            //truy vấn dữ liệu nhân viên đưa lên combobox trong dataGV
            daNHANVIEN = new SqlDataAdapter("SELECT MaNV,CONCAT(HO,TEN) as hoten from NhanVien", conn);
            dtNHANVIEN = new DataTable();
            dtNHANVIEN.Clear();
            daNHANVIEN.Fill(dtNHANVIEN);
            (dgvHOADON.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = dtNHANVIEN;
            (dgvHOADON.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "hoten";
            (dgvHOADON.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";

            //truy vấn dữ liệu công ty đưa lên combobox
            SqlDataAdapter daKHACHHANG = new SqlDataAdapter("select *from KhachHang",conn);
            DataTable dtKHACHHANG = new DataTable();
            dtKHACHHANG.Clear();
            daKHACHHANG.Fill(dtKHACHHANG);
            (dgvHOADON.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = dtKHACHHANG;
            (dgvHOADON.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "TenCty";
            (dgvHOADON.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";
            //Đưa dữ liệu vào bảng
            dgvHOADON.DataSource = dtHOADON;
            //
            this.txtMAHD.ResetText();
            this.txtMAKH.ResetText();
            this.txtNGAYLAP.ResetText();
            this.txtNGAYNHAN.ResetText();
            //
            this.groupBox1.Enabled = false;
            this.btnLUU.Enabled = false;
            this.btnHUYBO.Enabled = false;
            //
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnSUA.Enabled = true;
            //
            
        }
        public panel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (them)
            {
                try {
                    conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    SqlCommand sql = new SqlCommand();
                    sql.CommandType = CommandType.Text;
                    sql.Connection = conn;
                    //Lấy giá trị trên panel
                    string mahd=this.txtMAHD.Text.ToString();
                    string makh = this.txtMAKH.SelectedValue.ToString();
                    string manv = this.txtMANV.SelectedValue.ToString();
                    string ngaynhap = this.txtNGAYLAP.Text.ToString();
                    string ngaynhan = this.txtNGAYNHAN.Text.ToString();
                   // this.textBox1.Text = makh;
                    sql.CommandText = System.String.Concat("INSERT into HoaDon values('"+mahd+"','"+makh+"','"+manv+"','"+ngaynhap+"','"+ngaynhan+"')");
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Lưu Thành Công");
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lưu Thất bại");
                }
            }
            if (!them)
            {
                try
                {
                    conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    SqlCommand sql = new SqlCommand();
                    sql.CommandType = CommandType.Text;
                    sql.Connection = conn;
                    //Lấy giá trị trên panel
                    string mahd = this.txtMAHD.Text.ToString();
                    string makh = this.txtMAKH.SelectedValue.ToString();
                    string manv = this.txtMANV.SelectedValue.ToString();
                    string ngaynhap = this.txtNGAYLAP.Text.ToString();
                    string ngaynhan = this.txtNGAYNHAN.Text.ToString();
                    sql.CommandText = System.String.Concat("UPDATE HoaDon SET MaHD='"+mahd+"',MaKH='"+makh+"',MaNV='"+manv+"',NgayLapHD='"+ngaynhap+"',NgayNhanHang='"+ngaynhan+"'where MaHD='"+mahd+"'");
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Lưu Thành Công");
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lưu Thất bại");
                }
            }
            conn.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTROVE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            try {
                int r = dgvHOADON.CurrentCell.RowIndex;
                string mahd = dgvHOADON.Rows[r].Cells[0].Value.ToString();
                conn = new SqlConnection(strConnectionString);
                conn.Open();
                SqlCommand sql = new SqlCommand();
                sql.Connection = conn;
                sql.CommandType = CommandType.Text;
                sql.CommandText=System.String.Concat("DELETE FROM HoaDon where MaHD='"+mahd+"'");
                sql.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Xóa Thành Công");



            }
            catch (SqlException) { MessageBox.Show("Xóa Không Thành Công. Lỗi Rồi"); }
            conn.Close();
        }

        private void btnHUYBO_Click(object sender, EventArgs e)
        {
            //
            this.txtMAHD.ResetText();
            this.txtMAKH.ResetText();
            this.txtNGAYLAP.ResetText();
            this.txtNGAYNHAN.ResetText();
            //
            this.groupBox1.Enabled = false;
            this.btnLUU.Enabled = false;
            this.btnHUYBO.Enabled = false;
            //
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnSUA.Enabled = true;
        }

        private void btnRELOAD_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            them = true;
            conn = new SqlConnection(strConnectionString);
            //lấy vị trí phần tử hiện tại
            //int r = dgvHOADON.CurrentCell.RowIndex;
           // this.txtMAHD.Text = dgvHOADON.Rows[r].Cells[0].Value.ToString();
            //
            daKHACHHANG = new SqlDataAdapter("select * from KhachHang", conn);
            dtKHACHHANG = new DataTable();
            dtKHACHHANG.Clear();
            daKHACHHANG.Fill(dtKHACHHANG);
            this.txtMAKH.DataSource = dtKHACHHANG;
            this.txtMAKH.ValueMember = "MaKH";
            this.txtMAKH.DisplayMember = "TenCty";
            
            
            //
            daNHANVIEN = new SqlDataAdapter("SELECT MaNV,CONCAT(HO,TEN) as hoten from NhanVien",conn);
            dtNHANVIEN = new DataTable();
            dtNHANVIEN.Clear();
            daNHANVIEN.Fill(dtNHANVIEN);
            this.txtMANV.DataSource = dtNHANVIEN;
            this.txtMANV.ValueMember = "MaNV";
            this.txtMANV.DisplayMember = "hoten";
            //
            this.groupBox1.Enabled = true;
            this.txtMAHD.Enabled = true;
            this.txtMAKH.Enabled = true;
            this.txtNGAYLAP.Enabled = true;
            this.txtNGAYNHAN.Enabled = true;
            this.txtMANV.Enabled = true;
            //
            this.btnTHEM.Enabled = false;
            this.btnXOA.Enabled = false;
            this.btnSUA.Enabled = false;
            //
            this.btnLUU.Enabled = true;
            this.txtMAHD.Focus();

            this.txtMAHD.Enabled = true;


            
            

        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            them = false;
            conn = new SqlConnection(strConnectionString);
            //lấy vị trí phần tử hiện tại
            //int r = dgvHOADON.CurrentCell.RowIndex;
            // this.txtMAHD.Text = dgvHOADON.Rows[r].Cells[0].Value.ToString();
            //
            daKHACHHANG = new SqlDataAdapter("select * from KhachHang", conn);
            dtKHACHHANG = new DataTable();
            dtKHACHHANG.Clear();
            daKHACHHANG.Fill(dtKHACHHANG);
            this.txtMAKH.DataSource = dtKHACHHANG;
            this.txtMAKH.ValueMember = "MaKH";
            this.txtMAKH.DisplayMember = "TenCty";


            //
            daNHANVIEN = new SqlDataAdapter("SELECT MaNV,CONCAT(HO,TEN) as hoten from NhanVien", conn);
            dtNHANVIEN = new DataTable();
            dtNHANVIEN.Clear();
            daNHANVIEN.Fill(dtNHANVIEN);
            this.txtMANV.DataSource = dtNHANVIEN;
            this.txtMANV.ValueMember = "MaNV";
            this.txtMANV.DisplayMember = "hoten";
            //
            this.txtMAHD.ResetText();
            //  this.txtMAKH.ResetText();
            this.txtNGAYLAP.ResetText();
            this.txtNGAYNHAN.ResetText();
            //lấy vị trí dòng hiện tại
            int r = dgvHOADON.CurrentCell.RowIndex;
            this.txtMAHD.Text = dgvHOADON.Rows[r].Cells[0].Value.ToString();
            this.txtMAKH.SelectedValue = dgvHOADON.Rows[r].Cells[1].Value.ToString();
            this.txtMANV.SelectedValue = dgvHOADON.Rows[r].Cells[2].Value.ToString();
            this.txtNGAYLAP.Text = dgvHOADON.Rows[r].Cells[3].Value.ToString();
            this.txtNGAYNHAN.Text = dgvHOADON.Rows[r].Cells[4].Value.ToString();
            //
            this.btnLUU.Enabled = true;
            this.groupBox1.Enabled = true;
            this.btnHUYBO.Enabled = true;
            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;
            this.txtMAHD.Enabled = false;

        }
    }
}
