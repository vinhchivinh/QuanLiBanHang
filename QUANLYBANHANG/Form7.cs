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

    public partial class Form7 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlDataAdapter daSANPHAM = null;
        SqlConnection conn;
        DataTable dtSANPHAM = null;
        bool Them;
        void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daSANPHAM = new SqlDataAdapter("select *from SanPham",conn);
            DataTable dtSANPHAM = new DataTable();
            dtSANPHAM.Clear();
            daSANPHAM.Fill(dtSANPHAM);
            dgvDANHMUCSP.DataSource = dtSANPHAM;


            this.btnDONGIA.ResetText();
            this.btnDVT.ResetText();
            this.btnMASP.ResetText();
            this.panel.Enabled = false;

            this.btnTHEM.Enabled = true;
            this.btnSUA.Enabled = true;
            this.btnXOA.Enabled = true;

            this.btnLUU.Enabled = false;
            this.btnHUY.Enabled = false;



        }
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Them = false;
            int r = dgvDANHMUCSP.CurrentCell.RowIndex;

            this.btnTENSP.ResetText();
            this.btnDONGIA.ResetText();
            this.btnDVT.ResetText();
            this.btnMASP.ResetText();
            this.panel.Enabled = true;

            this.btnMASP.Text = dgvDANHMUCSP.Rows[r].Cells[0].Value.ToString();
            this.btnTENSP.Text = dgvDANHMUCSP.Rows[r].Cells[1].Value.ToString();
            this.btnDVT.Text = dgvDANHMUCSP.Rows[r].Cells[2].Value.ToString();
            this.btnDONGIA.Text = dgvDANHMUCSP.Rows[r].Cells[3].Value.ToString();

            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;

            this.btnHUY.Enabled = true;
            this.btnLUU.Enabled = true;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTROVE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRL_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.btnTENSP.ResetText();
            this.btnDONGIA.ResetText();
            this.btnDVT.ResetText();
            this.btnMASP.ResetText();
            this.panel.Enabled = false;

            this.btnTHEM.Enabled = true;
            this.btnSUA.Enabled = true;
            this.btnXOA.Enabled = true;

            this.btnLUU.Enabled = false;
            this.btnHUY.Enabled = false;
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
           
            try {
                SqlConnection conn = new SqlConnection(strConnectionString);
                conn.Open();
                int r = dgvDANHMUCSP.CurrentCell.RowIndex;
                SqlCommand sql = new SqlCommand();
                sql.CommandType = CommandType.Text;
                sql.Connection = conn;
                string masp = dgvDANHMUCSP.Rows[r].Cells[0].Value.ToString();
                sql.CommandText = System.String.Concat("DELETE FROM SanPham WHERE MaSP='" + masp + "'");
                sql.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Xóa Thành Công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Xóa Không Thành Công! Lỗi Rồi");
            }
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            Them =true;
            this.btnTENSP.ResetText();
            this.btnDONGIA.ResetText();
            this.btnDVT.ResetText();
            this.btnMASP.ResetText();
            this.panel.Enabled =true;

            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;

            this.btnHUY.Enabled = true;
            this.btnLUU.Enabled = true;

            this.btnMASP.Focus();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();

            if (Them)
            {
                
                try {
                    string masp = this.btnMASP.Text.ToString();
                    string tensp = this.btnTENSP.Text.ToString();
                    string dongia = this.btnDONGIA.Text.ToString();
                    string dvt = this.btnDVT.Text.ToString();

                    SqlCommand sql = new SqlCommand();
                    sql.CommandType = CommandType.Text;
                    sql.Connection = conn;
                    sql.CommandText = System.String.Concat("INSERT INTO SanPham(MaSP,TenSP,DonViTinh,DonGia)values('" + masp + "','" + tensp + "','" + dvt + "','" + dongia + "')");
                    sql.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Luu Thành Công");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Luu ko Thành Công");
                }

            }
            if (!Them)
            {
                try {
                    string masp = this.btnMASP.Text.ToString();
                    string tensp = this.btnTENSP.Text.ToString();
                    string dongia = this.btnDONGIA.Text.ToString();
                    string dvt = this.btnDVT.Text.ToString();

                    SqlCommand sql = new SqlCommand();
                    sql.CommandType = CommandType.Text;
                    sql.Connection = conn;
                    sql.CommandText = System.String.Concat("update SanPham Set MaSP='" + masp + "',TenSP='" + tensp + "',DonViTinh='" + dvt + "',DonGia='" + dongia + "'where MaSP='" + masp + "'");
                    sql.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Sữa Thành Công");

                }
                catch (SqlException)
                {
                    LoadData();
                    MessageBox.Show("Lỗi Rồi");
                }
               
            }
        }
    }
}
