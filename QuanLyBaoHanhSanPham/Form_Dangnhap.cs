using Amazon.Runtime.Internal.Util;
using DnsClient.Protocol;
using QuanLyBaoHanhSanPham.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyBaoHanhSanPham
{
    public partial class Form_Dangnhap : Form
    {
        private readonly UserService _userService;

        public Form_Dangnhap()
        {
            InitializeComponent();
            var database = new Connection().GetDatabase();
            _userService = new UserService(database);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form_Dangnhap_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            string username = txtDangNhap.Text;
            string password = txtMK.Text;

            // Kiểm tra nếu username hoặc password trống
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu.");
                return;
            }

            // Kiểm tra nếu _userService chưa được khởi tạo
            if (_userService == null)
            {
                MessageBox.Show("Lỗi: User service chưa được khởi tạo.");
                return;
            }

            try
            {
                // Kiểm tra thông tin đăng nhập
                var user = await _userService.GetUserAsync(username, password);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Form_Main main = new Form_Main();
                    main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtMK.UseSystemPasswordChar = false;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
