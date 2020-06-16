using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using QuanLyRapPhim;

namespace QuanLyRapPhim
{
    public partial class FrmBaoCaoDoanhThu : Form
    {
        public FrmBaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();

            DAO.FillDataToCombo("SELECT MaPhim,TenPhim FROM tblPhim ", cboPhim, "MaPhim", "TenPhim");
            cboPhim.SelectedIndex = -1;


            DAO.FillDataToCombo("SELECT MaRap, TenRap  FROM tblRap ", cboRap, "MaRap", "TenRap");

            cboRap.SelectedIndex = -1;

            DAO.CloseConnection();
        }

        private void LoadDataGridView1()
        {
            DAO.OpenConnection();

            string sql = "select MaPhim, TenPhim, (TongThu - TongChiPhi) as DoanhThuPhim from tblPhim where MaPhim = N'" + cboPhim.SelectedValue + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Datagridview_DTPhim.DataSource = table;
        }

        private void LoadDataGridView2()
        {
            DAO.OpenConnection();

            string sql = "select MaRap, month(NgayChieu) as ThangChieuPhim, sum(TongTien) as DoanhThuRap from tblLichChieu" +
                " group by MaRap,month(NgayChieu) having MaRap = N'" + cboRap.SelectedValue
                + "'and month(NgayChieu) = N'" + txtThang.Text + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Datagridview_DTRap.DataSource = table;
        }


        private void btnHienthi_Click_1(object sender, EventArgs e)
        {
            if (cboPhim.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn phim", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataGridView1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cboRap.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn rạp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (txtThang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn tháng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadDataGridView2();
        }

        private void btndtPhim_Click(object sender, EventArgs e)
        {
            ExportExcel_DTPhim excel = new ExportExcel_DTPhim();
            DataTable dt = (DataTable)Datagridview_DTPhim.DataSource;
            excel.Export(dt, "Báo cáo doanh thu phim", "BÁO CÁO DOANH THU PHIM");
        }

        private void btndtRap_Click(object sender, EventArgs e)
        {
            ExportExcel_DTRap excel = new ExportExcel_DTRap();
            DataTable dt = (DataTable)Datagridview_DTRap.DataSource;
            //excel.Export(dt, "Báo cáo doanh thu rạp", "BÁO CÁO DOANH THU RẠP");
        }
    }
}
