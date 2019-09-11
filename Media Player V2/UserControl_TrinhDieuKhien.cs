using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_V2
{
    public partial class UserControl_TrinhDieuKhien : UserControl
    {
        public UserControl_TrinhDieuKhien()
        {
            InitializeComponent();
        }
       
        private string NutVuaAn="";
        public string NutVuaAnXong
        {
            get { return NutVuaAn; }
        }
        private void UserControl_TrinhDieuKhien_Load(object sender, EventArgs e)
        {
           // MessageBox.Show(FRM_MAIN.data.NgonNguHienTai);
            //if (FRM_MAIN.data.NgonNguHienTai.CompareTo("VN") == 0)
            //    VN();
            //else
            //    En();
        }

        private void En()
        {
            this.toolTip1.SetToolTip(this.metroButton_Play, "Play/Pause");
            this.toolTip1.SetToolTip(this.metroButton_LuiBaiTruoc, "previous");
            this.toolTip1.SetToolTip(this.metroButton_Stop, "Stop");
            this.toolTip1.SetToolTip(this.metroButton_Next, "Next");
            this.toolTip1.SetToolTip(this.metroButton_FullScreen, "Full screen");
            this.toolTip1.SetToolTip(this.metroButton_List, "SetToolTip/Hile playlist");
            this.toolTip1.SetToolTip(this.metroButton_Loop, "Auto Play ");
            this.toolTip1.SetToolTip(this.metroButton_RamDom, "Ramdom");
            this.toolTip1.SetToolTip(this.metroButton_Mute, "Mute");
        }
        private void VN()
        {
            this.toolTip1.SetToolTip(this.metroButton_Play, "Phát/Tạm dừng");
            this.toolTip1.SetToolTip(this.metroButton_LuiBaiTruoc, "Chuyển tới bài trước");
            this.toolTip1.SetToolTip(this.metroButton_Stop, "Dừng phát");
            this.toolTip1.SetToolTip(this.metroButton_Next, "Chuyển tới bài kế tiếp");
            this.toolTip1.SetToolTip(this.metroButton_FullScreen, "Phát trong chế độ toàn màn hình");
            this.toolTip1.SetToolTip(this.metroButton_List, "Hiện/Ẩn danh sách phát");
            this.toolTip1.SetToolTip(this.metroButton_Loop, "Tự động phát");
            this.toolTip1.SetToolTip(this.metroButton_RamDom, "Phát ngẫu nhiên");
            this.toolTip1.SetToolTip(this.metroButton_Mute, "Tắt tiếng");
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            NutVuaAn = btn.Name;
            this.OnClick(e);
        }

    }
}
