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
    public partial class FRM_TAOLISTNHAC : Form
    {
        public FRM_TAOLISTNHAC()
        {
            InitializeComponent();
        }
        public string TenListNhac
        {
            get { return this.textBox_TenList.Text; }
        }
        private void button_Tao_Click(object sender, EventArgs e)
        {
            if (this.textBox_TenList.Text!="")
                this.Close();
            else
                this.errorProvider1.SetError(textBox_TenList, "Không được bỏ trống phần này");
          
        }
        private void En()
        {
            this.Text = "Create a list";
            this.label1.Text = "Enter list name";
            this.button_Tao.Text = "Create now";
            this.button_Thoat.Text = "Exit";
        }
        private void VN()
        {
            this.Text = "Tạo list nhạc";
            this.label1.Text = "Nhập tên list nhac";
            this.button_Tao.Text = "Tạo ngay";
            this.button_Thoat.Text = "Thoát";
        }
        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.textBox_TenList.Text = "";
            this.Close();

        }

        private void FRM_TaoListNhac_Load(object sender, EventArgs e)
        {
            if (FRM_MAIN.data.NgonNguHienTai.CompareTo("VN") == 0)
                VN();
            else
                En();
        }
    }
}
