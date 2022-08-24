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
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void dangnhap_Load(object sender, EventArgs e)
        {

        }
        public static string tendn = "";
        public static string chucvu = "";
        void vaotrangchu()
        {           
            var q = db.NhanVien.Where(d => d.taikhoan == txt_tendn.Text).Where(c => c.matkhau == txt_mk.Text);
            var kt = q.SingleOrDefault();
            if (kt == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu chưa chính xác");
            }
            else
            {
                NhanVien nv = new NhanVien();
                var q1 = from d in db.NhanVien
                         where d.taikhoan == txt_tendn.Text
                         select d;
                nv = q1.FirstOrDefault();
                string cv = nv.chucvu.ToString();
                chucvu = cv;
                string tennv = nv.tennv.ToString();
                tendn = tennv;
               //Trangchu.trangchu tc = new Trangchu.trangchu();
                //tc.Show();
                this.Hide();
            }
        }
        private void quenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            nhaplaimk f = new nhaplaimk();
            f.Show();
        }

        private void dktk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangkitaikhoan f = new dangkitaikhoan();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vaotrangchu();
            
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
