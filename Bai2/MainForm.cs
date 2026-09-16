using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        //Xử lý sự kiện khi người dùng đã chọn giới tính Nam
        //Click đôi vào control checkbox
        //Đây là sự kiện mà nếu thay đổi việc check (check hoặc bỏ check đều xảy ra sự kiện)
        //Nếu muốn kiểm tra nếu nút được check mới thông báo thì sửa như sau
        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNam.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nam", "Thông báo");
        }

        private void rdNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNu.Checked)
                MessageBox.Show("Bạn đã chọn giới tính Nữ", "Thông báo");
        }

        private void btnToMau_Click(object sender, EventArgs e)
        {
            if (rdDo.Checked)
                txtHopMau.BackColor = Color.Red;
            else
                txtHopMau.BackColor = Color.Green;
        }
    }
}
