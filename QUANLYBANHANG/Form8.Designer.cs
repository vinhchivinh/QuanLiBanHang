
namespace QUANLYBANHANG
{
    partial class Form8
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.GroupBox();
            this.txtMSP = new System.Windows.Forms.ComboBox();
            this.txtMHD = new System.Windows.Forms.ComboBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCHITIETHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRL = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnTROVE = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txtMSP);
            this.panel.Controls.Add(this.txtMHD);
            this.panel.Controls.Add(this.txtSL);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Location = new System.Drawing.Point(46, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(612, 157);
            this.panel.TabIndex = 1;
            this.panel.TabStop = false;
            this.panel.Enter += new System.EventHandler(this.panel_Enter);
            // 
            // txtMSP
            // 
            this.txtMSP.FormattingEnabled = true;
            this.txtMSP.Location = new System.Drawing.Point(194, 74);
            this.txtMSP.Name = "txtMSP";
            this.txtMSP.Size = new System.Drawing.Size(282, 28);
            this.txtMSP.TabIndex = 7;
            // 
            // txtMHD
            // 
            this.txtMHD.FormattingEnabled = true;
            this.txtMHD.Location = new System.Drawing.Point(194, 25);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(282, 28);
            this.txtMHD.TabIndex = 6;
            this.txtMHD.SelectedIndexChanged += new System.EventHandler(this.txtMHD_SelectedIndexChanged);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(194, 128);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(282, 26);
            this.txtSL.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Sản Phẩm ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Hóa Đơn";
            // 
            // dgvCHITIETHD
            // 
            this.dgvCHITIETHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCHITIETHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaSP,
            this.SoLuong});
            this.dgvCHITIETHD.Location = new System.Drawing.Point(46, 190);
            this.dgvCHITIETHD.Name = "dgvCHITIETHD";
            this.dgvCHITIETHD.RowHeadersWidth = 62;
            this.dgvCHITIETHD.RowTemplate.Height = 28;
            this.dgvCHITIETHD.Size = new System.Drawing.Size(612, 248);
            this.dgvCHITIETHD.TabIndex = 2;
            this.dgvCHITIETHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCHITIETHD_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã HĐ";
            this.MaHD.MinimumWidth = 8;
            this.MaHD.Name = "MaHD";
            this.MaHD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaHD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaHD.Width = 150;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Tên SP";
            this.MaSP.MinimumWidth = 8;
            this.MaSP.Name = "MaSP";
            this.MaSP.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSP.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MaSP.Width = 150;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "SỐ LƯỢNG";
            this.SoLuong.MinimumWidth = 8;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 150;
            // 
            // btnRL
            // 
            this.btnRL.Location = new System.Drawing.Point(58, 444);
            this.btnRL.Name = "btnRL";
            this.btnRL.Size = new System.Drawing.Size(113, 35);
            this.btnRL.TabIndex = 3;
            this.btnRL.Text = "ReLoad";
            this.btnRL.UseVisualStyleBackColor = true;
            this.btnRL.Click += new System.EventHandler(this.btnRL_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(58, 492);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(113, 35);
            this.btnLUU.TabIndex = 4;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(240, 444);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(113, 35);
            this.btnTHEM.TabIndex = 5;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(240, 492);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(113, 35);
            this.btnHUY.TabIndex = 6;
            this.btnHUY.Text = "Hủy Bỏ";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(409, 444);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(113, 35);
            this.btnSUA.TabIndex = 7;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.btnSUA_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(409, 492);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(113, 35);
            this.btnXOA.TabIndex = 8;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnTROVE
            // 
            this.btnTROVE.Location = new System.Drawing.Point(545, 444);
            this.btnTROVE.Name = "btnTROVE";
            this.btnTROVE.Size = new System.Drawing.Size(113, 83);
            this.btnTROVE.TabIndex = 9;
            this.btnTROVE.Text = "Trở Về";
            this.btnTROVE.UseVisualStyleBackColor = true;
            this.btnTROVE.Click += new System.EventHandler(this.btnTROVE_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 539);
            this.Controls.Add(this.btnTROVE);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnHUY);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnRL);
            this.Controls.Add(this.dgvCHITIETHD);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Name = "Form8";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCHITIETHD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.DataGridView dgvCHITIETHD;
        private System.Windows.Forms.Button btnRL;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnTROVE;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.ComboBox txtMSP;
        private System.Windows.Forms.ComboBox txtMHD;
    }
}