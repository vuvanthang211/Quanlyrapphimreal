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
    public partial class FrmBaoCaoDSPhim : Form
    {
        public FrmBaoCaoDSPhim()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoDSPhim_Load(object sender, EventArgs e)
        {
            DAO.OpenConnection();

            string sql = "select a.MaPhim, TenPhim, NgayChieu from tblLichChieu a join tblPhim b on a.MaPhim = b.MaPhim where NgayChieu < getdate()";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, DAO.conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            Datagridview_DSPhim.DataSource = table;
        }

        private void btnDSPhim_Click(object sender, EventArgs e)
        {
            ExportExcel_DSPhim excel = new ExportExcel_DSPhim();
            DataTable dt = (DataTable)Datagridview_DSPhim.DataSource;
            excel.Export(dt, "Báo cáo ds phim đg công chiếu", "BÁO CÁO DS PHIM ĐANG CÔNG CHIẾU");
        }
    }
}
