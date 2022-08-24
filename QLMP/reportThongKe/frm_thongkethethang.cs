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
    public partial class frm_thongkethethang : Form
    {
        public frm_thongkethethang()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void frm_thongkethethang_Load(object sender, EventArgs e)
        {
            var qr = (from q in db.Doanhthuthang select new { q.Tháng }).Distinct();
            cb_thang.DataSource = qr.ToList();
            cb_thang.DisplayMember = "Tháng";
            cb_thang.Text = "";
        }
        private void bt_in_Click_1(object sender, EventArgs e)
        {
            thongkethang rp = new thongkethang();
            rp.SetParameterValue("thang", cb_thang.Text);
            crystalReportViewer1.ReportSource = rp;
        }

        private void bt_thoat_Click_1(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.Close();
            }
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
