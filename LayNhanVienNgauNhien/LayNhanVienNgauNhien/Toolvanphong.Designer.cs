namespace LayNhanVienNgauNhien
{
    partial class Toolvanphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toolvanphong));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lsv_danhsach = new System.Windows.Forms.ListView();
            this.col_stt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_phongban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_chucdanh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_ketqua = new System.Windows.Forms.GroupBox();
            this.lsv_ketqua = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox_chucnang = new System.Windows.Forms.GroupBox();
            this.btnXuatFileExcel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_tongsodong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numeric_nhanvienmoidonvi = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numberich_Tongnhanvien = new System.Windows.Forms.NumericUpDown();
            this.btn_layngaunhien = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.imageList_icontab = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_ketqua.SuspendLayout();
            this.groupBox_chucnang.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nhanvienmoidonvi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberich_Tongnhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1837, 865);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.ImageKey = "(none)";
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1829, 830);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.progressBar1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel1.Controls.Add(this.lsv_danhsach);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_ketqua);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_chucnang);
            this.splitContainer1.Size = new System.Drawing.Size(1823, 824);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(686, 176);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(545, 39);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1097, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(29, 30);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click_1);
            // 
            // lsv_danhsach
            // 
            this.lsv_danhsach.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lsv_danhsach.AllowColumnReorder = true;
            this.lsv_danhsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_stt,
            this.col_manv,
            this.col_Hoten,
            this.col_phongban,
            this.col_chucdanh});
            this.lsv_danhsach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_danhsach.FullRowSelect = true;
            this.lsv_danhsach.GridLines = true;
            this.lsv_danhsach.HideSelection = false;
            this.lsv_danhsach.Location = new System.Drawing.Point(0, 0);
            this.lsv_danhsach.MultiSelect = false;
            this.lsv_danhsach.Name = "lsv_danhsach";
            this.lsv_danhsach.Size = new System.Drawing.Size(1823, 246);
            this.lsv_danhsach.TabIndex = 0;
            this.lsv_danhsach.UseCompatibleStateImageBehavior = false;
            this.lsv_danhsach.View = System.Windows.Forms.View.Details;
            this.lsv_danhsach.SelectedIndexChanged += new System.EventHandler(this.lsv_danhsach_SelectedIndexChanged);
            this.lsv_danhsach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsv_danhsach_KeyDown);
            // 
            // col_stt
            // 
            this.col_stt.Text = "STT";
            this.col_stt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_stt.Width = 100;
            // 
            // col_manv
            // 
            this.col_manv.Text = "Mã Nhân Viên";
            this.col_manv.Width = 200;
            // 
            // col_Hoten
            // 
            this.col_Hoten.Text = "Họ Và Tên";
            this.col_Hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_Hoten.Width = 250;
            // 
            // col_phongban
            // 
            this.col_phongban.Text = "Phòng Ban/Phòng Giao Dịch";
            this.col_phongban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_phongban.Width = 300;
            // 
            // col_chucdanh
            // 
            this.col_chucdanh.Text = "Chức Danh";
            this.col_chucdanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.col_chucdanh.Width = 200;
            // 
            // groupBox_ketqua
            // 
            this.groupBox_ketqua.Controls.Add(this.lsv_ketqua);
            this.groupBox_ketqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ketqua.Location = new System.Drawing.Point(0, 164);
            this.groupBox_ketqua.Name = "groupBox_ketqua";
            this.groupBox_ketqua.Size = new System.Drawing.Size(1823, 410);
            this.groupBox_ketqua.TabIndex = 3;
            this.groupBox_ketqua.TabStop = false;
            this.groupBox_ketqua.Text = "Kết quả";
            // 
            // lsv_ketqua
            // 
            this.lsv_ketqua.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lsv_ketqua.AllowColumnReorder = true;
            this.lsv_ketqua.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsv_ketqua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_ketqua.FullRowSelect = true;
            this.lsv_ketqua.GridLines = true;
            this.lsv_ketqua.HideSelection = false;
            this.lsv_ketqua.Location = new System.Drawing.Point(3, 26);
            this.lsv_ketqua.MultiSelect = false;
            this.lsv_ketqua.Name = "lsv_ketqua";
            this.lsv_ketqua.Size = new System.Drawing.Size(1817, 381);
            this.lsv_ketqua.TabIndex = 1;
            this.lsv_ketqua.UseCompatibleStateImageBehavior = false;
            this.lsv_ketqua.View = System.Windows.Forms.View.Details;
            this.lsv_ketqua.ItemActivate += new System.EventHandler(this.lsv_ketqua_ItemActivate);
            this.lsv_ketqua.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lsv_ketqua_ItemChecked);
            this.lsv_ketqua.BindingContextChanged += new System.EventHandler(this.lsv_ketqua_BindingContextChanged);
            this.lsv_ketqua.SizeChanged += new System.EventHandler(this.lsv_ketqua_SizeChanged);
            this.lsv_ketqua.Resize += new System.EventHandler(this.lsv_ketqua_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã Nhân Viên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Họ Và Tên";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Phòng Ban/Phòng Giao Dịch";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Chức Danh";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // groupBox_chucnang
            // 
            this.groupBox_chucnang.Controls.Add(this.btnXuatFileExcel);
            this.groupBox_chucnang.Controls.Add(this.label2);
            this.groupBox_chucnang.Controls.Add(this.lb_ketqua);
            this.groupBox_chucnang.Controls.Add(this.label5);
            this.groupBox_chucnang.Controls.Add(this.label3);
            this.groupBox_chucnang.Controls.Add(this.lb_tongsodong);
            this.groupBox_chucnang.Controls.Add(this.label1);
            this.groupBox_chucnang.Controls.Add(this.groupBox2);
            this.groupBox_chucnang.Controls.Add(this.groupBox1);
            this.groupBox_chucnang.Controls.Add(this.btn_layngaunhien);
            this.groupBox_chucnang.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_chucnang.Location = new System.Drawing.Point(0, 0);
            this.groupBox_chucnang.Name = "groupBox_chucnang";
            this.groupBox_chucnang.Size = new System.Drawing.Size(1823, 164);
            this.groupBox_chucnang.TabIndex = 2;
            this.groupBox_chucnang.TabStop = false;
            // 
            // btnXuatFileExcel
            // 
            this.btnXuatFileExcel.Enabled = false;
            this.btnXuatFileExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFileExcel.ImageIndex = 0;
            this.btnXuatFileExcel.ImageList = this.imageList1;
            this.btnXuatFileExcel.Location = new System.Drawing.Point(1399, 91);
            this.btnXuatFileExcel.Name = "btnXuatFileExcel";
            this.btnXuatFileExcel.Size = new System.Drawing.Size(243, 40);
            this.btnXuatFileExcel.TabIndex = 15;
            this.btnXuatFileExcel.Text = "Xuất file excel";
            this.btnXuatFileExcel.UseVisualStyleBackColor = true;
            this.btnXuatFileExcel.Click += new System.EventHandler(this.btnXuatFileExcel_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Carlosjj-Microsoft-Office-2013-Excel.256.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(300, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "}";
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.AutoSize = true;
            this.lb_ketqua.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_ketqua.Location = new System.Drawing.Point(262, 130);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(20, 22);
            this.lb_ketqua.TabIndex = 13;
            this.lb_ketqua.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(110, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "{ Tổng số dòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(300, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "}";
            // 
            // lb_tongsodong
            // 
            this.lb_tongsodong.AutoSize = true;
            this.lb_tongsodong.ForeColor = System.Drawing.Color.SeaGreen;
            this.lb_tongsodong.Location = new System.Drawing.Point(262, 26);
            this.lb_tongsodong.Name = "lb_tongsodong";
            this.lb_tongsodong.Size = new System.Drawing.Size(20, 22);
            this.lb_tongsodong.TabIndex = 10;
            this.lb_tongsodong.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(110, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "{ Tổng số dòng :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.numeric_nhanvienmoidonvi);
            this.groupBox2.Location = new System.Drawing.Point(731, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn số nhân viên cần lấy cho mỗi đơn vị";
            // 
            // numeric_nhanvienmoidonvi
            // 
            this.numeric_nhanvienmoidonvi.Location = new System.Drawing.Point(30, 29);
            this.numeric_nhanvienmoidonvi.Name = "numeric_nhanvienmoidonvi";
            this.numeric_nhanvienmoidonvi.Size = new System.Drawing.Size(120, 30);
            this.numeric_nhanvienmoidonvi.TabIndex = 3;
            this.numeric_nhanvienmoidonvi.ValueChanged += new System.EventHandler(this.numeric_nhanvienmoidonvi_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.numberich_Tongnhanvien);
            this.groupBox1.Location = new System.Drawing.Point(349, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 88);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn tổng số nhân viên cần lấy";
            // 
            // numberich_Tongnhanvien
            // 
            this.numberich_Tongnhanvien.Location = new System.Drawing.Point(30, 29);
            this.numberich_Tongnhanvien.Name = "numberich_Tongnhanvien";
            this.numberich_Tongnhanvien.Size = new System.Drawing.Size(120, 30);
            this.numberich_Tongnhanvien.TabIndex = 3;
            this.numberich_Tongnhanvien.ValueChanged += new System.EventHandler(this.numberich_Tongnhanvien_ValueChanged);
            // 
            // btn_layngaunhien
            // 
            this.btn_layngaunhien.Location = new System.Drawing.Point(1399, 29);
            this.btn_layngaunhien.Name = "btn_layngaunhien";
            this.btn_layngaunhien.Size = new System.Drawing.Size(317, 40);
            this.btn_layngaunhien.TabIndex = 1;
            this.btn_layngaunhien.Text = "Lấy Các Nhân Viên Ngẫu Nhiên";
            this.btn_layngaunhien.UseVisualStyleBackColor = true;
            this.btn_layngaunhien.Click += new System.EventHandler(this.btn_layngaunhien_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::LayNhanVienNgauNhien.Properties.Resources.word;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1829, 830);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Word";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::LayNhanVienNgauNhien.Properties.Resources.powerpoint;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1829, 830);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Powerpoint";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // imageList_icontab
            // 
            this.imageList_icontab.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_icontab.ImageSize = new System.Drawing.Size(5, 5);
            this.imageList_icontab.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Toolvanphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1837, 865);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Toolvanphong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Toolvanphong";
            this.Load += new System.EventHandler(this.Toolvanphong_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_ketqua.ResumeLayout(false);
            this.groupBox_chucnang.ResumeLayout(false);
            this.groupBox_chucnang.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_nhanvienmoidonvi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberich_Tongnhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList_icontab;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_layngaunhien;
        private System.Windows.Forms.ListView lsv_danhsach;
        private System.Windows.Forms.ColumnHeader col_manv;
        private System.Windows.Forms.ColumnHeader col_Hoten;
        private System.Windows.Forms.ColumnHeader col_phongban;
        private System.Windows.Forms.ColumnHeader col_chucdanh;
        private System.Windows.Forms.ColumnHeader col_stt;
        private System.Windows.Forms.GroupBox groupBox_chucnang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numeric_nhanvienmoidonvi;
        private System.Windows.Forms.NumericUpDown numberich_Tongnhanvien;
        private System.Windows.Forms.GroupBox groupBox_ketqua;
        private System.Windows.Forms.ListView lsv_ketqua;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_tongsodong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatFileExcel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}