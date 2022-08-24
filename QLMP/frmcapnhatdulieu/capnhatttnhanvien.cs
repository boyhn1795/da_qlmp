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
    public partial class capnhatttnhanvien : Form
    {
        public capnhatttnhanvien()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities qlmp = new QLBHMyPhamEntities();
        private void load_luoi()
        {
            nhanVienBindingSource.DataSource = qlmp.NhanVien.ToList();
        }
        private void capnhatttnhanvien_Load(object sender, EventArgs e)
        {
            load_luoi();
           
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Them")
            {
                nhanVienBindingSource.AddNew();
                bt_them.Text = "luu";
                txt_manv.Focus();
            }
            else
            {
                var q = from d in qlmp.NhanVien
                        where d.manv == txt_manv.Text
                        select d;
                if (q.Count() == 0)
                {
                    NhanVien nv = new NhanVien();
                    nv.manv =txt_manv.Text;
                    nv.tennv =txt_ten.Text;                   
                    nv.ngaysinh = Convert.ToDateTime(dtp_ns.Text);
                    string gioitinh;
                    if (rd_nam.Checked) gioitinh = "nam";
                    else gioitinh = "nữ";
                    nv.gioitinh = gioitinh;
                    nv.diachi = txt_dc.Text;
                    nv.sdt = txt_sdt.Text;
                    nv.matkhau = txt_mk.Text;
                    nv.taikhoan = txt_tk.Text;
                    nv.chucvu = txt_chucvu.Text;
                    qlmp.NhanVien.Add(nv);
                    qlmp.SaveChanges();
                    MessageBox.Show("Thêm thành công");

                    load_luoi();
                }
                else
                    MessageBox.Show("Trùng mã");
            }
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            var q = from n in qlmp.NhanVien
                    where n.manv == txt_manv.Text
                    select n;
            nv = q.FirstOrDefault();
            nv.tennv = txt_ten.Text;
            nv.ngaysinh = Convert.ToDateTime(dtp_ns.Text);
            string gioitinh;
            if (rd_nam.Checked) gioitinh = "nam";
            else gioitinh = "nữ";
            nv.gioitinh = gioitinh;
            nv.diachi = txt_dc.Text;
            nv.sdt = txt_sdt.Text;
            nv.matkhau = txt_mk.Text;
            nv.taikhoan = txt_tk.Text;
            nv.chucvu = txt_chucvu.Text;
            qlmp.SaveChanges();
            MessageBox.Show("Sửa thành công");
            load_luoi();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            var q = from m in qlmp.NhanVien
                    where m.manv == txt_manv.Text
                    select m;
            nv = q.FirstOrDefault();
            qlmp.NhanVien.Remove(nv);
            qlmp.SaveChanges();
            MessageBox.Show("Xóa thành công");
            load_luoi();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void luoi_nv_SelectionChanged(object sender, EventArgs e)
        {
            if (luoi_nv.SelectedRows.Count != 0)
            {
                txt_manv.Text = luoi_nv.CurrentRow.Cells[0].Value.ToString();
                txt_ten.Text = luoi_nv.CurrentRow.Cells[1].Value.ToString();
                dtp_ns.Text = luoi_nv.CurrentRow.Cells[2].Value.ToString();
                string gtinh;
                gtinh = luoi_nv.CurrentRow.Cells[3].Value.ToString().Trim();
                if (gtinh == "nam")
                {
                    rd_nam.Checked = true;
                }
                else
                {
                    rd_nu.Checked = true;
                }
                txt_dc.Text = luoi_nv.CurrentRow.Cells[4].Value.ToString();
                txt_sdt.Text = luoi_nv.CurrentRow.Cells[5].Value.ToString();
                txt_mk.Text = luoi_nv.CurrentRow.Cells[6].Value.ToString();
                txt_tk.Text = luoi_nv.CurrentRow.Cells[7].Value.ToString();
                txt_chucvu.Text = luoi_nv.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void rd_nam_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

