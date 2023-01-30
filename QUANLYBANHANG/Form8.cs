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

    public partial class Form8 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlDataAdapter daCHITIETHD = null,daHOADON=null;
        SqlConnection conn;
        DataTable dtCHITIETHD = null,dtHOADON=null;
        SqlDataAdapter daSANPHAM = null;
        DataTable dtSANPHAM = null;
        bool Them;
        void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daSANPHAM = new SqlDataAdapter("SELECT *FROM SanPham",conn);
            SqlDataAdapter daCHITIETHD = new SqlDataAdapter("SELECT * FROM ChiTietHoaDon",conn);
            DataTable dtCHITIETHD = new DataTable();
            DataTable dtSANPHAM = new DataTable();
            dtSANPHAM.Clear();
            daSANPHAM.Fill(dtSANPHAM);
            dtCHITIETHD.Clear();
            daCHITIETHD.Fill(dtCHITIETHD);

            daHOADON = new SqlDataAdapter("SELECT *FROM HOADON", conn);
            dtHOADON = new DataTable();
            dtHOADON.Clear();
            daHOADON.Fill(dtHOADON);

            (dgvCHITIETHD.Columns["MaHD"] as DataGridViewComboBoxColumn).DataSource = dtHOADON;
            (dgvCHITIETHD.Columns["MaHD"] as DataGridViewComboBoxColumn).DisplayMember = "MaHD";
            (dgvCHITIETHD.Columns["MaHD"] as DataGridViewComboBoxColumn).ValueMember = "MaHD";

            (dgvCHITIETHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DataSource = dtSANPHAM;
            (dgvCHITIETHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (dgvCHITIETHD.Columns["MaSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";

            dgvCHITIETHD.DataSource = dtCHITIETHD;
            //
            this.panel.Enabled = false;
            this.btnHUY.Enabled = false;
            this.btnLUU.Enabled = false;
            //
            this.btnTHEM.Enabled =true;
            this.btnSUA.Enabled = true;
            this.btnXOA.Enabled = true;

            this.txtMHD.ResetText();
            this.txtMSP.ResetText();
            this.txtSL.ResetText();

            
        }
        public Form8()
        {
            InitializeComponent();
        }

        private void btnTROVE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCHITIETHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnRL_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.panel.Enabled = false;
            this.btnHUY.Enabled = false;
            this.btnLUU.Enabled = false;
            //
            this.btnTHEM.Enabled = true;
            this.btnSUA.Enabled = true;
            this.btnXOA.Enabled = true;

            this.txtMHD.ResetText();
            this.txtMSP.ResetText();
            this.txtSL.ResetText();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();

            try
            {
                int r = dgvCHITIETHD.CurrentCell.RowIndex;
                string mahd = dgvCHITIETHD.Rows[r].Cells[0].Value.ToString();
                string masp = dgvCHITIETHD.Rows[r].Cells[1].Value.ToString();
                SqlCommand sql = new SqlCommand();
                sql.CommandType = CommandType.Text;
                sql.Connection = conn;
                sql.CommandText = System.String.Concat("DELETE from ChiTietHoaDon where MaHD='"+mahd+"'and MaSP='"+masp+"'");
                sql.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành Công");
                LoadData();
               // MessageBox.Show("Xóa Thành Công");
            }
            catch(SqlException)
            {
                MessageBox.Show("Xóa Không Thành Công! Lỗi Rồi ");
            }
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            Them = true;

            this.txtSL.ResetText();
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daHOADON = new SqlDataAdapter("SELECT *FROM HoaDon", conn);

            SqlDataAdapter daSANPHAM = new SqlDataAdapter("SELECT *FROM SanPham", conn);
            DataTable dtSANPHAM = new DataTable();
            dtSANPHAM.Clear();
            daSANPHAM.Fill(dtSANPHAM);

            DataTable dtHOADON = new DataTable();
            dtHOADON.Clear();
            daHOADON.Fill(dtHOADON);

            this.txtMHD.DataSource = dtHOADON;
            this.txtMHD.ValueMember = "MaHD";
            this.txtMHD.DisplayMember = "MaHD";

            this.txtMSP.DataSource = dtSANPHAM;
            this.txtMSP.ValueMember = "MaSP";
            this.txtMSP.DisplayMember = "MaSP";


            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;

            this.btnLUU.Enabled = true;
            this.panel.Enabled = true;
            this.txtMSP.Enabled = true;
            this.txtMHD.Enabled = true;

            this.txtMSP.Focus();
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            Them = false;
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daHOADON = new SqlDataAdapter("SELECT *FROM HoaDon", conn);

            SqlDataAdapter daSANPHAM = new SqlDataAdapter("SELECT *FROM SanPham", conn);
            DataTable dtSANPHAM = new DataTable();
            dtSANPHAM.Clear();
            daSANPHAM.Fill(dtSANPHAM);

            DataTable dtHOADON = new DataTable();
            dtHOADON.Clear();
            daHOADON.Fill(dtHOADON);

            this.txtMHD.DataSource = dtHOADON;
            this.txtMHD.ValueMember = "MaHD";
            this.txtMHD.DisplayMember = "MaHD";

            this.txtMSP.DataSource = dtSANPHAM;
            this.txtMSP.ValueMember = "MaSP";
            this.txtMSP.DisplayMember = "MaSP";
            
            int r = dgvCHITIETHD.CurrentCell.RowIndex;
            //
            this.panel.Enabled = true;
            this.btnHUY.Enabled = true;
            this.btnLUU.Enabled = true;
            //
            this.txtMSP.SelectedValue = dgvCHITIETHD.Rows[r].Cells[1].Value.ToString();
            this.txtMHD.SelectedValue = dgvCHITIETHD.Rows[r].Cells[0].Value.ToString();
            this.txtSL.Text = dgvCHITIETHD.Rows[r].Cells[2].Value.ToString();
            //
            this.txtMHD.Enabled = false;
            this.txtMSP.Enabled = false;
            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try {
                    string mahd=this.txtMHD.SelectedValue.ToString();
                    string masp = this.txtMSP.SelectedValue.ToString();
                    string sl = this.txtSL.Text.ToString();
                    //thực hiện câu lệnh sql
                    SqlCommand sql = new SqlCommand();
                    SqlConnection conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    sql.CommandType = CommandType.Text;
                    sql.Connection = conn;
                    sql.CommandText = System.String.Concat("INSERT INTO ChiTietHoaDon Values('"+mahd+"','"+masp+"','"+sl+"')");
                    sql.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Lưu Thành Công");
                    conn.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lưu Thất Bại, Gía Trị Đã Tồn Tại");
                }
            }
            if (!Them)
            {
                try {
                    string mahd = this.txtMHD.SelectedValue.ToString();
                    string masp = this.txtMSP.SelectedValue.ToString();
                    string sl = this.txtSL.Text.ToString();
                    //thực hiện câu lệnh sql
                    SqlCommand sql = new SqlCommand();
                    SqlConnection conn = new SqlConnection(strConnectionString);
                    conn.Open();
                    sql.CommandType = CommandType.Text;
                    sql.Connection = conn;
                    sql.CommandText = System.String.Concat("UPDATE ChiTietHoaDon SET MaHD='"+mahd+"',MaSP='"+masp+"',SoLuong='"+sl+"'");
                    sql.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Lưu Thành Công");
                    conn.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lưu Thất Bại");
                }
            }
        }

        private void txtMHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel_Enter(object sender, EventArgs e)
        {

        }
    }
}
