namespace WindowsFormsApp1
{
    partial class frmDangnhap
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
            this.lblTendangnhap = new System.Windows.Forms.Label();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.chkLuumatkhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhâp";
            // 
            // lblTendangnhap
            // 
            this.lblTendangnhap.AutoSize = true;
            this.lblTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendangnhap.Location = new System.Drawing.Point(49, 80);
            this.lblTendangnhap.Name = "lblTendangnhap";
            this.lblTendangnhap.Size = new System.Drawing.Size(128, 18);
            this.lblTendangnhap.TabIndex = 1;
            this.lblTendangnhap.Text = "Tên đăng nhập :";
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(49, 133);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(87, 18);
            this.lblMatkhau.TabIndex = 2;
            this.lblMatkhau.Text = "Mật khẩu :";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(187, 218);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(127, 34);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(376, 218);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(239, 80);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(300, 22);
            this.txtTendangnhap.TabIndex = 5;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(239, 133);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(300, 22);
            this.txtMatkhau.TabIndex = 6;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // chkLuumatkhau
            // 
            this.chkLuumatkhau.AutoSize = true;
            this.chkLuumatkhau.Location = new System.Drawing.Point(239, 177);
            this.chkLuumatkhau.Name = "chkLuumatkhau";
            this.chkLuumatkhau.Size = new System.Drawing.Size(116, 21);
            this.chkLuumatkhau.TabIndex = 7;
            this.chkLuumatkhau.Text = "Lưu mật khẩu";
            this.chkLuumatkhau.UseVisualStyleBackColor = true;
            this.chkLuumatkhau.CheckedChanged += new System.EventHandler(this.chkLuumatkhau_CheckedChanged);
            this.chkLuumatkhau.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkLuumatkhau_MouseClick);
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 295);
            this.Controls.Add(this.chkLuumatkhau);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTendangnhap);
            this.Controls.Add(this.label1);
            this.Name = "frmDangnhap";
            this.Text = "Đăng_nhập";
            this.Load += new System.EventHandler(this.frmDangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTendangnhap;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.CheckBox chkLuumatkhau;
    }
}