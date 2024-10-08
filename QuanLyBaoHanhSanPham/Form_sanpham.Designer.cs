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
            this.txtid.Location = new System.Drawing.Point(170, 62);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(322, 26);
            this.txtid.TabIndex = 0;
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(170, 110);
            this.txttensp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(322, 26);
            this.txttensp.TabIndex = 1;
            // 
            // txtsoseri
            // 
            this.txtsoseri.Location = new System.Drawing.Point(170, 156);
            this.txtsoseri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsoseri.Name = "txtsoseri";
            this.txtsoseri.Size = new System.Drawing.Size(322, 26);
            this.txtsoseri.TabIndex = 2;
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(170, 211);
            this.txtgia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(322, 26);
            this.txtgia.TabIndex = 3;
            // 
            // txtmota
            // 
            this.txtmota.Location = new System.Drawing.Point(170, 259);
            this.txtmota.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmota.Name = "txtmota";
            this.txtmota.Size = new System.Drawing.Size(322, 26);
            this.txtmota.TabIndex = 5;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(170, 308);
            this.txttrangthai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(322, 26);
            this.txttrangthai.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 414);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 292);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "SanPhamID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "TenSanPham";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "SoSeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Gia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "MoTa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "TrangThai";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(549, 340);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(105, 49);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(687, 340);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(105, 49);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(822, 340);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(105, 49);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(958, 340);
            this.btnload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(105, 49);
            this.btnload.TabIndex = 18;
            this.btnload.Text = "Load";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(768, 96);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(118, 34);
            this.btn_timkiem.TabIndex = 19;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // txt_timkiemid
            // 
            this.txt_timkiemid.Location = new System.Drawing.Point(662, 55);
            this.txt_timkiemid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_timkiemid.Name = "txt_timkiemid";
            this.txt_timkiemid.Size = new System.Drawing.Size(322, 26);
            this.txt_timkiemid.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(764, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Tìm kiếm theo ID";
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.Location = new System.Drawing.Point(39, 365);
            this.btn_sapxep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(148, 41);
            this.btn_sapxep.TabIndex = 22;
            this.btn_sapxep.Text = "Sắp xếp theo giá";
            this.btn_sapxep.UseVisualStyleBackColor = true;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(549, 138);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(561, 124);
            this.dataGridView2.TabIndex = 23;
            // 
            // btnlammmoi
            // 
            this.btnlammmoi.Location = new System.Drawing.Point(255, 358);
            this.btnlammmoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlammmoi.Name = "btnlammmoi";
            this.btnlammmoi.Size = new System.Drawing.Size(105, 49);
            this.btnlammmoi.TabIndex = 24;
            this.btnlammmoi.Text = "Làm mới";
            this.btnlammmoi.UseVisualStyleBackColor = true;
            this.btnlammmoi.Click += new System.EventHandler(this.btnlammmoi_Click);
            // 
            // Form_sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 721);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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