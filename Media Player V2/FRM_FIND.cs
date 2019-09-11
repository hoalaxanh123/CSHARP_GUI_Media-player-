using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_V2
{
    public partial class FRM_FIND : Form
    {
        public FRM_FIND()
        {
            InitializeComponent();
        }
        public string GiaTriTimKiem
        {
            get { return this.textBox_GiaTriTim.Text; }
        }

        private void FRM_FIND_Load(object sender, EventArgs e)
        {

            if (FRM_MAIN.data.NgonNguHienTai.CompareTo("VN") == 0)
                VN();
            else
                En();
        }
        private void En()
        {
            this.Text = "Find";
            this.label1.Text = "Enter song title";
            this.button_TimKiem.Text = "Find now";
            this.button_Exit.Text = "Exit";
        }
        private void VN()
        {
            this.Text = "Tìm kiếm";
            this.label1.Text = "Nhập tên bài hát";
            this.button_TimKiem.Text = "Tìm ngay";
            this.button_Exit.Text = "Thoát";
        }
        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            if (this.textBox_GiaTriTim.Text != "")
                this.Close();
            else
                this.errorProvider1.SetError(textBox_GiaTriTim, "Không được bỏ trống phần này");
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.textBox_GiaTriTim.Text = null;
            this.Close();
        }
    }
}
