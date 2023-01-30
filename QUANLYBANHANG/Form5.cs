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

    public partial class Form5 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlDataAdapter daKhachHang = null;
        SqlConnection conn = null;
        DataTable dtKhachHang;
        SqlDataAdapter daThanhPho = null;
        DataTable dtThanhPho;
        bool Them;
        void LoadData()
        {
            try {
               SqlConnection conn = new SqlConnection(strConnectionString);
               SqlDataAdapter daKhachHang = new SqlDataAdapter("SELECT *FROM KhachHang", conn);
               SqlDataAdapter daThanhPho = new SqlDataAdapter("SELECT *FROM ThanhPho",conn);
               DataTable dtThanhPho = new DataTable();
               dtThanhPho.Clear();
               daThanhPho.Fill(dtThanhPho);

                //Đưa Dữ Liệu lên combobox
                (dgvDANHMUCKH.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DataSource = dtThanhPho;
                (dgvDANHMUCKH.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";
                (dgvDANHMUCKH.Columns["ThanhPho"] as DataGridViewComboBoxColumn).ValueMember = "ThanhPho";

                //Vận chuyển dữ liệu vào bảng khách hàng


                DataTable dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                daKhachHang.Fill(dtKhachHang);
                dgvDANHMUCKH.DataSource = dtKhachHang;
                dgvDANHMUCKH.AutoResizeColumns();

                this.textMAKH.ResetText();
                this.txtDIACHI.ResetText();
                this.txtTENCTY.ResetText();
                this.txtTHANHPHO.ResetText();
                this.txtSDT.ResetText();

                this.panel.Enabled = false;
                this.btnLUU.Enabled = false;
                this.btnHUY.Enabled = false;

                this.btnRELOAD.Enabled = true;
                this.btnSUA.Enabled = true;
                this.btnTHEM.Enabled = true;
                this.btnXOA.Enabled = true;
                this.btnTROVE.Enabled = true;

            }
            catch (SqlException){
                MessageBox.Show("Loi Roi");
            }
           


        }
        public Form5()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTROVE_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            try {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                int r;
                r = dgvDANHMUCKH.CurrentCell.RowIndex;
                //Lấy mã khách hàng của mẫu tin hiện hành
                String makh;
                makh=dgvDANHMUCKH.Rows[r].Cells[0].Value.ToString();

                cmd.CommandText = System.String.Concat("Delete From KhachHang Where MaKH = '" + makh + "'");
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã xóa xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được Lỗi Rồi");
            }
            this.btnHUY.Enabled = true;
            conn.Close();
        }

        private void btnHUY_Click(object sender, EventArgs e)
        {
            this.textMAKH.ResetText();
            this.txtDIACHI.ResetText();
            this.txtTENCTY.ResetText();
            this.txtTHANHPHO.ResetText();
            this.txtSDT.ResetText();

            this.panel.Enabled = false;
            this.btnLUU.Enabled = false;
            this.btnHUY.Enabled = false;

            this.btnRELOAD.Enabled = true;
            this.btnSUA.Enabled = true;
            this.btnTHEM.Enabled = true;
            this.btnXOA.Enabled = true;
            this.btnTROVE.Enabled = true;
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter daThanhPho = new SqlDataAdapter("SELECT *FROM ThanhPho", conn);
            // DataTable dtThanhPho = new DataTable();
            // dtThanhPho.Clear();
            // daThanhPho.Fill(dtThanhPho);
            //      string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLiBanHang;Integrated Security = True";
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daThanhPho = new SqlDataAdapter("SELECT *FROM ThanhPho", conn);
            DataTable dtThanhPho = new DataTable();
            dtThanhPho.Clear();
            daThanhPho.Fill(dtThanhPho);
            conn.Open();
            Them = false;
            this.txtTHANHPHO.DataSource=dtThanhPho;
            this.txtTHANHPHO.DisplayMember="TenThanhPho";
            this.txtTHANHPHO.ValueMember= "ThanhPho";
            //cho phép thao tấc trên panel
            this.panel.Enabled = true;
            //lấy vị trí dòng hiện hành
            int r = dgvDANHMUCKH.CurrentCell.RowIndex;
            this.textMAKH.Text = dgvDANHMUCKH.Rows[r].Cells[0].Value.ToString();
            this.txtTENCTY.Text = dgvDANHMUCKH.Rows[r].Cells[1].Value.ToString();
            this.txtDIACHI.Text = dgvDANHMUCKH.Rows[r].Cells[2].Value.ToString();
            this.txtTHANHPHO.SelectedValue= dgvDANHMUCKH.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text = dgvDANHMUCKH.Rows[r].Cells[4].Value.ToString();
            //
            this.panel.Enabled = true;
            this.btnLUU.Enabled = true;
            this.btnHUY.Enabled = true;
            //
            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;
            //
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConnectionString);
            conn.Open();
            if (Them)
            {
                try {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = System.String.Concat("Insert  Into KhachHang Values(" + "'" + this.textMAKH.Text.ToString() + "','" + this.txtTENCTY.Text.ToString() + "','" + this.txtDIACHI.Text.ToString() + "','" +
                        this.txtTHANHPHO.SelectedValue.ToString() +
                        "','" + this.txtSDT.Text.ToString() +
                        "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");

                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            if (!Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành
                    int r = dgvDANHMUCKH.CurrentCell.RowIndex;
                    // MaKH hiện hành
                    string strMAKH = dgvDANHMUCKH.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update KhachHang Set TenCty = '" + this.txtTENCTY.Text.ToString() + "', DiaChi='" + this.txtDIACHI.Text.ToString() + "' ,ThanhPho = '" + this.txtTHANHPHO.SelectedValue.ToString() + "',  DienThoai = '" + this.txtSDT.Text.ToString() + "' Where  MaKH = '" + strMAKH + "'");
                    // Cập nhật
                   // cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    MessageBox.Show("Sửa Thành Công");
                    // Thông báo
                }

                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được. Lỗi rồi!");
                }
            }
            conn.Close();
        
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            Them = true;

            this.panel.Enabled = true;
            this.btnLUU.Enabled = true;
            this.btnHUY.Enabled = true;
            //không cho phép thao tác trên  nút thêm s x
            this.btnTHEM.Enabled = false;
            this.btnSUA.Enabled = false;
            this.btnXOA.Enabled = false;
            //Đưa dữ liệu lên combobox
            SqlConnection conn = new SqlConnection(strConnectionString);
            SqlDataAdapter daThanhPho = new SqlDataAdapter("SELECT *FROM ThanhPho", conn);
            DataTable dtThanhPho = new DataTable();
            dtThanhPho.Clear();
            daThanhPho.Fill(dtThanhPho);
            this.txtTHANHPHO.DataSource = dtThanhPho;
            this.txtTHANHPHO.DisplayMember = "TenThanhPho";
            this.txtTHANHPHO.ValueMember = "ThanhPho";
            //đua con trỏ đến ô mã kh
            this.textMAKH.Focus();
        }
    }
}
