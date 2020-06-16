namespace QuanLyRapPhim
{
    partial class FrmBaoCaoDoanhThu
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btndtRap = new System.Windows.Forms.Button();
            this.btndtPhim = new System.Windows.Forms.Button();
            this.Datagridview_DTRap = new System.Windows.Forms.DataGridView();
            this.Datagridview_DTPhim = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.cboRap = new System.Windows.Forms.ComboBox();
            this.cboPhim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview_DTRap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview_DTPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Hiển thị";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(287, 187);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(75, 23);
            this.btnHienthi.TabIndex = 32;
            this.btnHienthi.Text = "Hiển thị";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click_1);
            // 
            // btndtRap
            // 
            this.btndtRap.Location = new System.Drawing.Point(701, 370);
            this.btndtRap.Name = "btndtRap";
            this.btndtRap.Size = new System.Drawing.Size(75, 23);
            this.btndtRap.TabIndex = 31;
            this.btndtRap.Text = "IN";
            this.btndtRap.UseVisualStyleBackColor = true;
            this.btndtRap.Click += new System.EventHandler(this.btndtRap_Click);
            // 
            // btndtPhim
            // 
            this.btndtPhim.Location = new System.Drawing.Point(287, 370);
            this.btndtPhim.Name = "btndtPhim";
            this.btndtPhim.Size = new System.Drawing.Size(75, 23);
            this.btndtPhim.TabIndex = 30;
            this.btndtPhim.Text = "IN";
            this.btndtPhim.UseVisualStyleBackColor = true;
            this.btndtPhim.Click += new System.EventHandler(this.btndtPhim_Click);
            // 
            // Datagridview_DTRap
            // 
            this.Datagridview_DTRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview_DTRap.Location = new System.Drawing.Point(441, 216);
            this.Datagridview_DTRap.Name = "Datagridview_DTRap";
            this.Datagridview_DTRap.Size = new System.Drawing.Size(335, 139);
            this.Datagridview_DTRap.TabIndex = 29;
            // 
            // Datagridview_DTPhim
            // 
            this.Datagridview_DTPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview_DTPhim.Location = new System.Drawing.Point(24, 216);
            this.Datagridview_DTPhim.Name = "Datagridview_DTPhim";
            this.Datagridview_DTPhim.Size = new System.Drawing.Size(338, 139);
            this.Datagridview_DTPhim.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(440, 192);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tháng chiếu phim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 163);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tên rạp phim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 163);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tên bộ phim";
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(542, 189);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(121, 20);
            this.txtThang.TabIndex = 24;
            // 
            // cboRap
            // 
            this.cboRap.FormattingEnabled = true;
            this.cboRap.Location = new System.Drawing.Point(542, 160);
            this.cboRap.Name = "cboRap";
            this.cboRap.Size = new System.Drawing.Size(121, 21);
            this.cboRap.TabIndex = 23;
            // 
            // cboPhim
            // 
            this.cboPhim.FormattingEnabled = true;
            this.cboPhim.Location = new System.Drawing.Point(111, 160);
            this.cboPhim.Name = "cboPhim";
            this.cboPhim.Size = new System.Drawing.Size(121, 21);
            this.cboPhim.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 124);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "DOANH THU RẠP THEO THÁNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "DOANH THU THEO PHIM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 57);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(324, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "BÁO CÁO DOANH THU";
            // 
            // FrmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.btndtRap);
            this.Controls.Add(this.btndtPhim);
            this.Controls.Add(this.Datagridview_DTRap);
            this.Controls.Add(this.Datagridview_DTPhim);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.cboRap);
            this.Controls.Add(this.cboPhim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaoCaoDoanhThu";
            this.Text = "BÁO CÁO DOANH THU";
            this.Load += new System.EventHandler(this.FrmBaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview_DTRap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview_DTPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btndtRap;
        private System.Windows.Forms.Button btndtPhim;
        private System.Windows.Forms.DataGridView Datagridview_DTRap;
        private System.Windows.Forms.DataGridView Datagridview_DTPhim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.ComboBox cboRap;
        private System.Windows.Forms.ComboBox cboPhim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}