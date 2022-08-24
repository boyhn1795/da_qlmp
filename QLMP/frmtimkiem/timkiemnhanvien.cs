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
    public partial class timkiemnhanvien : Form
    {
        public timkiemnhanvien()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        void load_ma()
        {
            var qr = db.NhanVien.ToList();
            cb_ma.DataSource = qr;
            cb_ma.DisplayMember = "manv";

        }
        void load_ten()
        {
            var qr = db.NhanVien.ToList();
            cb_ten.DataSource = qr;
            cb_ten.DisplayMember = "tennv";
        }
        private void timkiemnhanvien_Load(object sender, EventArgs e)
        {
            load_ma();
            load_ten();
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            if (rbt_ma.Checked)
            {
                var q = from d in db.NhanVien
                        where d.manv == cb_ma.Text
                        select d;
                if (q.Count() != 0)
                {
                    luoi_nv.DataSource = q.ToList();
                    cb_ma.Visible = true;
                    cb_ten.Visible = false;
                }
                else
                    MessageBox.Show("chưa có mã nhân viên này");
            }
            if (rbt_ten.Checked)
            {
                var q = from d in db.NhanVien
                        where d.tennv == cb_ten.Text
                        select d;
                if (q.Count() != 0)
                {
                    luoi_nv.DataSource = q.ToList();
                    cb_ten.Visible = true;
                    cb_ma.Visible = false;
                }
                else
                    MessageBox.Show("Chưa có tên nhân viên này");

            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
