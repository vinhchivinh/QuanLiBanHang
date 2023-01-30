using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtUSER_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((this.txtUSER.Text == "vinh12345") && (this.textPASS.Text == "root12345"))
            { this.Close(); }
            else
            {
                MessageBox.Show("Không đúng tên người dùng hoặc mật khẩu!!!", "Thông báo");
                this.txtUSER.Focus();
               // Console.WriteLine(this.txtUSER.Text);
                

            }
        }

        private void textPASS_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
