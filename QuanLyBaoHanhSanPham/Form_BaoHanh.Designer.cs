namespace QuanLyBaoHanhSanPham
{
    partial class Form_BaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BaoHanh));
            this.ngaybaohanhgannhat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dulieu = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.TextBox();
            this.motasuco = new System.Windows.Forms.TextBox();
            this.danhgia = new System.Windows.Forms.TextBox();
            this.trangthai = new System.Windows.Forms.TextBox();
            this.thoigianbaohanh = new System.Windows.Forms.TextBox();
            this.ngaymua = new System.Windows.Forms.TextBox();
            this.idsanpham = new System.Windows.Forms.TextBox();
            this.idkhachhang = new System.Windows.Forms.TextBox();
            this.btn_tai = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.nuttim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dulieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuttim)).BeginInit();
            this.SuspendLayout();
            // 
            // ngaybaohanhgannhat
            // 
            this.ngaybaohanhgannhat.Location = new System.Drawing.Point(193, 504);
            this.ngaybaohanhgannhat.Name = "ngaybaohanhgannhat";
            this.ngaybaohanhgannhat.Size = new System.Drawing.Size(263, 22);
            this.ngaybaohanhgannhat.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 354);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời gian bảo hành";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Trạng thái";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Đánh giá";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mô tả sự cố";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Ngày bảo hành gần nhất";
            // 
            // dulieu
            // 
            this.dulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dulieu.Location = new System.Drawing.Point(12, 40);
            this.dulieu.Name = "dulieu";
            this.dulieu.RowHeadersWidth = 51;
            this.dulieu.RowTemplate.Height = 24;
            this.dulieu.Size = new System.Drawing.Size(1026, 240);
            this.dulieu.TabIndex = 10;
            this.dulieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dulieu_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label9.Location = new System.Drawing.Point(12, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Thông tin bảo hành";
            // 
            // tim
            // 
            this.tim.Location = new System.Drawing.Point(241, 12);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(479, 22);
            this.tim.TabIndex = 12;
            // 
            // motasuco
            // 
            this.motasuco.Location = new System.Drawing.Point(193, 474);
            this.motasuco.Name = "motasuco";
            this.motasuco.Size = new System.Drawing.Size(263, 22);
            this.motasuco.TabIndex = 14;
            // 
            // danhgia
            // 
            this.danhgia.Location = new System.Drawing.Point(193, 446);
            this.danhgia.Name = "danhgia";
            this.danhgia.Size = new System.Drawing.Size(263, 22);
            this.danhgia.TabIndex = 15;
            // 
            // trangthai
            // 
            this.trangthai.Location = new System.Drawing.Point(193, 415);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(263, 22);
            this.trangthai.TabIndex = 16;
            // 
            // thoigianbaohanh
            // 
            this.thoigianbaohanh.Location = new System.Drawing.Point(193, 381);
            this.thoigianbaohanh.Name = "thoigianbaohanh";
            this.thoigianbaohanh.Size = new System.Drawing.Size(263, 22);
            this.thoigianbaohanh.TabIndex = 17;
            // 
            // ngaymua
            // 
            this.ngaymua.Location = new System.Drawing.Point(193, 348);
            this.ngaymua.Name = "ngaymua";
            this.ngaymua.Size = new System.Drawing.Size(263, 22);
            this.ngaymua.TabIndex = 18;
            // 
            // idsanpham
            // 
            this.idsanpham.Location = new System.Drawing.Point(193, 318);
            this.idsanpham.Name = "idsanpham";
            this.idsanpham.Size = new System.Drawing.Size(263, 22);
            this.idsanpham.TabIndex = 19;
            // 
            // idkhachhang
            // 
            this.idkhachhang.Location = new System.Drawing.Point(193, 286);
            this.idkhachhang.Name = "idkhachhang";
            this.idkhachhang.Size = new System.Drawing.Size(263, 22);
            this.idkhachhang.TabIndex = 20;
            // 
            // btn_tai
            // 
            this.btn_tai.Image = global::QuanLyBaoHanhSanPham.Properties.Resources.update1;
            this.btn_tai.Location = new System.Drawing.Point(890, 286);
            this.btn_tai.Name = "btn_tai";
            this.btn_tai.Size = new System.Drawing.Size(133, 58);
            this.btn_tai.TabIndex = 24;
            this.btn_tai.Text = "Tải";
            this.btn_tai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_tai.UseVisualStyleBackColor = true;
            this.btn_tai.Click += new System.EventHandler(this.btn_tai_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Image = global::QuanLyBaoHanhSanPham.Properties.Resources.remove;
            this.btn_xoa.Location = new System.Drawing.Point(751, 286);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(133, 58);
            this.btn_xoa.TabIndex = 23;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Image = global::QuanLyBaoHanhSanPham.Properties.Resources.cap_nhat;
            this.btn_capNhat.Location = new System.Drawing.Point(612, 286);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(133, 58);
            this.btn_capNhat.TabIndex = 22;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // btn_them
            // 
            this.btn_them.Image = global::QuanLyBaoHanhSanPham.Properties.Resources.add1;
            this.btn_them.Location = new System.Drawing.Point(473, 286);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(133, 58);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // nuttim
            // 
            this.nuttim.Image = global::QuanLyBaoHanhSanPham.Properties.Resources.search1;
            this.nuttim.Location = new System.Drawing.Point(726, 12);
            this.nuttim.Name = "nuttim";
            this.nuttim.Size = new System.Drawing.Size(19, 27);
            this.nuttim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nuttim.TabIndex = 13;
            this.nuttim.TabStop = false;
            this.nuttim.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_BaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1050, 577);
            this.Controls.Add(this.btn_tai);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.idkhachhang);
            this.Controls.Add(this.idsanpham);
            this.Controls.Add(this.ngaymua);
            this.Controls.Add(this.thoigianbaohanh);
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.danhgia);
            this.Controls.Add(this.motasuco);
            this.Controls.Add(this.nuttim);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dulieu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ngaybaohanhgannhat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_BaoHanh";
            this.Text = "Bảo hành";
            ((System.ComponentModel.ISupportInitialize)(this.dulieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuttim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ngaybaohanhgannhat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dulieu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tim;
        private System.Windows.Forms.PictureBox nuttim;
        private System.Windows.Forms.TextBox motasuco;
        private System.Windows.Forms.TextBox danhgia;
        private System.Windows.Forms.TextBox trangthai;
        private System.Windows.Forms.TextBox thoigianbaohanh;
        private System.Windows.Forms.TextBox ngaymua;
        private System.Windows.Forms.TextBox idsanpham;
        private System.Windows.Forms.TextBox idkhachhang;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_tai;
    }
}