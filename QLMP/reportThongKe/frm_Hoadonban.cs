using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.reportThongKe
{
    public partial class frm_Hoadonban : Form
    {
        public frm_Hoadonban()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void frm_Hoadonban_Load(object sender, EventArgs e)
        {
            var qr = (from d in db.Chitiethoadonban
                      orderby d.mahdb
                      select d.mahdb).Distinct();
            cb_hdb.DataSource = qr.ToList();
            cb_hdb.DisplayMember = "mahdb";
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            reportThongKe.Hoadonban rp = new reportThongKe.Hoadonban();
            rp.SetParameterValue("mahdb", cb_hdb.Text);
            crystalReportViewer1.ReportSource = rp;
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.Close();
            }
        }
    }
}
