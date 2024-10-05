namespace QuanLyBaoHanhSanPham
{
    partial class Form_sanpham
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
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtsoseri = new System.Windows.Forms.TextBox();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnload = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiemid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnlammmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(151, 50);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(287, 22);
            this.txtid.TabIndex = 0;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(151, 88);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(287, 22);
            this.txttensp.TabIndex = 1;
            // 
            // txtsoseri
            // 
            this.txtsoseri.Location = new System.Drawing.Point(151, 125);
            this.txtsoseri.Name = "txtsoseri";
            this.txtsoseri.Size = new System.Drawing.Size(287, 22);
            this.txtsoseri.TabIndex = 2;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(151, 169);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(287, 22);
            this.txtgia.TabIndex = 3;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(151, 207);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(287, 22);
            this.txtmota.TabIndex = 5;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(151, 246);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(287, 22);
            this.txttrangthai.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 234);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "SanPhamID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "TenSanPham";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SoSeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "MoTa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "TrangThai";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(488, 272);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(93, 39);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(611, 272);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(93, 39);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(731, 272);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(93, 39);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(852, 272);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(93, 39);
            this.btnload.TabIndex = 18;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(663, 77);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(105, 27);
            this.btn_timkiem.TabIndex = 19;
            this.btn_timkiem.Text = "TimKiem";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiemid
            // 
            this.txt_timkiemid.Location = new System.Drawing.Point(569, 44);
            this.txt_timkiemid.Name = "txt_timkiemid";
            this.txt_timkiemid.Size = new System.Drawing.Size(287, 22);
            this.txt_timkiemid.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(660, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "TimKiemTheoID";
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Location = new System.Drawing.Point(35, 292);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(132, 33);
            this.btn_sapxep.TabIndex = 22;
            this.btn_sapxep.Text = "SapXepTheoGia";
            this.btn_sapxep.UseVisualStyleBackColor = true;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(488, 110);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(499, 99);
            this.dataGridView2.TabIndex = 23;
            // 
            // btnlammmoi
            // 
            this.btnlammmoi.Location = new System.Drawing.Point(227, 286);
            this.btnlammmoi.Name = "btnlammmoi";
            this.btnlammmoi.Size = new System.Drawing.Size(93, 39);
            this.btnlammmoi.TabIndex = 24;
            this.btnlammmoi.Text = "Lam moi";
            this.btnlammmoi.UseVisualStyleBackColor = true;
            this.btnlammmoi.Click += new System.EventHandler(this.btnlammmoi_Click);
            // 
            // Form_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 577);
            this.Controls.Add(this.btnlammmoi);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_sapxep);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_timkiemid);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtsoseri);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtid);
            this.Name = "Form_sanpham";
            this.Text = "Form_sanpham";
            this.Load += new System.EventHandler(this.Form_sanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtsoseri;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.TextBox txt_timkiemid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnlammmoi;
    }
}