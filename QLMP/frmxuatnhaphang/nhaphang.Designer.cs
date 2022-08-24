namespace QLMP.frmxuatnhaphang
{
    partial class nhaphang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nhaphang));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_mahdn = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_chọn = new System.Windows.Forms.Button();
            this.bt_vesau = new System.Windows.Forms.Button();
            this.bt_vecuoi = new System.Windows.Forms.Button();
            this.bt_vetr = new System.Windows.Forms.Button();
            this.bt_vedau = new System.Windows.Forms.Button();
            this.luoi_mh = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matHangBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.matHangBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.luoi_cthdn = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chitiethoadonnhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi_mh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingNavigator)).BeginInit();
            this.matHangBindingNavigator.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi_cthdn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonnhapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 35);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Phiếu nhập hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_mahdn);
            this.groupBox1.Location = new System.Drawing.Point(23, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 51);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa đơn nhập";
            // 
            // cb_mahdn
            // 
            this.cb_mahdn.FormattingEnabled = true;
            this.cb_mahdn.Location = new System.Drawing.Point(18, 21);
            this.cb_mahdn.Name = "cb_mahdn";
            this.cb_mahdn.Size = new System.Drawing.Size(121, 21);
            this.cb_mahdn.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_chọn);
            this.groupBox2.Controls.Add(this.bt_vesau);
            this.groupBox2.Controls.Add(this.bt_vecuoi);
            this.groupBox2.Controls.Add(this.bt_vetr);
            this.groupBox2.Controls.Add(this.bt_vedau);
            this.groupBox2.Controls.Add(this.luoi_mh);
            this.groupBox2.Location = new System.Drawing.Point(23, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 199);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mặt hàng";
            // 
            // bt_chọn
            // 
            this.bt_chọn.Location = new System.Drawing.Point(317, 158);
            this.bt_chọn.Name = "bt_chọn";
            this.bt_chọn.Size = new System.Drawing.Size(75, 23);
            this.bt_chọn.TabIndex = 10;
            this.bt_chọn.Text = "Chọn";
            this.bt_chọn.UseVisualStyleBackColor = true;
            this.bt_chọn.Click += new System.EventHandler(this.bt_chọn_Click);
            // 
            // bt_vesau
            // 
            this.bt_vesau.Location = new System.Drawing.Point(475, 158);
            this.bt_vesau.Name = "bt_vesau";
            this.bt_vesau.Size = new System.Drawing.Size(75, 23);
            this.bt_vesau.TabIndex = 11;
            this.bt_vesau.Text = "Về sau";
            this.bt_vesau.UseVisualStyleBackColor = true;
            this.bt_vesau.Click += new System.EventHandler(this.bt_vesau_Click);
            // 
            // bt_vecuoi
            // 
            this.bt_vecuoi.Location = new System.Drawing.Point(605, 158);
            this.bt_vecuoi.Name = "bt_vecuoi";
            this.bt_vecuoi.Size = new System.Drawing.Size(75, 23);
            this.bt_vecuoi.TabIndex = 12;
            this.bt_vecuoi.Text = "Về cuối";
            this.bt_vecuoi.UseVisualStyleBackColor = true;
            this.bt_vecuoi.Click += new System.EventHandler(this.bt_vecuoi_Click);
            // 
            // bt_vetr
            // 
            this.bt_vetr.Location = new System.Drawing.Point(159, 158);
            this.bt_vetr.Name = "bt_vetr";
            this.bt_vetr.Size = new System.Drawing.Size(75, 23);
            this.bt_vetr.TabIndex = 13;
            this.bt_vetr.Text = "Về trước";
            this.bt_vetr.UseVisualStyleBackColor = true;
            this.bt_vetr.Click += new System.EventHandler(this.bt_vetr_Click);
            // 
            // bt_vedau
            // 
            this.bt_vedau.Location = new System.Drawing.Point(18, 158);
            this.bt_vedau.Name = "bt_vedau";
            this.bt_vedau.Size = new System.Drawing.Size(75, 23);
            this.bt_vedau.TabIndex = 9;
            this.bt_vedau.Text = "Về đầu";
            this.bt_vedau.UseVisualStyleBackColor = true;
            this.bt_vedau.Click += new System.EventHandler(this.bt_vedau_Click);
            // 
            // luoi_mh
            // 
            this.luoi_mh.AutoGenerateColumns = false;
            this.luoi_mh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi_mh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.luoi_mh.DataSource = this.matHangBindingSource;
            this.luoi_mh.Location = new System.Drawing.Point(18, 19);
            this.luoi_mh.Name = "luoi_mh";
            this.luoi_mh.Size = new System.Drawing.Size(645, 118);
            this.luoi_mh.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mamh";
            this.dataGridViewTextBoxColumn1.HeaderText = "mamh";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenmh";
            this.dataGridViewTextBoxColumn2.HeaderText = "tenmh";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tenncc";
            this.dataGridViewTextBoxColumn3.HeaderText = "tenncc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "namsx";
            this.dataGridViewTextBoxColumn4.HeaderText = "namsx";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "tonkho";
            this.dataGridViewTextBoxColumn5.HeaderText = "tonkho";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dongia";
            this.dataGridViewTextBoxColumn6.HeaderText = "dongia";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataSource = typeof(QLMP.MatHang);
            // 
            // matHangBindingNavigator
            // 
            this.matHangBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.matHangBindingNavigator.BindingSource = this.matHangBindingSource;
            this.matHangBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.matHangBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.matHangBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.matHangBindingNavigatorSaveItem});
            this.matHangBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.matHangBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.matHangBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.matHangBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.matHangBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.matHangBindingNavigator.Name = "matHangBindingNavigator";
            this.matHangBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.matHangBindingNavigator.Size = new System.Drawing.Size(815, 25);
            this.matHangBindingNavigator.TabIndex = 27;
            this.matHangBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // matHangBindingNavigatorSaveItem
            // 
            this.matHangBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.matHangBindingNavigatorSaveItem.Enabled = false;
            this.matHangBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("matHangBindingNavigatorSaveItem.Image")));
            this.matHangBindingNavigatorSaveItem.Name = "matHangBindingNavigatorSaveItem";
            this.matHangBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.matHangBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.luoi_cthdn);
            this.groupBox3.Location = new System.Drawing.Point(23, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(550, 143);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn nhập";
            // 
            // luoi_cthdn
            // 
            this.luoi_cthdn.AutoGenerateColumns = false;
            this.luoi_cthdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi_cthdn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.luoi_cthdn.DataSource = this.chitiethoadonnhapBindingSource;
            this.luoi_cthdn.Location = new System.Drawing.Point(18, 14);
            this.luoi_cthdn.Name = "luoi_cthdn";
            this.luoi_cthdn.Size = new System.Drawing.Size(484, 123);
            this.luoi_cthdn.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "mahdn";
            this.dataGridViewTextBoxColumn7.HeaderText = "mahdn";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "mamh";
            this.dataGridViewTextBoxColumn8.HeaderText = "mamh";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "soluongnhap";
            this.dataGridViewTextBoxColumn9.HeaderText = "soluongnhap";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "dongianhap";
            this.dataGridViewTextBoxColumn10.HeaderText = "dongianhap";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // chitiethoadonnhapBindingSource
            // 
            this.chitiethoadonnhapBindingSource.DataSource = typeof(QLMP.Chitiethoadonnhap);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(628, 422);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 31;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_luu
            // 
            this.bt_luu.Location = new System.Drawing.Point(628, 368);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 29;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = true;
            this.bt_luu.Click += new System.EventHandler(this.bt_luu_Click);
            // 
            // nhaphang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(815, 467);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matHangBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "nhaphang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nhaphang";
            this.Load += new System.EventHandler(this.nhaphang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoi_mh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingNavigator)).EndInit();
            this.matHangBindingNavigator.ResumeLayout(false);
            this.matHangBindingNavigator.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoi_cthdn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chitiethoadonnhapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_mahdn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_chọn;
        private System.Windows.Forms.Button bt_vesau;
        private System.Windows.Forms.Button bt_vecuoi;
        private System.Windows.Forms.Button bt_vetr;
        private System.Windows.Forms.Button bt_vedau;
        private System.Windows.Forms.DataGridView luoi_mh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private System.Windows.Forms.BindingNavigator matHangBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton matHangBindingNavigatorSaveItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView luoi_cthdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.BindingSource chitiethoadonnhapBindingSource;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_luu;
    }
}