namespace QLMP.reportThongKe
{
    partial class frm_thongketheonam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_in = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Thongkenam1 = new QLMP.reportThongKe.Thongkenam();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.bt_thoat);
            this.groupControl1.Controls.Add(this.bt_in);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(703, 100);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thuộc tính";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.crystalReportViewer1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 100);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(703, 310);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thống kê";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(446, 56);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 9;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_in
            // 
            this.bt_in.Location = new System.Drawing.Point(321, 58);
            this.bt_in.Name = "bt_in";
            this.bt_in.Size = new System.Drawing.Size(75, 23);
            this.bt_in.TabIndex = 8;
            this.bt_in.Text = "In";
            this.bt_in.UseVisualStyleBackColor = true;
            this.bt_in.Click += new System.EventHandler(this.bt_in_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_nam);
            this.groupBox1.Location = new System.Drawing.Point(81, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(200, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Năm";
            // 
            // cb_nam
            // 
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(37, 19);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(121, 21);
            this.cb_nam.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 23);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.Thongkenam1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(699, 285);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // frm_thongketheonam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 410);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_thongketheonam";
            this.Text = "frm_thongketheonam";
            this.Load += new System.EventHandler(this.frm_thongketheonam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_in;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_nam;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Thongkenam Thongkenam1;
    }
}