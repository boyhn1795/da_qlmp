using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLMP.frmxuatnhaphang
{
    public partial class nhaphang : Form
    {
        string kn = @"Data Source=DESKTOP-R6AFIKJ;Initial Catalog=QLBHMyPham;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        public nhaphang()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        void load_mh()
        {
            matHangBindingSource.DataSource = db.MatHang.ToList();
        }

        //void load_cthd()
        //{
        //    chitiethoadonnhapBindingSource.DataSource = db.chitiethoadonnhaps.ToList();
        //}
        void load_cbbma()
        {
            cb_mahdn.DataSource = db.HoaDonNhap.ToList();
            cb_mahdn.DisplayMember = "mahdn";
            cb_mahdn.ValueMember = "mahdn";
        }
        private void nhaphang_Load(object sender, EventArgs e)
        {
            ketnoi = new SqlConnection(kn);
            load_mh();
            load_cbbma();
        }

        private void bt_vedau_Click(object sender, EventArgs e)
        {
            matHangBindingSource.MoveFirst();
        }

        private void bt_vetr_Click(object sender, EventArgs e)
        {
            matHangBindingSource.MovePrevious();
        }

        private void bt_vesau_Click(object sender, EventArgs e)
        {
            matHangBindingSource.MoveNext();
        }

        private void bt_vecuoi_Click(object sender, EventArgs e)
        {
            matHangBindingSource.MoveLast();
        }

        private void bt_chọn_Click(object sender, EventArgs e)
        {
            if (cb_mahdn.Text != "")
            {
                chitiethoadonnhapBindingSource.AddNew();
                luoi_cthdn.CurrentRow.Cells[0].Value = cb_mahdn.Text;
                luoi_cthdn.CurrentRow.Cells[1].Value = luoi_mh.CurrentRow.Cells[0].Value.ToString();
            }
            else 
                MessageBox.Show("Bạn chưa nhập mã hóa đơn !");            
        }

        private void bt_luu_Click(object sender, EventArgs e)
        {
            Chitiethoadonnhap ct = new Chitiethoadonnhap();
            ct.mahdn = luoi_cthdn.CurrentRow.Cells[0].Value.ToString();
            ct.mamh = luoi_cthdn.CurrentRow.Cells[1].Value.ToString();
            ct.soluongnhap = decimal.Parse(luoi_cthdn.CurrentRow.Cells[2].Value.ToString());
            ct.dongianhap = decimal.Parse(luoi_cthdn.CurrentRow.Cells[3].Value.ToString());
            db.Chitiethoadonnhap.Add(ct);
            ketnoi.Open();
            sql = @"Update MatHang set tonkho = tonkho +" + int.Parse(luoi_cthdn.CurrentRow.Cells[2].Value.ToString()) + "Where mamh = '" + luoi_cthdn.CurrentRow.Cells[1].Value.ToString() + "'";
            thuchien = new SqlCommand(sql, ketnoi);
            thuchien.ExecuteNonQuery();
            ketnoi.Close();
            db.SaveChanges();
            matHangBindingSource.DataSource = db.MatHang.ToList();
            MessageBox.Show("Lưu thành công");                      
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }      
    }
}
