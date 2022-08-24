using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.Trangchu
{
    public partial class trangchu : Form
    {
        public trangchu()
        {
            InitializeComponent();
        }
        private void cậpNhậtTtMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcapnhatdulieu.capnhatttmathang f = new frmcapnhatdulieu.capnhatttmathang();
            f.ShowDialog();
        }
        private void cậpNhậtTtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcapnhatdulieu.capnhatttkhachhang f = new frmcapnhatdulieu.capnhatttkhachhang();
            f.ShowDialog();
        }
        private void cậpNhậtHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcapnhatdulieu.capnhattthdnhap f = new frmcapnhatdulieu.capnhattthdnhap();
            f.ShowDialog();
        }
        private void cậpNhậtTtNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmcapnhatdulieu.capnhatttnhanvien f = new frmcapnhatdulieu.capnhatttnhanvien();
            f.ShowDialog();
        }
        private void tìmKiếmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiem.timkiemmathang f = new frmtimkiem.timkiemmathang();
            f.ShowDialog();
        }
        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiem.timkiemkhachhang f = new frmtimkiem.timkiemkhachhang();
            f.ShowDialog();
        }
        private void tìmKiếmNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiem.timkiemnhanvien f = new frmtimkiem.timkiemnhanvien();
            f.ShowDialog();
        }
        private void tìmKiếmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiem.timkiemttncc f = new frmtimkiem.timkiemttncc();
            f.ShowDialog();
        }
        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmxuatnhaphang.nhaphang f = new frmxuatnhaphang.nhaphang();
            f.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmxuatnhaphang.xuathang f = new frmxuatnhaphang.xuathang();
            f.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void thốngKêMặtHàngTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportThongKe.frm_thongkehangtronhkho f = new reportThongKe.frm_thongkehangtronhkho();
            f.ShowDialog();
        }

        private void thốngKêThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportThongKe.frm_thongkethethang f = new reportThongKe.frm_thongkethethang();
            f.ShowDialog();
        }

        private void thốngKêTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportThongKe.frm_thongketheonam f = new reportThongKe.frm_thongketheonam();
            f.ShowDialog();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportThongKe.frm_Hoadonban f = new reportThongKe.frm_Hoadonban();
            f.ShowDialog();

        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportThongKe.frm_hoadonnhap f = new reportThongKe.frm_hoadonnhap();
            f.ShowDialog();
        }

        private void thốngKêHàngBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void bt_dangxuat_Click(object sender, EventArgs e)
        {
            frmadangnhaphethong.dangnhap f = new frmadangnhaphethong.dangnhap();
            f.Show();
            this.Hide();
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            lb_nhanvien.Text = "Xin Chào:" + frmadangnhaphethong.dangnhap.tendn;
            lb_chucvu.Text = "Chức vụ:" + frmadangnhaphethong.dangnhap.chucvu;
            if (frmadangnhaphethong.dangnhap.chucvu == "nhân viên")
            {
                cậpNhậtTtMặtHàngToolStripMenuItem.Enabled = false;
                thốngKêToolStripMenuItem.Enabled = false;
                cậpNhậtTtNhânViênToolStripMenuItem.Enabled = false;

            }
        }

        private void cậpNhậtDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngKíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadangnhaphethong.dangkitaikhoan f = new frmadangnhaphethong.dangkitaikhoan();
            f.ShowDialog();

        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadangnhaphethong.dangnhap f = new frmadangnhaphethong.dangnhap();
            f.ShowDialog();
        }

        private void nhậpLạiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmadangnhaphethong.nhaplaimk f = new frmadangnhaphethong.nhaplaimk();
            f.ShowDialog();
        }
    }
}
