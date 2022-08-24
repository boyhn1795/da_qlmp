using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMP.reportThongKe
{
    public partial class frm_thongkehangtronhkho : Form
    {
        public frm_thongkehangtronhkho()
        {
            InitializeComponent();
        }
        QLBHMyPhamEntities db = new QLBHMyPhamEntities();
        private void frm_thongkehangtronhkho_Load(object sender, EventArgs e)
        {
            cb_ma.DataSource = db.MatHang.ToList();
            cb_ma.DisplayMember = "mamh";
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            var q = from m in db.MatHang where (m.mamh == cb_ma.Text && m.tonkho > 0) select m;           
                if (q.Count() !=0)
                {

                    luoi_mh.DataSource = q.ToList();
                    //luoi_mh.Columns[3].Visible = false;                    
                }               
                else
                {
                    MessageBox.Show("Hết hàng trong kho!");
                   luoi_mh.DataSource = q.ToList();
                }               
        }
        public static string ma;
        private void bt_in_Click(object sender, EventArgs e)
        {
            ma = cb_ma.Text;
            frm_dsmathang f = new frm_dsmathang();
            f.Show();
        }
        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                this.Close();
            }
        }
    }
}
