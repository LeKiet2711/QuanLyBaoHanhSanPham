using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoHanhSanPham
{
    public partial class Form_Main : Form
    {
        public string Taikhoan { get; set; }
        public Form_Main()
        {
            InitializeComponent();
        }
        private Form currentChildForm;
        private void OpenChildForm(Form ChildForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(ChildForm);
            panel_body.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form_sanpham());
        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {

        }
    }
}
