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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void xemDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
        void XemDanhMuc( int intDanhMuc)
        {
            Form frm = new Form3();
            frm.Text =intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void xemDanhMụcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Text = "Quản Lí Danh Mục Thành Phố";
            frm4.ShowDialog();
           
        }

        private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Text = "Quan Li Danh Muc Khach Hang";
            frm5.ShowDialog();
        }

        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            frm6.Text = "Quản Lí Danh Mục Nhân Viên";
            frm6.ShowDialog();
        }

        private void danhMụcSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Text = "Quản Lí Danh Mục Sản Phẩm";
            frm7.ShowDialog();
        }

        private void danhMụcChiTiếtHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Text = "Quản Lí Danh Mục Chi Tiết Hóa Đơn";
            frm8.ShowDialog();
        }

        private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel frm9 = new panel();
            frm9.Text = "Quản Lí Danh Mục Hóa Đơn";
            frm9.ShowDialog();
        }

        private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Text = "Quản Lí Khách Hàng Theo Thành Phố";
            frm10.ShowDialog();
        }

        private void hóaĐơnTheoKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Text = "Quản Lí Hóa Đơn Theo Khách Hàng";
            frm11.ShowDialog();
        }

        private void hóaĐơnTheoSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Text = "Quản Lí Hóa Đơn Theo Sản Phẩm";
            frm12.ShowDialog();

        }

        private void hóaĐơnTheoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Text = "Quản Lí Hóa Đơn Theo Nhân Viên";
            frm13.ShowDialog();
        }

        private void chiTiếtHóaĐonTheoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.Text = "Quản Lí Chi Tiết Hóa Đơn Theo Hóa Đơn";
            frm14.ShowDialog();

        }

        private void quảnLíĐaCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.Text = "Quản Lí Đa Cấp";
            frm15.ShowDialog();
        }
    }
}
