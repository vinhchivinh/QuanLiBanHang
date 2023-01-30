
namespace QUANLYBANHANG
{
    partial class panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMANV = new System.Windows.Forms.ComboBox();
            this.txtMAKH = new System.Windows.Forms.ComboBox();
            this.txtNGAYNHAN = new System.Windows.Forms.TextBox();
            this.txtNGAYLAP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHOADON = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.co = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRELOAD = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnHUYBO = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnTROVE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMANV);
            this.groupBox1.Controls.Add(this.txtMAKH);
            this.groupBox1.Controls.Add(this.txtNGAYNHAN);
            this.groupBox1.Controls.Add(this.txtNGAYLAP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMAHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMANV
            // 
            this.txtMANV.FormattingEnabled = true;
            this.txtMANV.Location = new System.Drawing.Point(99, 108);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(202, 28);
            this.txtMANV.TabIndex = 10;
            // 
            // txtMAKH
            // 
            this.txtMAKH.FormattingEnabled = true;
            this.txtMAKH.Location = new System.Drawing.Point(99, 60);
            this.txtMAKH.Name = "txtMAKH";
            this.txtMAKH.Size = new System.Drawing.Size(202, 28);
            this.txtMAKH.TabIndex = 9;
            // 
            // txtNGAYNHAN
            // 
            this.txtNGAYNHAN.Location = new System.Drawing.Point(799, 63);
            this.txtNGAYNHAN.Name = "txtNGAYNHAN";
            this.txtNGAYNHAN.Size = new System.Drawing.Size(221, 26);
            this.txtNGAYNHAN.TabIndex = 8;
            // 
            // txtNGAYLAP
            // 
            this.txtNGAYLAP.Location = new System.Drawing.Point(793, 16);
            this.txtNGAYLAP.Name = "txtNGAYLAP";
            this.txtNGAYLAP.Size = new System.Drawing.Size(227, 26);
            this.txtNGAYLAP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Lập Nhận Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Lập Hóa Đơn";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(99, 15);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(100, 26);
            this.txtMAHD.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã KH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HĐ";
            // 
            // dgvHOADON
            // 
            this.dgvHOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaKH,
            this.MaNV,
            this.co,
            this.Column4});
            this.dgvHOADON.Location = new System.Drawing.Point(52, 205);
            this.dgvHOADON.Name = "dgvHOADON";
            this.dgvHOADON.RowHeadersWidth = 62;
            this.dgvHOADON.RowTemplate.Height = 28;
            this.dgvHOADON.Size = new System.Drawing.Size(1039, 229);
            this.dgvHOADON.TabIndex = 1;
            this.dgvHOADON.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaHD";
            this.Column1.HeaderText = "Mã HĐ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Tên CTy";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaKH.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 8;
            this.MaNV.Name = "MaNV";
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaNV.Width = 150;
            // 
            // co
            // 
            this.co.DataPropertyName = "NgayLapHD";
            this.co.HeaderText = "Ngày Lập HĐ";
            this.co.MinimumWidth = 8;
            this.co.Name = "co";
            this.co.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NgayNhanHang";
            this.Column4.HeaderText = "Ngày Nhận Hàng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // btnRELOAD
            // 
            this.btnRELOAD.Location = new System.Drawing.Point(52, 460);
            this.btnRELOAD.Name = "btnRELOAD";
            this.btnRELOAD.Size = new System.Drawing.Size(129, 36);
            this.btnRELOAD.TabIndex = 2;
            this.btnRELOAD.Text = "ReLoad";
            this.btnRELOAD.UseVisualStyleBackColor = true;
            this.btnRELOAD.Click += new System.EventHandler(this.btnRELOAD_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(198, 460);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(129, 36);
            this.btnTHEM.TabIndex = 3;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(347, 460);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(129, 36);
            this.btnSUA.TabIndex = 4;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(506, 460);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(129, 36);
            this.btnLUU.TabIndex = 5;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHUYBO
            // 
            this.btnHUYBO.Location = new System.Drawing.Point(670, 460);
            this.btnHUYBO.Name = "btnHUYBO";
            this.btnHUYBO.Size = new System.Drawing.Size(129, 36);
            this.btnHUYBO.TabIndex = 6;
            this.btnHUYBO.Text = "Hủy Bỏ";
            this.btnHUYBO.UseVisualStyleBackColor = true;
            this.btnHUYBO.Click += new System.EventHandler(this.btnHUYBO_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(824, 460);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(129, 36);
            this.btnXOA.TabIndex = 7;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnTROVE
            // 
            this.btnTROVE.Location = new System.Drawing.Point(970, 460);
            this.btnTROVE.Name = "btnTROVE";
            this.btnTROVE.Size = new System.Drawing.Size(129, 36);
            this.btnTROVE.TabIndex = 8;
            this.btnTROVE.Text = "Trở Về";
            this.btnTROVE.UseVisualStyleBackColor = true;
            this.btnTROVE.Click += new System.EventHandler(this.btnTROVE_Click);
            // 
            // panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 525);
            this.Controls.Add(this.btnTROVE);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnHUYBO);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnRELOAD);
            this.Controls.Add(this.dgvHOADON);
            this.Controls.Add(this.groupBox1);
            this.Name = "panel";
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOADON)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNGAYNHAN;
        private System.Windows.Forms.TextBox txtNGAYLAP;
        private System.Windows.Forms.DataGridView dgvHOADON;
        private System.Windows.Forms.Button btnRELOAD;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnHUYBO;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnTROVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn co;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox txtMANV;
        private System.Windows.Forms.ComboBox txtMAKH;
    }
}