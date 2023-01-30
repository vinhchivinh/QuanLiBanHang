
namespace QUANLYBANHANG
{
    partial class Form7
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
            this.panel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMASP = new System.Windows.Forms.TextBox();
            this.btnTENSP = new System.Windows.Forms.TextBox();
            this.btnDVT = new System.Windows.Forms.TextBox();
            this.btnDONGIA = new System.Windows.Forms.TextBox();
            this.dgvDANHMUCSP = new System.Windows.Forms.DataGridView();
            this.btnRL = new System.Windows.Forms.Button();
            this.btnTHEM = new System.Windows.Forms.Button();
            this.btnSUA = new System.Windows.Forms.Button();
            this.btnLUU = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.btnTROVE = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUCSP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnDONGIA);
            this.panel.Controls.Add(this.btnDVT);
            this.panel.Controls.Add(this.btnTENSP);
            this.panel.Controls.Add(this.btnMASP);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(36, 33);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(733, 128);
            this.panel.TabIndex = 0;
            this.panel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ten SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Giá";
            // 
            // btnMASP
            // 
            this.btnMASP.Location = new System.Drawing.Point(105, 16);
            this.btnMASP.Name = "btnMASP";
            this.btnMASP.Size = new System.Drawing.Size(204, 26);
            this.btnMASP.TabIndex = 4;
            this.btnMASP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnTENSP
            // 
            this.btnTENSP.Location = new System.Drawing.Point(105, 70);
            this.btnTENSP.Name = "btnTENSP";
            this.btnTENSP.Size = new System.Drawing.Size(204, 26);
            this.btnTENSP.TabIndex = 5;
            // 
            // btnDVT
            // 
            this.btnDVT.Location = new System.Drawing.Point(527, 16);
            this.btnDVT.Name = "btnDVT";
            this.btnDVT.Size = new System.Drawing.Size(184, 26);
            this.btnDVT.TabIndex = 6;
            // 
            // btnDONGIA
            // 
            this.btnDONGIA.Location = new System.Drawing.Point(527, 70);
            this.btnDONGIA.Name = "btnDONGIA";
            this.btnDONGIA.Size = new System.Drawing.Size(184, 26);
            this.btnDONGIA.TabIndex = 7;
            // 
            // dgvDANHMUCSP
            // 
            this.dgvDANHMUCSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDANHMUCSP.Location = new System.Drawing.Point(36, 208);
            this.dgvDANHMUCSP.Name = "dgvDANHMUCSP";
            this.dgvDANHMUCSP.RowHeadersWidth = 62;
            this.dgvDANHMUCSP.RowTemplate.Height = 28;
            this.dgvDANHMUCSP.Size = new System.Drawing.Size(733, 234);
            this.dgvDANHMUCSP.TabIndex = 1;
            // 
            // btnRL
            // 
            this.btnRL.Location = new System.Drawing.Point(36, 465);
            this.btnRL.Name = "btnRL";
            this.btnRL.Size = new System.Drawing.Size(88, 46);
            this.btnRL.TabIndex = 2;
            this.btnRL.Text = "ReLoad";
            this.btnRL.UseVisualStyleBackColor = true;
            this.btnRL.Click += new System.EventHandler(this.btnRL_Click);
            // 
            // btnTHEM
            // 
            this.btnTHEM.Location = new System.Drawing.Point(141, 465);
            this.btnTHEM.Name = "btnTHEM";
            this.btnTHEM.Size = new System.Drawing.Size(100, 46);
            this.btnTHEM.TabIndex = 3;
            this.btnTHEM.Text = "Thêm";
            this.btnTHEM.UseVisualStyleBackColor = true;
            this.btnTHEM.Click += new System.EventHandler(this.btnTHEM_Click);
            // 
            // btnSUA
            // 
            this.btnSUA.Location = new System.Drawing.Point(264, 465);
            this.btnSUA.Name = "btnSUA";
            this.btnSUA.Size = new System.Drawing.Size(90, 46);
            this.btnSUA.TabIndex = 4;
            this.btnSUA.Text = "Sửa";
            this.btnSUA.UseVisualStyleBackColor = true;
            this.btnSUA.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLUU
            // 
            this.btnLUU.Location = new System.Drawing.Point(376, 465);
            this.btnLUU.Name = "btnLUU";
            this.btnLUU.Size = new System.Drawing.Size(91, 46);
            this.btnLUU.TabIndex = 5;
            this.btnLUU.Text = "Lưu";
            this.btnLUU.UseVisualStyleBackColor = true;
            this.btnLUU.Click += new System.EventHandler(this.btnLUU_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(489, 465);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(87, 46);
            this.btnHUY.TabIndex = 6;
            this.btnHUY.Text = "Hủy Bỏ";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Location = new System.Drawing.Point(598, 465);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(76, 46);
            this.btnXOA.TabIndex = 7;
            this.btnXOA.Text = "Xóa";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // btnTROVE
            // 
            this.btnTROVE.Location = new System.Drawing.Point(681, 465);
            this.btnTROVE.Name = "btnTROVE";
            this.btnTROVE.Size = new System.Drawing.Size(88, 46);
            this.btnTROVE.TabIndex = 8;
            this.btnTROVE.Text = "Trở Về";
            this.btnTROVE.UseVisualStyleBackColor = true;
            this.btnTROVE.Click += new System.EventHandler(this.btnTROVE_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btnTROVE);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnHUY);
            this.Controls.Add(this.btnLUU);
            this.Controls.Add(this.btnSUA);
            this.Controls.Add(this.btnTHEM);
            this.Controls.Add(this.btnRL);
            this.Controls.Add(this.dgvDANHMUCSP);
            this.Controls.Add(this.panel);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDANHMUCSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnDONGIA;
        private System.Windows.Forms.TextBox btnDVT;
        private System.Windows.Forms.TextBox btnTENSP;
        private System.Windows.Forms.TextBox btnMASP;
        private System.Windows.Forms.DataGridView dgvDANHMUCSP;
        private System.Windows.Forms.Button btnRL;
        private System.Windows.Forms.Button btnTHEM;
        private System.Windows.Forms.Button btnSUA;
        private System.Windows.Forms.Button btnLUU;
        private System.Windows.Forms.Button btnHUY;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.Button btnTROVE;
    }
}