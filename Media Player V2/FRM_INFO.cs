using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_V2
{
    public partial class FRM_INFO : Form
    {
        public FRM_INFO()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("-Ma Xuân Thoại    - Photoshop\n\r-Lê Xuân Vỹ    -Support\n\r-Nguyễn Văn Vương     -Code\n\r-VLC LAN    -Library and source", "About us", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Link to HTML 
            Process.Start(@"..\Web\index.html");

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
        }

        private void FRM_INFO_Load(object sender, EventArgs e)
        {
            if(FRM_MAIN.data.NgonNguHienTai=="VN")
            {
                this.label_Info1.Text = "VTV Media Player là phần mềm hoàn toàn miễn phí,được xây dựng dựa trên nền tảng VLC LIB và cùng nhiều open source khác";
                this.label_Info2.Text = "VTV Media Player kế thừa các đặc tính của VLC LAN,nó hỗ trợ gần như hầu hết mọi định dạng phổ biến hiện tại và đưa bạn tới trải nhiệm mới nhất của một player mang đậm phong cách....sinh viên tập code :p";
                this.linkLabel_TacGia.Text = "Tác giả";
                this.linkLabel_Contact.Text = "Liên hệ với chúng tôi";
                this.linkLabel_Exit.Text = "Thoát";
            }
            else
            {

                this.label_Info1.Text = "[Google Tran] VTV Media Player is completely free software, built on VLC LIB platform and many other open source.";
                this.label_Info2.Text = "[Google Tran] VTV Media Player inherits the features of VLC LAN, supports almost all popular formats today and takes you to the latest experience of a stylish player. :P";
                this.linkLabel_TacGia.Text = "Author";
                this.linkLabel_Contact.Text = "Contact us";
                this.linkLabel_Exit.Text = "Exit";
            }
        }
    }
}
