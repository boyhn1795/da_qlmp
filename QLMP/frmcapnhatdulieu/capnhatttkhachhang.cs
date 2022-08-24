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
    public partial class capnhatttkhachhang : Form
    {
        public capnhatttkhachhang()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities qlmp = new QLBHMyPhamEntities();
        private void load_luoi()
        {
            khachHangBindingSource.DataSource = qlmp.KhachHang.ToList();
        }
        private void capnhatttkhachhang_Load(object sender, EventArgs e)
        {
            load_luoi();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm")
            {
                khachHangBindingSource.AddNew();
                bt_them.Text = "Lưu";

            }
            else
            {
                var q = from m in qlmp.KhachHang
                        where m.makh == txt_makh.Text
                        select m;
                if (q.Count() == 0)
                {
                    KhachHang kh = new KhachHang();
                    kh.makh = txt_makh.Text;
                    kh.tenkh = txt_tenkh.Text;
                    kh.diachi = txt_dc.Text;
                    kh.sdt = txt_sdt.Text;
                    qlmp.KhachHang.Add(kh);
                    qlmp.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    load_luoi();
                }
                else
                {
                    MessageBox.Show("Trùng mã");
                    txt_makh.Text = "";
                    txt_makh.Focus();
                }
            }
        }

        private void luoi_kh_SelectionChanged(object sender, EventArgs e)
        {
            if (luoi_kh.SelectedRows.Count != 0)
            {
                txt_makh.Text = luoi_kh.CurrentRow.Cells[0].Value.ToString();
                txt_tenkh.Text = luoi_kh.CurrentRow.Cells[1].Value.ToString();
                txt_dc.Text = luoi_kh.CurrentRow.Cells[2].Value.ToString();
                txt_sdt.Text = luoi_kh.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            var q = from n in qlmp.KhachHang
                    where n.makh == txt_makh.Text
                    select n;
            kh = q.FirstOrDefault();
            kh.tenkh = txt_tenkh.Text;
            kh.diachi = txt_dc.Text;
            kh.sdt = txt_sdt.Text;
            qlmp.SaveChanges();
            MessageBox.Show("Sửa thành công");
            load_luoi();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            var q = from m in qlmp.KhachHang
                    where m.makh == txt_makh.Text
                    select m;
            kh = q.FirstOrDefault();
            qlmp.KhachHang.Remove(kh);
            qlmp.SaveChanges();
            MessageBox.Show("Xóa thành công");
            load_luoi();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
