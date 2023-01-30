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

    public partial class Form6 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlDataAdapter daNHANVIEN = null;
        SqlConnection conn = null;
        DataTable dtNHANVIEN;
        //SqlDataAdapter daThanhPho = null;
       // DataTable dtThanhPho;
        bool Them;
        void LoadData()
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daNHANVIEN = new SqlDataAdapter("SELECT *FROM NHANVIEN",conn);
            DataTable dtNHANVIEN = new DataTable();
            dtNHANVIEN.Clear();
            daNHANVIEN.Fill(dtNHANVIEN);


            dgvDANHMUCNV.DataSource = dtNHANVIEN;
            //xóa kí tự
            this.textDIACHI.ResetText();
            this.textMANV.ResetText();
            this.textHOLOT.ResetText();
            this.textNGAYNV.ResetText();
            this.textTEN.ResetText();
            //khóa panel
            this.panel.Enabled = false;
            //khóa luu huy bo
            this.btnLUU.Enabled = false;
            this.btnHUY.Enabled = false;

            this.btnTHEM.Enabled = true;
            this.btnSUA.Enabled = true;
            this.btnXOA.Enabled = true;


        
        }
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvDANHMUCNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRL_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTROVE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.textDIACHI.ResetText();
            this.textMANV.ResetText();
            this.textHOLOT.ResetText();
            this.textNGAYNV.ResetText();
            this.textTEN.ResetText();
            //khóa panel
            this.panel.Enabled = false;
            //khóa luu huy bo
            this.btnLUU.Enabled = false;
            this.btnHUY.Enabled = false;

            this.btnTHEM.Enabled = true;
            this.btnSUA.Enabled = true;
            this.btnXOA.Enabled = true;
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection conn = new SqlConnection(strConnectionString);
                conn.Open();
                int r = dgvDANHMUCNV.CurrentCell.RowIndex;
                string manv = dgvDANHMUCNV.Rows[r].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = System.String.Concat("DELETE FROM NhanVien where MaNV='" + manv + "'");
                cmd.ExecuteNonQuery();
                LoadData();
                MessageBox.Show("Xóa Thành Công");
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi roi không xóa được");
            }
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
                  Them = true;
            

                //xóa toàn bộ kí tự ở panel
                this.panel.Enabled = true;
                //this.textTEN.ResetText();
                //this.textHOLOT.ResetText();
              //  this.textNGAYNV.ResetText();
              //  this.textDIACHI.ResetText();
               // this.checkboxNU.Checked = false;
               // Cho Phep thao tac tren panel
                this.btnLUU.Enabled = true;
                this.btnHUY.Enabled = true;
               //
                this.btnTHEM.Enabled = false;
                this.btnSUA.Enabled = false;
                this.btnXOA.Enabled = false;

                this.textMANV.Focus();
               // this.textMANV.Focus();
                

            
            
          
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            Them = false;
            //Đưa giá trị ở bảng lên panel
            int r = dgvDANHMUCNV.CurrentCell.RowIndex;
            this.textMANV.Text = dgvDANHMUCNV.Rows[r].Cells[0].Value.ToString();
            this.textHOLOT.Text = dgvDANHMUCNV.Rows[r].Cells[1].Value.ToString();
            this.textTEN.Text = dgvDANHMUCNV.Rows[r].Cells[2].Value.ToString();
           //chưa lấy được dữ liệu checkbox
            this.textNGAYNV.Text= dgvDANHMUCNV.Rows[r].Cells[4].Value.ToString();
            this.textDIACHI.Text = dgvDANHMUCNV.Rows[r].Cells[5].Value.ToString();
            this.textDIENTHOAI.Text = dgvDANHMUCNV.Rows[r].Cells[6].Value.ToString();
            //
            this.btnHUY.Enabled = true;
            this.panel.Enabled = true;
            this.btnLUU.Enabled = true;

            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;

            


        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            int nu = 1;
            if (this.checkboxNU.Checked == false) { nu = 0; }
            if (Them)
            {
                try
                {
                    SqlCommand sql = new SqlCommand();
                    sql.Connection = conn;
                    sql.CommandType = CommandType.Text;
                    string textMANV = this.textMANV.Text.ToString();
                    string Ho = this.textHOLOT.Text.ToString();
                    string Ten = this.textTEN.Text.ToString();
                    // string textMANV = this.textMANV.Text.ToString();
                    string Ngay = this.textNGAYNV.Text.ToString();
                    string diachi = this.textDIACHI.Text.ToString();
                    string dienthoai = this.textDIENTHOAI.Text.ToString();
                    //  sql.CommandText = System.String.Concat("INSERT INTO NhanVien(MaNV,Ho,Ten,Nu,NgayNV,DiaChi,DienThoai) Values('" + this.textMANV.Text.ToString() + "'" + "," + "'" + this.textHOLOT.Text.ToString() + "'" + "," + "'" + this.textTEN.ToString() + "'" + "," + nu + "," + "'" + this.textTEN.ToString() + "'" + "," + "'" + this.textNGAYNV.ToString() + "'" + "," + "'" + this.textDIACHI.ToString() + "'" + "," + "'" + this.textDIACHI.ToString() + "'" + ")");
                    sql.CommandText = System.String.Concat("INSERT INTO NhanVien(MaNV,Ho,Ten,Nu,NgayNV,DiaChi,DienThoai) values ('" + textMANV + "','" + Ho + "','" + Ten + "'," + nu + ",'" + Ngay + "','" + diachi + "','" + dienthoai + "'" + ")");
                    sql.ExecuteNonQuery();
                    MessageBox.Show("Lưu Thành Công");
                    LoadData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi Rồi");
                }

            }
            if (!Them)
            {
                try
                {
                    int r = dgvDANHMUCNV.CurrentCell.RowIndex;
                    string manv = dgvDANHMUCNV.Rows[r].Cells[0].Value.ToString();
                    //this.t.Text = manv;
                    SqlCommand sql = new SqlCommand();
                    sql.Connection = conn;
                    sql.CommandType = CommandType.Text;
                    //
                    // sql.CommandText = System.String.Concat("update NhanVien Set MaNV = '" + this.textMANV.Text.ToString() + "', Ho='" + this.textHOLOT.Text.ToString() + "', Ten = '" + this.textTEN.ToString() + "',  Nu = " + nu + ",NgayNV='" + this.textNGAYNV.ToString() + "'" + ",DiaChi='" + this.textDIACHI.ToString() + "'" + ",DienThoai='" + this.textDIENTHOAI.Text.ToString() + "'" + "where MaNV='" + manv + "'");
                    string textMANV = this.textMANV.Text.ToString();
                    string Ho = this.textHOLOT.Text.ToString();
                    string Ten = this.textTEN.Text.ToString();
                    // string textMANV = this.textMANV.Text.ToString();
                    string Ngay = this.textNGAYNV.Text.ToString();
                    string diachi = this.textDIACHI.Text.ToString();
                    string dienthoai = this.textDIENTHOAI.Text.ToString();
                    sql.CommandText = System.String.Concat("UPDATE NhanVien SET MaNV='"+textMANV+"',Ho='"+Ho+"',Ten='"+Ten+"',NgayNV='"+Ngay+"',DiaChi='"+diachi+"',DienThoai='"+dienthoai+"',Nu='"+nu+"'where MaNV='"+textMANV+"'");
                    sql.ExecuteNonQuery();

                    MessageBox.Show("Sữa Thành Công");
                    LoadData();

                }
                 catch (SqlException)
                {
                    MessageBox.Show("Lỗi Rồi! Sữa Ko thành công");
                }
                conn.Close();


            }
        
            
         }
            
        
    }
}
