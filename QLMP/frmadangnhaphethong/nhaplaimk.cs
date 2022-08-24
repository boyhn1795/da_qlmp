using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.frmadangnhaphethong
{
    public partial class nhaplaimk : Form
    {
        public nhaplaimk()
        {
            InitializeComponent();
        }

        private void nhaplaimk_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            if (txt_tendn.Text == "" || txt_mk.Text == "" || txt_nhaplaimk.Text == "")
            {
                MessageBox.Show("Nhập thiếu dữ liệu!");
            }
            else
            {
                if (txt_mk.Text != txt_nhaplaimk.Text)
                {
                    MessageBox.Show("Xác nhận mật khẩu chưa chính xác!");
                }
                else
                {
                    QLBHMyPhamEntities qlmp = new QLBHMyPhamEntities();
                    var query = qlmp.NhanVien.Where(c => c.taikhoan == txt_tendn.Text);
                    var course = query.SingleOrDefault();
                    if (course == null)
                    {
                        MessageBox.Show("Thông tin chưa chính xác!");
                    }
                    else
                    {
                        NhanVien nv = qlmp.NhanVien.Single(c => c.taikhoan == txt_tendn.Text);
                        nv.matkhau = txt_mk.Text;
                        qlmp.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công!");
                    }
                }
            }
        }
    }
}
