using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.frmcapnhatdulieu
{
    public partial class capnhattthdnhap : Form
    {
        public capnhattthdnhap()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void load_luoi()
        {
            luoi_hdn.DataSource = db.HoaDonNhap.ToList();
        }
        private void capnhattthdnhap_Load(object sender, EventArgs e)
        {
            cbb_nv.DataSource = db.HoaDonNhap.ToList();
            cbb_nv.DisplayMember = "manv";
            cbb_ncc.DataSource = db.HoaDonNhap.ToList();
            cbb_ncc.DisplayMember = "mancc";
            load_luoi();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            HoaDonNhap hd = new HoaDonNhap();
            var q = from n in db.HoaDonNhap
                    where n.mahdn == txt_mahdn.Text
                    select n;
            hd = q.FirstOrDefault();
            hd.manv = cbb_nv.Text;
            hd.mancc = cbb_ncc.Text;
            hd.ngaynhap = Convert.ToDateTime(dtp_ngayn.Text);
            db.SaveChanges();
            MessageBox.Show("Sửa thành công");
            load_luoi();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Them")
            {
                hoaDonNhapBindingSource.AddNew();
                bt_them.Text = "luu";
                txt_mahdn.Focus();
            }
            else
            {
                var q = from d in db.HoaDonNhap
                        where d.mahdn == txt_mahdn.Text
                        select d;
                if (q.Count() == 0)
                {
                    HoaDonNhap hd = new HoaDonNhap();
                    hd.mahdn = txt_mahdn.Text;
                    hd.manv = cbb_nv.Text;
                    hd.mancc = cbb_ncc.Text;
                    hd.ngaynhap = DateTime.Parse(dtp_ngayn.Text);
                    db.HoaDonNhap.Add(hd);
                    db.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    load_luoi();
                }
                else
                    MessageBox.Show("Trùng mã");
            }
        }

        private void luoi_hdn_SelectionChanged(object sender, EventArgs e)
        {
            if (luoi_hdn.SelectedRows.Count != 0)
            {
                txt_mahdn.Text = luoi_hdn.CurrentRow.Cells[0].Value.ToString();
                cbb_nv.Text = luoi_hdn.CurrentRow.Cells[1].Value.ToString();
                cbb_ncc.Text = luoi_hdn.CurrentRow.Cells[2].Value.ToString();
                dtp_ngayn.Text = luoi_hdn.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            HoaDonNhap h = new HoaDonNhap();
            var q = from m in db.HoaDonNhap
                    where m.mahdn == txt_mahdn.Text
                    select m;
            h = q.FirstOrDefault();
            db.HoaDonNhap.Remove(h);
            db.SaveChanges();
            MessageBox.Show("Xóa thành công");
            load_luoi();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            cbb_nv.Enabled = false;
            cbb_ncc.Enabled = false;
            dtp_ngayn.Enabled = false;
            var q = from hd in db.HoaDonNhap
                    where hd.mahdn == txt_mahdn.Text
                    select hd;
            luoi_hdn.DataSource = q.ToList();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
