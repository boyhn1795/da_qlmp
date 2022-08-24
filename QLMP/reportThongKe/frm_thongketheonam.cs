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
    public partial class frm_thongketheonam : Form
    {
        public frm_thongketheonam()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void frm_thongketheonam_Load(object sender, EventArgs e)
        {
            var qr = (from q in db.Doanhthunam select new { q.Năm }).Distinct();
            cb_nam.DataSource = qr.ToList();
            cb_nam.DisplayMember = "Năm";
            cb_nam.Text = "";
        }

        private void bt_in_Click(object sender, EventArgs e)
        {
            Thongkenam rp = new Thongkenam();
            rp.SetParameterValue("nam", cb_nam.Text);
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
