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
    public partial class capnhatttmathang : Form
    {
        public capnhatttmathang()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities qlmp = new QLBHMyPhamEntities();
        private void load_luoi()
        {
            matHangBindingSource.DataSource = qlmp.MatHang.ToList();
        }
        private void capnhatttmathang_Load(object sender, EventArgs e)
        {
            load_luoi();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm")
            {
                matHangBindingSource.AddNew();
                bt_them.Text = "Lưu";

            }
            else
            {
                var q = from m in qlmp.MatHang
                        where m.mamh == txt_mamh.Text
                        select m;
                if (q.Count() == 0)
                {
                    MatHang mh = new MatHang();
                    mh.mamh = txt_mamh.Text;
                    mh.tenmh = txt_tenmh.Text;
                    mh.tenncc = txt_tennsx.Text;
                    mh.namsx = int.Parse(txt_namsx.Text);
                    mh.tonkho = decimal.Parse(txt_sl.Text);
                    mh.dongia = decimal.Parse(txt_dongia.Text);
                    qlmp.MatHang.Add(mh);
                    qlmp.SaveChanges();
                    MessageBox.Show("Thêm thành công");
                    load_luoi();
                }
                else
                {
                    MessageBox.Show("Trùng mã");
                    txt_mamh.Text = "";
                    txt_mamh.Focus();
                }
            }
        }
        private void bt_sua_Click(object sender, EventArgs e)
        {
            MatHang mh = new MatHang();
            var q = from n in qlmp.MatHang
                    where n.mamh == txt_mamh.Text
                    select n;
            mh = q.FirstOrDefault();
            mh.tenmh = txt_tenmh.Text;
            mh.tenncc = txt_tennsx.Text;
            mh.namsx = int.Parse(txt_namsx.Text);
            mh.tonkho = int.Parse(txt_sl.Text);
            mh.dongia = int.Parse(txt_dongia.Text);
            qlmp.SaveChanges();
            MessageBox.Show("Sửa thành công");
            load_luoi();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            MatHang mh = new MatHang();
            var q = from m in qlmp.MatHang
                    where m.mamh == txt_mamh.Text
                    select m;
            mh = q.FirstOrDefault();
            qlmp.MatHang.Remove(mh);
            qlmp.SaveChanges();
            MessageBox.Show("Xóa thành công");
            load_luoi();
        }

        private void luoi_mh_SelectionChanged(object sender, EventArgs e)
        {
            if (luoi_mh.SelectedRows.Count != 0)
            {
                txt_mamh.Text = luoi_mh.CurrentRow.Cells[0].Value.ToString();
                txt_tenmh.Text = luoi_mh.CurrentRow.Cells[1].Value.ToString();
                txt_tennsx.Text = luoi_mh.CurrentRow.Cells[2].Value.ToString();
                txt_namsx.Text = luoi_mh.CurrentRow.Cells[3].Value.ToString();
                txt_sl.Text = luoi_mh.CurrentRow.Cells[4].Value.ToString();
                txt_dongia.Text = luoi_mh.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void matHangBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
