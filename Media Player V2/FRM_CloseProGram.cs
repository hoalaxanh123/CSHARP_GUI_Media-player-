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
    public partial class FRM_CLOSEPROGRAM : Form
    {
        public FRM_CLOSEPROGRAM()
        {
            InitializeComponent();
        }
        DateTime ThoiGianDuocChon;

        private void En()
        {
            this.label_title.Text = "Timer off program";
            this.label_Ngay.Text = "Day time";
            this.label_gio.Text = "Hours";
            this.label_Phut.Text = "Minutes";
            this.label_Giay.Text = "seconds";

            this.label_tatmay.Text = "Shutdown";
            this.radioButton_CoTatMay.Text = "Yes";
            this.radioButton_KhongTatMay.Text = "No";
            this.button_Huy.Text = "Cancel";
            this.button_DatGio.Text = "Let do it";
            this.button_Thoat.Text = "Exit";
            this.Text = "Timer off program";
            this.toolStripLabel_TrangThai.Text = "Not actived";
            
        }
        private void VN()
        {
            this.label_title.Text = "Hẹn giờ tắt chương trình";
            this.label_Ngay.Text = "Ngày";
            this.label_gio.Text = "Giờ";
            this.label_Phut.Text = "Phút";
            this.label_Giay.Text = "Giây";

            this.label_tatmay.Text = "Tắt máy";
            this.radioButton_CoTatMay.Text = "Có";
            this.radioButton_KhongTatMay.Text = "Không";
            this.button_Huy.Text = "Hủy";
            this.button_DatGio.Text = "Đặt giờ";
            this.button_Thoat.Text = "Thoát";
            this.Text = "Hẹn giờ tắt máy";
            this.toolStripLabel_TrangThai.Text = "Chưa kích hoạt";
        }
        private void button_DatGio_Click(object sender, EventArgs e)
        {

            int nam, thang, ngay;
            nam = dateTimePicker1.Value.Year;
            thang = dateTimePicker1.Value.Month;
            ngay = dateTimePicker1.Value.Day;
            int gio, phut, giay;
            gio = (int)(this.numericUpDown_Gio.Value);
            phut = (int)(this.numericUpDown_Phut.Value);
            giay = (int)(this.numericUpDown_Giay.Value);
            ThoiGianDuocChon = new DateTime(nam, thang, ngay, gio, phut, giay);

            if (ThoiGianDuocChon < DateTime.Now)
            {
                if(FRM_MAIN.data.NgonNguHienTai=="VN")
                    MessageBox.Show("Thời gian được chọn không hợp lệ \n\r( nhỏ hơn thời gian hiện  tại)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Time selected is not valid \n\r (smaller than the current time)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                this.label_ThoiGianDaHen.Visible = true;
                if (FRM_MAIN.data.NgonNguHienTai == "VN")
                {
                    this.label_ThoiGianDaHen.Text = "Thời gian đã hẹn : " + ThoiGianDuocChon.ToString();
                    MessageBox.Show("Đã đặt thời gian tắt là " + ThoiGianDuocChon.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    timer1.Start();
                    this.toolStripLabel_TrangThai.Text = "Đã kích hoạt";
                }
                else
                {
                    this.label_ThoiGianDaHen.Text = "Selected time : " + ThoiGianDuocChon.ToString();
                    MessageBox.Show("Set time off is " + ThoiGianDuocChon.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   this.toolStripLabel_TrangThai.Text = " Activated";
                }
               
            }

        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (FRM_MAIN.data.NgonNguHienTai == "VN")
            {
                this.toolStripLabel_TrangThai.Text = "Không kích hoạt";
                this.toolStripLabel_ThoiGianConLai.Text = "Đang chờ....";
                if (this.radioButton_CoTatMay.Checked)
                    System.Diagnostics.Process.Start("shutdown", "-a");
                MessageBox.Show("Đã hủy lệnh");
            }
            else
            {
                this.toolStripLabel_TrangThai.Text = "Not activated";
                this.toolStripLabel_ThoiGianConLai.Text = "Waiting....";
                if (this.radioButton_CoTatMay.Checked)
                    System.Diagnostics.Process.Start("shutdown", "-a");
                MessageBox.Show("Order canceled");
            }
               
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer2.Start();
            if (FRM_MAIN.data.NgonNguHienTai.CompareTo("VN") == 0)
                VN();
            else
                En();
            this.label_ThoiGianDaHen.Visible = false;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (FRM_MAIN.data.NgonNguHienTai == "VN")
                this.label_ThoiGianHienTai.Text = "Thời gian hiện tại : " + DateTime.Now.ToShortDateString()+ " " +DateTime.Now.ToLongTimeString();
            else
                 this.label_ThoiGianHienTai.Text = "Current time : " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            System.TimeSpan diff1 = ThoiGianDuocChon.Subtract(DateTime.Now);
            if (FRM_MAIN.data.NgonNguHienTai == "VN")
                this.toolStripLabel_ThoiGianConLai.Text=diff1.Days.ToString() + " ngày " + diff1.Hours + " giờ " + diff1.Minutes + " phút " + diff1.Seconds + " giây";
            else
                this.toolStripLabel_ThoiGianConLai.Text = diff1.Days.ToString() + " days " + diff1.Hours + " hours " + diff1.Minutes + " minutes " + diff1.Seconds + " second";

            if (diff1.Days==0&& diff1.Hours==0&& diff1.Minutes ==0&& diff1.Seconds==0)
            {
                timer1.Stop();
                if(this.radioButton_CoTatMay.Checked)
                    System.Diagnostics.Process.Start("shutdown", "-s");
                else
                    Application.Exit();
            }
                
        }

        private void label_Phut_Click(object sender, EventArgs e)
        {

        }
    }
}
