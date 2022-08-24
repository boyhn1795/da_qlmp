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
    public partial class frm_hoadonnhap : Form
    {
        public frm_hoadonnhap()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frm_hoadonnhap_Load(object sender, EventArgs e)
        {
            var qr = (from d in db.Chitiethoadonnhap
                      orderby d.mahdn
                      select d.mahdn).Distinct();
            cb_hdn.DataSource = qr.ToList();
            cb_hdn.DisplayMember = "mahdn";
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            reportThongKe.Hoadonnhap rp = new reportThongKe.Hoadonnhap();
            rp.SetParameterValue("mahdn", cb_hdn.Text);
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
