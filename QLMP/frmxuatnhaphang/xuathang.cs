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
    public partial class xuathang : Form
    {
        string kn = @"Data Source=DESKTOP-R6AFIKJ;Initial Catalog=QLBHMyPham;Integrated Security=True";
        string sql;
        SqlConnection ketnoi;
        SqlCommand thuchien;
        public xuathang()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        bool kiemtra(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;
            else return false;
        }
        bool kiemtra_chuoirong()
        {
            if (kiemtra(cb_mahdb.Text) || kiemtra(cb_makh.Text) || kiemtra(cb_manv.Text)) return false;
            return true;
        }
        void vohieuhoa(bool vh)
        {
            cb_manv.Enabled = vh;
            cb_makh.Enabled = vh;
            dtp_nb.Enabled = vh;
        }        
        void load_cb()
        {
            cb_mahdb.DataSource = db.HoaDonBan.ToList();
            cb_mahdb.DisplayMember = "mahdb";
            cb_makh.DataSource = db.KhachHang.ToList();
            cb_makh.DisplayMember = "makh";
            cb_manv.DataSource = db.NhanVien.ToList();
            cb_manv.DisplayMember = "manv";
        }
        void load_mh()
        {
            matHangBindingSource.DataSource = db.MatHang.ToList();
        }
        private void xuathang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHMyPhamDataSet.MatHang' table. You can move, or remove it, as needed.
            //this.matHangTableAdapter.Fill(this.qLBHMyPhamDataSet.MatHang);
            //lookup_tenmh.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            ketnoi = new SqlConnection(kn);
            load_mh();           
            load_cb();            
            vohieuhoa(false);                  
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (bt_them.Text == "Thêm")
            {
                vohieuhoa(true);
                bt_them.Text = "Lưu";
            }
            else
            {
                var q2 = db.HoaDonBan.Where(c => c.mahdb == cb_mahdb.Text);
                var course = q2.SingleOrDefault();
                if (course == null)
                {

                    if (kiemtra_chuoirong())
                    {
                        HoaDonBan hdb = new HoaDonBan();
                        hdb.mahdb = cb_mahdb.Text;
                        hdb.makh = cb_makh.Text;
                        hdb.manv = cb_manv.Text;
                        hdb.ngayban = dtp_nb.Value.Date;
                        db.HoaDonBan.Add(hdb);
                        db.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                        bt_them.Text = "Thêm";
                        load_cb();
                        vohieuhoa(false);
                    }
                    else
                    {
                        MessageBox.Show("Bạn nhập thiếu dữ liệu !", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Mã hóa đơn bán đã tồn tại !", "Thông báo");
                    cb_mahdb.ResetText();
                }
            }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }       
        private void bt_mua_Click(object sender, EventArgs e)
        {
            if (bt_mua.Text == "Mua")
            {

                bt_mua.Text = "Lưu";
                chitiethoadonbanBindingSource.AddNew();
                luoi_cthdb.CurrentRow.Cells[0].Value = cb_mahdb.Text;
                luoi_cthdb.CurrentRow.Cells[1].Value = luoi_mh.CurrentRow.Cells[0].Value.ToString();
                luoi_cthdb.CurrentRow.Cells[3].Value = Math.Round(int.Parse(luoi_mh.CurrentRow.Cells[4].Value.ToString()) * 1.2).ToString();               
            }
            else
            {
                int slx, tonkho;
                tonkho = int.Parse(luoi_mh.CurrentRow.Cells[4].Value.ToString());
                slx = int.Parse(luoi_cthdb.CurrentRow.Cells[2].Value.ToString());
                if (slx <= tonkho)
                {
                    Chitiethoadonban b = new Chitiethoadonban();
                    b.mahdb = cb_mahdb.Text;
                    b.mamh = luoi_cthdb.CurrentRow.Cells[1].Value.ToString();
                    b.soluongban = int.Parse(luoi_cthdb.CurrentRow.Cells[2].Value.ToString());
                    b.dongiaban = int.Parse(luoi_cthdb.CurrentRow.Cells[3].Value.ToString());                      
                    db.Chitiethoadonban.Add(b);
                    ketnoi.Open();
                    sql = @"Update MatHang set tonkho = tonkho -" + int.Parse(luoi_cthdb.CurrentRow.Cells[2].Value.ToString()) + "Where mamh = '" + luoi_mh.CurrentRow.Cells[0].Value.ToString() + "'";
                    thuchien = new SqlCommand(sql, ketnoi);
                    thuchien.ExecuteNonQuery();
                    ketnoi.Close();
                    db.SaveChanges();
                    load_mh();
                    bt_mua.Text = "Mua";
                    MessageBox.Show("Xuất hàng thành công");
                }
                else
                    MessageBox.Show("Số lượng xuất phải nhỏ hơn hoặc bằng số lượng có trong kho, Mời nhập lại", "Thông báo");
            }
            matHangBindingSource.DataSource = db.MatHang.ToList();
        }

        private void bt_tim_Click(object sender, EventArgs e)
        {
            var qr3 = from tk in db.MatHang
                      where tk.tenmh == textBox1.Text
                      select tk;
            luoi_mh.DataSource = qr3.ToList();

        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i< luoi_cthdb.Rows.Count - 1; i++)
            {
                if (luoi_cthdb.Rows[i].Selected)
                {
                    int cs = luoi_cthdb.SelectedRows[0].Index;
                    luoi_cthdb.Rows.RemoveAt(i);
                }
            }

        }
    }
}
