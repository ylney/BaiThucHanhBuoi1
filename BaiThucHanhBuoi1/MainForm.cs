using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        //Click đôi vào nút chương trình sẽ tự động tạo hàm sự kiện này
        //Khi ta click chuột vào nút chương trình sẽ làm gì?
        private void button1_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTen.Text;

            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn.", "Thông điệp chào mừng");
        }

        //Ví dụ bên trên nhập tên gì bên dưới sao chép lại
        //Hộp thoại sao chép không cho phép gõ, chỉ cho sao chép bên trên, cần xử lý như sau
        private void btnSaoChep_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTen.Text;
        }


        //Nếu xóa hàm này sẽ xảy ra lỗi, để xóa hàm sự kiện cần vào giao diện hoặc xóa ngay dòng lỗi
        //Bây giờ muốn xử lý sự kiện, trong ô tên gõ gì thì ô sao chép có nội dung như vậy, không cần nhấn nút sao chép
        //Xử lý như sau:
        //Click đôi vào textbox, sự kiện TextChanged được tạo, nhưng mà bây giờ cần bắt sự kiện thay đổi wor ô nhập tên, không phải ô sao chép
    }
}
