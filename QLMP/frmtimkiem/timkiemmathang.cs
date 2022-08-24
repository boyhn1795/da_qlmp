using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.frmtimkiem
{
    public partial class timkiemmathang : Form
    {
        public timkiemmathang()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        MatHang mh = new MatHang();
        void load_tenmh()
        {
            var q = (from t in db.MatHang select new { t.tenmh }).Distinct();
            cbb_tenmh.Items.Add("Tất cả");
            foreach (var s in q)
            {
                cbb_tenmh.Items.Add(s.tenmh);
            }
        }

        void load_ncc()
        {
            var q = (from t in db.MatHang select new { t.tenncc }).Distinct();
            cbb_tenncc.Items.Add("Tất cả");
            foreach (var s in q)
            {
                cbb_tenncc.Items.Add(s.tenncc);
            }
        }
        private void timkiemmathang_Load(object sender, EventArgs e)
        {
            load_tenmh();
            load_ncc();
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            if (cbb_tenmh.Text == "Tất cả" || cbb_tenmh.Text == "")
            {
                if (cbb_tenncc.Text == "Tất cả" || cbb_tenncc.Text == "")
                {
                    var q = from t in db.MatHang select t;
                    matHangBindingSource.DataSource = q.ToList();
                    luoi_mh.DataSource = matHangBindingSource;
                    matHangBindingNavigator.BindingSource = matHangBindingSource;

                }
                else
                {
                    var q = from t in db.MatHang where t.tenncc == cbb_tenncc.Text select t;
                    matHangBindingSource.DataSource = q.ToList();
                    luoi_mh.DataSource = matHangBindingSource;
                    matHangBindingNavigator.BindingSource = matHangBindingSource;
                }
            }
            else
            {
                if (cbb_tenncc.Text == "Tất cả" || cbb_tenncc.Text == "")
                {
                    var q = from t in db.MatHang where t.tenmh == cbb_tenmh.Text select t;
                    matHangBindingSource.DataSource = q.ToList();
                    luoi_mh.DataSource = matHangBindingSource;
                    matHangBindingNavigator.BindingSource = matHangBindingSource;
                }
                else
                {
                    var q = from t in db.MatHang where t.tenmh == cbb_tenmh.Text && t.tenncc ==cbb_tenncc.Text select t;
                    matHangBindingSource.DataSource = q.ToList();
                    luoi_mh.DataSource = matHangBindingSource;
                    matHangBindingNavigator.BindingSource = matHangBindingSource;
                }
            }

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
