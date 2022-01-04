namespace QLTT
{
    partial class frmHocSinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtNam = new System.Windows.Forms.RadioButton();
            this.rbtNu = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTencha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMalop = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(129, 81);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(213, 22);
            this.txtHoten.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // mtbNgaysinh
            // 
            this.mtbNgaysinh.Location = new System.Drawing.Point(129, 114);
            this.mtbNgaysinh.Mask = "00/00/0000";
            this.mtbNgaysinh.Name = "mtbNgaysinh";
            this.mtbNgaysinh.Size = new System.Drawing.Size(100, 22);
            this.mtbNgaysinh.TabIndex = 5;
            this.mtbNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới tính";
            // 
            // rbtNam
            // 
            this.rbtNam.AutoSize = true;
            this.rbtNam.Checked = true;
            this.rbtNam.Location = new System.Drawing.Point(129, 143);
            this.rbtNam.Name = "rbtNam";
            this.rbtNam.Size = new System.Drawing.Size(57, 20);
            this.rbtNam.TabIndex = 7;
            this.rbtNam.TabStop = true;
            this.rbtNam.Text = "Nam";
            this.rbtNam.UseVisualStyleBackColor = true;
            // 
            // rbtNu
            // 
            this.rbtNu.AutoSize = true;
            this.rbtNu.Location = new System.Drawing.Point(239, 144);
            this.rbtNu.Name = "rbtNu";
            this.rbtNu.Size = new System.Drawing.Size(45, 20);
            this.rbtNu.TabIndex = 8;
            this.rbtNu.Text = "Nữ";
            this.rbtNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên cha";
            // 
            // txtTencha
            // 
            this.txtTencha.Location = new System.Drawing.Point(129, 170);
            this.txtTencha.Name = "txtTencha";
            this.txtTencha.Size = new System.Drawing.Size(213, 22);
            this.txtTencha.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tên mẹ";
            // 
            // txtTenme
            // 
            this.txtTenme.Location = new System.Drawing.Point(129, 199);
            this.txtTenme.Name = "txtTenme";
            this.txtTenme.Size = new System.Drawing.Size(213, 22);
            this.txtTenme.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Số ĐT";
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(129, 228);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(213, 22);
            this.txtSodt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Địa chỉ";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(129, 257);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(213, 22);
            this.txtDiachi.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "Mã Lớp";
            // 
            // txtMalop
            // 
            this.txtMalop.Location = new System.Drawing.Point(129, 286);
            this.txtMalop.Name = "txtMalop";
            this.txtMalop.Size = new System.Drawing.Size(213, 22);
            this.txtMalop.TabIndex = 18;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(157, 327);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 19;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(255, 327);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMalop);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSodt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTenme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTencha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtNu);
            this.Controls.Add(this.rbtNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbNgaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Name = "frmHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHocSinh";
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbNgaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtNam;
        private System.Windows.Forms.RadioButton rbtNu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTencha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMalop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}