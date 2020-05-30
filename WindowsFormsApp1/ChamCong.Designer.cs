namespace WindowsFormsApp1
{
    partial class ChamCong
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
            this.bangChamCong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bangChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // bangChamCong
            // 
            this.bangChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangChamCong.Location = new System.Drawing.Point(86, 25);
            this.bangChamCong.Name = "bangChamCong";
            this.bangChamCong.Size = new System.Drawing.Size(944, 530);
            this.bangChamCong.TabIndex = 0;
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 669);
            this.Controls.Add(this.bangChamCong);
            this.Name = "ChamCong";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangChamCong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bangChamCong;
    }
}