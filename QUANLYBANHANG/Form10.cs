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
    public partial class Form10 : Form
    {
        string strConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security = True";
        SqlConnection conn;
        SqlDataAdapter daTP = null,daKHACHHANG=null;
        DataTable dtTP = null,dtKHACHHANG=null;
        
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKHTHEOTP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbTHANHPHO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            daTP = new SqlDataAdapter("SELECT *FROM ThanhPho",conn);
            dtTP = new DataTable();
            dtTP.Clear();
            daTP.Fill(dtTP);
            //đưa dữ liệu vào comboxbox
            this.cbTHANHPHO.DataSource = dtTP;
            this.cbTHANHPHO.ValueMember = "ThanhPho";
            this.cbTHANHPHO.DisplayMember = "TenThanhPho";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string matp = this.cbTHANHPHO.SelectedValue.ToString();
            conn = new SqlConnection(strConnectionString);
            daKHACHHANG = new SqlDataAdapter("SELECT *FROM KhachHang where ThanhPho='"+matp+"'",conn);
            dtKHACHHANG = new DataTable();
            dtKHACHHANG.Clear();
            daKHACHHANG.Fill(dtKHACHHANG);
            dgvKHTHEOTP.DataSource = dtKHACHHANG;

            daTP = new SqlDataAdapter("Select *from ThanhPho",conn);
            dtTP = new DataTable();
            dtTP.Clear();
            daTP.Fill(dtTP);

            (dgvKHTHEOTP.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DataSource =dtTP;
            (dgvKHTHEOTP.Columns["ThanhPho"] as DataGridViewComboBoxColumn).ValueMember= "ThanhPho";
            (dgvKHTHEOTP.Columns["ThanhPho"] as DataGridViewComboBoxColumn).DisplayMember = "TenThanhPho";

            int count = 0;
            count = dgvKHTHEOTP.RowCount-1;
            this.txtTONGSOKH.Text = count.ToString();
        }
    }
}
