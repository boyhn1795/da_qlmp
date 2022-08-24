namespace QLMP.frmtimkiem
{
    partial class timkiemttncc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(timkiemttncc));
            this.cb_ten = new System.Windows.Forms.ComboBox();
            this.cb_ma = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_ten = new System.Windows.Forms.RadioButton();
            this.rbt_ma = new System.Windows.Forms.RadioButton();
            this.bt_tk = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.luoi_ncc = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nCCBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nCCBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luoi_ncc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingNavigator)).BeginInit();
            this.nCCBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_ten
            // 
            this.cb_ten.FormattingEnabled = true;
            this.cb_ten.Location = new System.Drawing.Point(136, 72);
            this.cb_ten.Name = "cb_ten";
            this.cb_ten.Size = new System.Drawing.Size(121, 21);
            this.cb_ten.TabIndex = 8;
            // 
            // cb_ma
            // 
            this.cb_ma.FormattingEnabled = true;
            this.cb_ma.Location = new System.Drawing.Point(136, 25);
            this.cb_ma.Name = "cb_ma";
            this.cb_ma.Size = new System.Drawing.Size(121, 21);
            this.cb_ma.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_ten);
            this.groupBox1.Controls.Add(this.cb_ten);
            this.groupBox1.Controls.Add(this.rbt_ma);
            this.groupBox1.Controls.Add(this.cb_ma);
            this.groupBox1.Location = new System.Drawing.Point(222, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 115);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều kiện tìm kiếm";
            // 
            // rbt_ten
            // 
            this.rbt_ten.AutoSize = true;
            this.rbt_ten.Location = new System.Drawing.Point(18, 72);
            this.rbt_ten.Name = "rbt_ten";
            this.rbt_ten.Size = new System.Drawing.Size(113, 17);
            this.rbt_ten.TabIndex = 9;
            this.rbt_ten.TabStop = true;
            this.rbt_ten.Text = "Tên nhà cung cấp";
            this.rbt_ten.UseVisualStyleBackColor = true;
            // 
            // rbt_ma
            // 
            this.rbt_ma.AutoSize = true;
            this.rbt_ma.Location = new System.Drawing.Point(18, 25);
            this.rbt_ma.Name = "rbt_ma";
            this.rbt_ma.Size = new System.Drawing.Size(109, 17);
            this.rbt_ma.TabIndex = 0;
            this.rbt_ma.TabStop = true;
            this.rbt_ma.Text = "Mã nhà cung cấp";
            this.rbt_ma.UseVisualStyleBackColor = true;
            // 
            // bt_tk
            // 
            this.bt_tk.Location = new System.Drawing.Point(584, 84);
            this.bt_tk.Name = "bt_tk";
            this.bt_tk.Size = new System.Drawing.Size(151, 23);
            this.bt_tk.TabIndex = 10;
            this.bt_tk.Text = "Tìm kiếm";
            this.bt_tk.UseVisualStyleBackColor = true;
            this.bt_tk.Click += new System.EventHandler(this.bt_tk_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(584, 134);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(151, 23);
            this.bt_thoat.TabIndex = 11;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.luoi_ncc);
            this.groupBox2.Location = new System.Drawing.Point(72, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 180);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // luoi_ncc
            // 
            this.luoi_ncc.AutoGenerateColumns = false;
            this.luoi_ncc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.luoi_ncc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luoi_ncc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.luoi_ncc.DataSource = this.nCCBindingSource;
            this.luoi_ncc.Location = new System.Drawing.Point(18, 19);
            this.luoi_ncc.Name = "luoi_ncc";
            this.luoi_ncc.Size = new System.Drawing.Size(589, 159);
            this.luoi_ncc.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "mancc";
            this.dataGridViewTextBoxColumn1.HeaderText = "mancc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tenncc";
            this.dataGridViewTextBoxColumn2.HeaderText = "tenncc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "diachi";
            this.dataGridViewTextBoxColumn3.HeaderText = "diachi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "sdt";
            this.dataGridViewTextBoxColumn4.HeaderText = "sdt";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // nCCBindingSource
            // 
            this.nCCBindingSource.DataSource = typeof(QLMP.NCC);
            // 
            // nCCBindingNavigator
            // 
            this.nCCBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nCCBindingNavigator.BindingSource = this.nCCBindingSource;
            this.nCCBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nCCBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nCCBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nCCBindingNavigatorSaveItem});
            this.nCCBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nCCBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nCCBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nCCBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nCCBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nCCBindingNavigator.Name = "nCCBindingNavigator";
            this.nCCBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nCCBindingNavigator.Size = new System.Drawing.Size(836, 25);
            this.nCCBindingNavigator.TabIndex = 13;
            this.nCCBindingNavigator.Text = "bindingNavigator1";
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
            // nCCBindingNavigatorSaveItem
            // 
            this.nCCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nCCBindingNavigatorSaveItem.Enabled = false;
            this.nCCBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nCCBindingNavigatorSaveItem.Image")));
            this.nCCBindingNavigatorSaveItem.Name = "nCCBindingNavigatorSaveItem";
            this.nCCBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.nCCBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(167, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tìm kiếm thông tin nhà cung cấp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timkiemttncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(836, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nCCBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_tk);
            this.Controls.Add(this.groupBox1);
            this.Name = "timkiemttncc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tìm kiếm nhà cung cấp";
            this.Load += new System.EventHandler(this.timkiemttncc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luoi_ncc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCCBindingNavigator)).EndInit();
            this.nCCBindingNavigator.ResumeLayout(false);
            this.nCCBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_ten;
        private System.Windows.Forms.ComboBox cb_ma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_ten;
        private System.Windows.Forms.RadioButton rbt_ma;
        private System.Windows.Forms.Button bt_tk;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView luoi_ncc;
        private System.Windows.Forms.BindingSource nCCBindingSource;
        private System.Windows.Forms.BindingNavigator nCCBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nCCBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}