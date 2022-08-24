using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace QLMP.frmadangnhaphethong
{
    public partial class dangkitaikhoan : Form
    {
        public dangkitaikhoan()
        {
            InitializeComponent();
        }

        private void bt_dki_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text == "" || txt_tendn.Text == "" || txt_mk.Text == "" || txt_nhaplaimk.Text == "" || txt_ns.Text == "" || cbb_gt.Text == "" || txt_sdt.Text == "" || txt_dc.Text == "" || txt_tk.Text == "")
            {
                MessageBox.Show("Nhập thiếu dữ liệu!");
            }
            else
            {
                if (txt_mk.Text == txt_nhaplaimk.Text)
                {              
                        QLBHMyPhamEntities qlmp = new QLBHMyPhamEntities();
                        var query = qlmp.NhanVien.Where(c => c.manv == txt_manv.Text);
                        var course = query.SingleOrDefault();
                        if (course == null)
                        {
                            NhanVien nv = new NhanVien();
                            nv.manv = txt_manv.Text;
                            nv.tennv = txt_tendn.Text;
                            nv.matkhau = txt_mk.Text;                           
                            nv.gioitinh = cbb_gt.Text;
                            nv.sdt = txt_sdt.Text;
                            nv.diachi = txt_dc.Text;
                            nv.taikhoan = txt_tk.Text;
                        nv.chucvu = txt_cv.Text;
                            DateTime dt;
                            if (DateTime.TryParseExact(txt_ns.Text, "dd'/'MM'/'yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt) == true)
                            {
                                nv.ngaysinh = DateTime.ParseExact(txt_ns.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                qlmp.NhanVien.Add(nv);
                                qlmp.SaveChanges();
                                MessageBox.Show("Đăng ký thành công!");
                            }
                            else
                            {
                                MessageBox.Show("Lỗi định dạng ngày tháng năm sinh!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tài khoản đã tồn tại!");
                        }
                    }
                 else
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa chính xác!");
                }
            }
        }

        private void dangkitaikhoan_Load(object sender, EventArgs e)
        {

        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
