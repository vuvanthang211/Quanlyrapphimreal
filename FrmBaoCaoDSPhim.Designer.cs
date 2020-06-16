namespace QuanLyRapPhim
{
    partial class FrmBaoCaoDSPhim
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
            this.btnDSPhim = new System.Windows.Forms.Button();
            this.Datagridview_DSPhim = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview_DSPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Danh sách phim đang công chiếu";
            // 
            // btnDSPhim
            // 
            this.btnDSPhim.Location = new System.Drawing.Point(607, 357);
            this.btnDSPhim.Name = "btnDSPhim";
            this.btnDSPhim.Size = new System.Drawing.Size(75, 23);
            this.btnDSPhim.TabIndex = 6;
            this.btnDSPhim.Text = "IN";
            this.btnDSPhim.UseVisualStyleBackColor = true;
            this.btnDSPhim.Click += new System.EventHandler(this.btnDSPhim_Click);
            // 
            // Datagridview_DSPhim
            // 
            this.Datagridview_DSPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridview_DSPhim.Location = new System.Drawing.Point(193, 147);
            this.Datagridview_DSPhim.Name = "Datagridview_DSPhim";
            this.Datagridview_DSPhim.Size = new System.Drawing.Size(348, 197);
            this.Datagridview_DSPhim.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "BÁO CÁO DANH SÁCH PHIM ĐANG CÔNG CHIẾU";
            // 
            // FrmBaoCaoDSPhim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDSPhim);
            this.Controls.Add(this.Datagridview_DSPhim);
            this.Controls.Add(this.label1);
            this.Name = "FrmBaoCaoDSPhim";
            this.Text = "BÁO CÁO DS PHIM ĐANG CÔNG CHIẾU";
            this.Load += new System.EventHandler(this.FrmBaoCaoDSPhim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview_DSPhim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDSPhim;
        private System.Windows.Forms.DataGridView Datagridview_DSPhim;
        private System.Windows.Forms.Label label1;
    }
}