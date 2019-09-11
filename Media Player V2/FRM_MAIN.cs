using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using AxAXVLC;
using System.IO;

namespace Media_Player_V2
{

    public partial class FRM_MAIN : MetroForm
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        public class data
        {
            public static string NgonNguHienTai;
        }
        public class QLListNhac
        {
            public static QuanLyListNhac DSList = new QuanLyListNhac();
        }
        string TotalTime;
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            if (data.NgonNguHienTai == "VN")
                ret = (MessageBox.Show("Bạn chắc chứ ????", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error));
            else
                ret = MessageBox.Show("You sure ???", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)
                Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FRM_MAIN.data.NgonNguHienTai == "EN")
                this.openFileDialog1.Title = "Choose media file";
            else
                this.openFileDialog1.Title = "Chọn file đa phương tiện";

            //Sẽ bổ sung sau
            this.openFileDialog1.Filter = "Video Files|*.FLV; *.MP4; *.mkv;*.webm;*.vob;*.ogg;*.ogv;*.drc;*.mng;*.avi;*.mov;*.wmv;*.amv;*.mpg;*.mpeg;*.m4v;*.3gp;*.3g2;*.f4a | Music files |*.m4a;*.aac;*.flac;*.m4b;*.ogg;*.wav;*.wma;*.webm;*.8svx;*.mp3;*.MP3|All file|*.*";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < this.openFileDialog1.FileNames.Count(); i++)
                {
                    this.axVLCPlugin21.playlist.add("file:///" + this.openFileDialog1.FileNames[i], this.openFileDialog1.SafeFileNames[i], null);
                    File temp = new File(this.openFileDialog1.SafeFileNames[i], this.openFileDialog1.FileNames[i]);
                    ThemMotBaiHatVaoListView(temp);
                }
            }

        }

        private void ThemMotBaiHatVaoListView(File file)
        {

            ListViewItem item = new ListViewItem("");
            item.SubItems.Add(file.name);
            item.SubItems.Add(file.size);
            item.SubItems.Add(file.path);
            listView1.Items.Add(item);
        }


       

        private void metroTrackBar_Vol_Scroll_1(object sender, ScrollEventArgs e)
        {
            this.axVLCPlugin21.input.time = this.metroTrackBar_TimeBar.Value * (this.axVLCPlugin21.input.length / 100);
        }
        private int GetIndexOfPlayer(string name)
        {
            int kq = -1;
            for (int i = 0; i < this.axVLCPlugin21.playlist.itemCount; i++)
            {

            }
            return kq;
        }
        private int GetindexPlaylist(string name)//Lay vi tri chinh xac theo ten
        {
            int kq = -1;
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                if (this.listView1.Items[i].SubItems[1].Text.CompareTo(name) == 0)
                    kq = i;
            }
            return kq;
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count > 0)
            {
                this.axVLCPlugin21.playlist.playItem(this.listView1.SelectedIndices[0]);
            }

        }

        private void ReSetBackStateView()
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                this.listView1.Items[i].SubItems[0].Text = "";

            }
        }
        private void axVLCPlugin21_MediaPlayerPlaying(object sender, EventArgs e)
        {
            ReSetBackStateView();
            TotalTime = ChuyenDoiThoiGian((int)this.axVLCPlugin21.input.length);
            this.listView1.Items[this.axVLCPlugin21.playlist.currentItem].SubItems[0].Text = "Playing >>>";
            
        }
        private string ChuyenDoiThoiGian(int MiliSecond)
        {
            string time = "";
            int TempS = MiliSecond / 1000, phut, gio, giay;
            /*
            - giờ = s/3600
            - phút = s%3600/60
            - giây = s%3600%60
             */
            gio = TempS / 3600;
            phut = TempS % 3600 / 60;
            giay = TempS % 3600 % 60;
            string Sgio = Convert.ToString(gio), Sphut = Convert.ToString(phut), Sgiay = Convert.ToString(giay);
            if (gio < 10)
                Sgio = "0" + gio;
            if (phut < 10)
                Sphut = "0" + phut;
            if (giay < 10)
                Sgiay = "0" + giay;
            time = Sgio + ":" + Sphut + ":" + Sgiay;

            return time;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.metroTrackBar_TimeBar.Value = 0;
            this.tableLayoutPanel1.Visible = false;
            this.label1_TimeNow.Visible = false;
            this.trackBar_Vol.Value = this.axVLCPlugin21.volume / 10;
            this.vietnameseToolStripMenuItem.PerformClick();
            data.NgonNguHienTai = "VN";
            DocTuFile_List();
            Loadsetting();
        }
        public void DocTuFile_List()
        {
            string line = "";
            StreamReader sr = new StreamReader(@"../List.txt");
            while ((line = sr.ReadLine()) != null)
            {
                List<File> tempList = new List<File>();
                string[] temp = line.Split('=');
                string[] ListStructoffile = temp[1].Split('|');
                for (int i = 0; i < ListStructoffile.Count() - 1; i++)
                {
                    string[] StructOfFile = ListStructoffile[i].Split('?');
                    File tempfile = new File(StructOfFile[0], StructOfFile[1]);
                    tempList.Add(tempfile);
                }
                ListNhac a = new ListNhac(temp[0], tempList);
                QLListNhac.DSList.themList(a);

            }
            sr.Close();
        }
        public void SaveSetting()
        {
            StreamWriter sw = new StreamWriter(@"../setting.txt");
            sw.WriteLine(FRM_MAIN.data.NgonNguHienTai + ";" + this.listView1.Font + ";" + this.listView1.ForeColor + ";" + this.listView1.BackColor);
            sw.Close();

        }
        public void Loadsetting()
        {
            string line = "";
            StreamReader sr = new StreamReader(@"../setting.txt");
            while ((line = sr.ReadLine()) != null)
            {
                string[] temp = line.Split(';');

                if (temp[0] == "EN")
                    this.englishToolStripMenuItem1.PerformClick();
                else
                    this.vietnameseToolStripMenuItem.PerformClick();

                //this.listView1.Font = temp[1];
            }
            sr.Close();
        }
        private void trackBar_Vol_Scroll(object sender, EventArgs e)
        {
            this.axVLCPlugin21.audio.mute = false;
            this.axVLCPlugin21.volume = this.trackBar_Vol.Value * 10;
        }

        private void axVLCPlugin21_MediaPlayerTimeChanged(object sender, AxAXVLC.DVLCEvents_MediaPlayerTimeChangedEvent e)
        {
            this.label1_TimeNow.Visible = true;
            this.label1_TimeNow.Text = ChuyenDoiThoiGian(e.time) + "/" + TotalTime;
            this.metroTrackBar_TimeBar.Value = Convert.ToInt32(e.time / this.axVLCPlugin21.input.length * 100);


        }

        private void axVLCPlugin21_MediaPlayerEndReached(object sender, EventArgs e)
        {
            this.axVLCPlugin21.playlist.next();
        }

        //Error
        private void button_Xoa_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                if (this.listView1.Items[i].Checked)
                {
                    this.axVLCPlugin21.playlist.items.remove(GetindexPlaylist(this.listView1.SelectedItems[i].SubItems[1].Text));
                    this.listView1.Items.RemoveAt(i);
                    i--;
                }

            }
        }

        private void axVLCPlugin21_MediaPlayerPaused(object sender, EventArgs e)
        {
            ReSetBackStateView();
            this.listView1.Items[this.axVLCPlugin21.playlist.currentItem].SubItems[0].Text = "Pause >>>";
        }

        private void axVLCPlugin21_MediaPlayerOpening(object sender, EventArgs e)
        {
            ReSetBackStateView();
           this.listView1.Items[this.axVLCPlugin21.playlist.currentItem].SubItems[0].Text = "Opening >>>";
        }

        private void axVLCPlugin21_MediaPlayerBuffering(object sender, DVLCEvents_MediaPlayerBufferingEvent e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();//Tranh tinh trang khong thoat han trong task manager
            Application.Exit();
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            for (i = 0; i < s.Length; i++)
            {
                string name = s[i].Substring(s[i].LastIndexOf("\\") + 1);
                this.axVLCPlugin21.playlist.add("file:///" + s[i], name, null);
                File temp = new File(name, s[i]);
                ThemMotBaiHatVaoListView(temp);

            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.listView1.Font = this.fontDialog1.Font;
                this.listView1.ForeColor = this.fontDialog1.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.listView1.BackColor = this.colorDialog1.Color;
            }
        }

        private void vietnameseToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //this.toolTip1.SetToolTip(this.metroButton_Play, "Phát/Tạm dừng");
            //this.toolTip1.SetToolTip(this.metroButton_LuiBaiTruoc, "Chuyển tới bài trước");
            //this.toolTip1.SetToolTip(this.metroButton_Stop, "Dừng phát");
            //this.toolTip1.SetToolTip(this.metroButton_Next, "Chuyển tới bài kế tiếp");
            //this.toolTip1.SetToolTip(this.metroButton_FullScreen, "Phát trong chế độ toàn màn hình");
            //this.toolTip1.SetToolTip(this.metroButton_List, "Hiện/Ẩn danh sách phát");
            //if (this.axVLCPlugin21.AutoPlay == true)
            //    this.toolTip1.SetToolTip(this.metroButton_Loop, "Tự động phát: Có");
            //else
            //    this.toolTip1.SetToolTip(this.metroButton_Loop, "Tự động phát: không");
            //this.toolTip1.SetToolTip(this.metroButton_RamDom, "Phát ngẫu nhiên");
            //this.toolTip1.SetToolTip(this.metroButton_Mute, "Tắt tiếng");
            this.toolTip1.SetToolTip(this.trackBar_Vol, "Âm lượng");
            this.saveThisListToolStripMenuItem.Text = "Lưu list nhạc này";
            this.columnHeader_Name.Text = "Tên bài hát";
            this.columnHeader_Size.Text = "Dung lượng";
            this.columnHeader_State.Text = "Trạng thái";
            this.columnHeader_Path.Text = "Đường dẫn";
            this.button_ADD.Text = "Thêm";
            this.button_Report.Text = "Báo lỗi";
            this.hẹnGiờTắtToolStripMenuItem.Text = "Hẹn giờ tắt";
            // this.button_Remove.Text = "Xóa";

            this.button_XoaHet.Text = "Xóa hết";
            this.fileToolStripMenuItem.Text = "Mở";
            this.exitToolStripMenuItem.Text = "Thoát";
            this.infoToolStripMenuItem.Text = "Thông tin";
            this.findToolStripMenuItem.Text = "Tìm kiếm";
            this.findToolStripMenuItem1.Text = "Tìm kiếm";
            this.fileToolStripMenuItem.Text = "Tệp";
            this.openToolStripMenuItem.Text = "Mở";
            this.exitToolStripMenuItem.Text = "Thoát";
            this.editToolStripMenuItem.Text = "Tùy chọn";
            this.fontToolStripMenuItem.Text = "Font chữ";
            this.colorToolStripMenuItem.Text = "Màu nền";
            this.languageToolStripMenuItem.Text = "Ngôn Ngữ";
            this.vietnameseToolStripMenuItem.Text = "Tiếng Việt";
            this.englishToolStripMenuItem.Text = "Tiếng Anh";
            this.fontToolStripMenuItem1.Text = this.fontToolStripMenuItem.Text;
            this.backcolorToolStripMenuItem.Text = this.colorToolStripMenuItem.Text;
            this.languagesToolStripMenuItem1.Text = this.languageToolStripMenuItem.Text;
            this.toolStripMenuItem1.Text = this.vietnameseToolStripMenuItem.Text;
            this.englishToolStripMenuItem1.Text = this.englishToolStripMenuItem.Text;
            this.button_Info.Text = "Thông tin";
            this.button_ADD.Text = "Thêm";
            this.button_Exit.Text = "Thoát";
            data.NgonNguHienTai = "VN";
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this.toolTip1.SetToolTip(this.metroButton_Play, "Play/Pause");
            //this.toolTip1.SetToolTip(this.metroButton_LuiBaiTruoc, "previous");
            //this.toolTip1.SetToolTip(this.metroButton_Stop, "Stop");
            //this.toolTip1.SetToolTip(this.metroButton_Next, "Next");
            //this.toolTip1.SetToolTip(this.metroButton_FullScreen, "Full screen");
            //this.toolTip1.SetToolTip(this.metroButton_List, "SetToolTip/Hile playlist");
            //if (this.axVLCPlugin21.AutoPlay == true)
            //    this.toolTip1.SetToolTip(this.metroButton_Loop, "Auto Play : Yes");
            //else
            //    this.toolTip1.SetToolTip(this.metroButton_Loop, "Auto Play : No");

            //this.toolTip1.SetToolTip(this.metroButton_RamDom, "Ramdom");
            //this.toolTip1.SetToolTip(this.metroButton_Mute, "Mute");
            this.toolTip1.SetToolTip(this.trackBar_Vol, "Volume");
            this.saveThisListToolStripMenuItem.Text = "Save this list";
            this.button_ADD.Text = "Add";
            this.button_Report.Text = "Report";
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Size.Text = "Size";
            this.columnHeader_State.Text = "State";
            this.columnHeader_Path.Text = "Patch";
            this.hẹnGiờTắtToolStripMenuItem.Text = "Shutdown timer";
            // this.button_Remove.Text = "Xóa";
            this.button_Exit.Text = "Exit";
            this.button_XoaHet.Text = "Clear list";
            this.fileToolStripMenuItem.Text = "Open";
            this.exitToolStripMenuItem.Text = "Exit";
            this.infoToolStripMenuItem.Text = "Info";
            this.fileToolStripMenuItem.Text = "File";
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem1.Text = "Find";
            this.openToolStripMenuItem.Text = "Open";
            this.exitToolStripMenuItem.Text = "Exit";
            this.editToolStripMenuItem.Text = "Option";
            this.fontToolStripMenuItem.Text = "Font";
            this.colorToolStripMenuItem.Text = "Background color";
            this.languageToolStripMenuItem.Text = "Languages";
            this.vietnameseToolStripMenuItem.Text = "VietNamese";
            this.englishToolStripMenuItem.Text = "English";
            this.fontToolStripMenuItem1.Text = this.fontToolStripMenuItem.Text;
            this.backcolorToolStripMenuItem.Text = this.colorToolStripMenuItem.Text;
            this.languagesToolStripMenuItem1.Text = this.languageToolStripMenuItem.Text;
            this.toolStripMenuItem1.Text = this.vietnameseToolStripMenuItem.Text;
            this.englishToolStripMenuItem1.Text = this.englishToolStripMenuItem.Text;
            this.button_Info.Text = "Info";

            data.NgonNguHienTai = "EN";

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Link to HTML
            // MessageBox.Show("Media Player 1.0 ");
            FRM_INFO info = new FRM_INFO();
            info.Show();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.Items.Count == 0)
            {
                if (data.NgonNguHienTai == "VN")
                    MessageBox.Show("Danh sách đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("List empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FRM_FIND Find = new FRM_FIND();
            Find.ShowDialog();
            if (Find.GiaTriTimKiem != "")
                TimKiemListView(Find.GiaTriTimKiem);
        }
        private void ReSetBackColorView()
        {
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                this.listView1.Items[i].BackColor = Color.White;
            }
        }
        private void TimKiemListView(string name)
        {
            ReSetBackColorView();
            int count = 0;
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                if (this.listView1.Items[i].SubItems[1].Text.ToUpper().Contains(name.ToUpper()))
                {
                    this.listView1.Items[i].BackColor = Color.Red;
                    count++;

                }

            }
            if (count == 0)
            {
                if (data.NgonNguHienTai == "VN")
                    MessageBox.Show("Không tìm thấy bài hát này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Can not find this song", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void saveThisListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listView1.Items.Count == 0)
            {
                if (data.NgonNguHienTai == "VN")
                    MessageBox.Show("Danh sách đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("List empty!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FRM_TAOLISTNHAC taoList = new FRM_TAOLISTNHAC();
            taoList.ShowDialog();
            if (taoList.TenListNhac == "")
                return;
            if (data.NgonNguHienTai == "VN")
                MessageBox.Show("Tạo thành công list nhạc với tên : " + taoList.TenListNhac.ToString(), "Thông báo");
            else
                MessageBox.Show("Successfully create a playlist with the name : " + taoList.TenListNhac.ToString(), "Notification");


            List<File> tempList = new List<File>();
            for (int i = 0; i <= this.listView1.Items.Count - 1; i++)
            {
                File tempfile = new File(this.listView1.Items[i].SubItems[1].Text, this.listView1.Items[i].SubItems[3].Text);
                tempList.Add(tempfile);
            }

            ListNhac a = new ListNhac(taoList.TenListNhac, tempList);
            QLListNhac.DSList.themList(a);
            QLListNhac.DSList.GhiXuongFile_List();
        }

        private void metroButton_List_Click(object sender, EventArgs e)
        {
            FRM_LISTNHAC list = new FRM_LISTNHAC();
            list.ShowDialog();
            if (list.ChonNgheListNay == true)
            {
                if (listView1.Items.Count != 0)
                {
                    this.listView1.Items.Clear();
                    this.axVLCPlugin21.playlist.stop();
                    this.axVLCPlugin21.playlist.items.clear();

                }
                int vt = list.ViTriCuaList;
                for (int i = 0; i < FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].SoLuongBaiHat(); i++)
                {
                    this.axVLCPlugin21.playlist.add("file:///" + FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].DanhSachBaiHat[i].path, FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].DanhSachBaiHat[i].name, null);
                    File tempfile = FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].DanhSachBaiHat[i];
                    ThemMotBaiHatVaoListView(tempfile);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count != 0)
            {
                this.listView1.Items.Clear();
                this.axVLCPlugin21.playlist.stop();
                this.axVLCPlugin21.playlist.items.clear();

            }
        }

        private void axVLCPlugin21_MediaPlayerStopped(object sender, EventArgs e)
        {
            this.label1_TimeNow.Text = "00:00:00/00:00:00";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Building....");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.infoToolStripMenuItem.PerformClick();
        }


        private void button_Report_Click(object sender, EventArgs e)
        {
            if (data.NgonNguHienTai == "VN")

                MessageBox.Show("Vui lòng báo lỗi qua email:\n\r-Nguyenvanvuong972@gmail.com\n\r-thoaixuan97@gmail.com\n\r-leexuaanvyx@gmail.com\n\rXin chân thành cảm ơn!!!", "Thông Báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Please report the error via email:\n\r-Nguyenvanvuong972@gmail.com\n\r-thoaixuan97@gmail.com\n\r-leexuaanvyx@gmail.com\n\rSpecial thanks!!!", "Notification", MessageBoxButtons.OK);

        }

        private void hẹnGiờTắtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRM_CLOSEPROGRAM temp = new FRM_CLOSEPROGRAM();
            temp.Show();
        }



        private void userControl_TrinhDieuKhien1_Load_1(object sender, EventArgs e)
        {
            //do something
        }

        private void userControl_TrinhDieuKhien1_Click(object sender, EventArgs e)
        {

            switch (userControl_TrinhDieuKhien1.NutVuaAnXong)


            {
                case "metroButton_Play":
                    if (this.axVLCPlugin21.playlist.isPlaying)
                    {
                        this.userControl_TrinhDieuKhien1.metroButton_Play.BackgroundImage = Media_Player_V2.Properties.Resources.pause;
                        this.axVLCPlugin21.playlist.pause();
                    }

                    else
                    {
                        this.userControl_TrinhDieuKhien1.metroButton_Play.BackgroundImage = Media_Player_V2.Properties.Resources.Play__2_;
                        this.axVLCPlugin21.playlist.play();
                    }


                    break;
                case "metroButton_LuiBaiTruoc":
                    this.axVLCPlugin21.playlist.prev();
                    break;
                case "metroButton_Stop":
                    this.axVLCPlugin21.playlist.stop();
                    break;
                case "metroButton_Next":
                    this.axVLCPlugin21.playlist.next();
                    break;
                case "metroButton_FullScreen":
                    this.axVLCPlugin21.video.fullscreen = true;
                    break;
                case "metroButton_Loop":

                    break;
                case "metroButton_RamDom":
                    break;
                case "metroButton_Mute":
                    if (this.axVLCPlugin21.audio.mute)
                    {
   
                        this.userControl_TrinhDieuKhien1.metroButton_Mute.BackgroundImage = Media_Player_V2.Properties.Resources.unmute;
                        this.axVLCPlugin21.audio.mute = false;
                    }

                    else
                    {
                        this.userControl_TrinhDieuKhien1.metroButton_Mute.BackgroundImage = Media_Player_V2.Properties.Resources.mute;
                        this.axVLCPlugin21.audio.mute = true;
                    }
                    break;
                case "metroButton_List":

                    FRM_LISTNHAC list = new FRM_LISTNHAC();
                    list.ShowDialog();
                    if (list.ChonNgheListNay == true)
                    {
                        if (listView1.Items.Count != 0)
                        {
                            this.listView1.Items.Clear();
                            this.axVLCPlugin21.playlist.stop();
                            this.axVLCPlugin21.playlist.items.clear();

                        }
                        int vt = list.ViTriCuaList;
                        for (int i = 0; i < FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].SoLuongBaiHat(); i++)
                        {
                            this.axVLCPlugin21.playlist.add("file:///" + FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].DanhSachBaiHat[i].path, FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].DanhSachBaiHat[i].name, null);
                            File tempfile = FRM_MAIN.QLListNhac.DSList.DSList_Nhac[vt].DanhSachBaiHat[i];
                            ThemMotBaiHatVaoListView(tempfile);
                        }
                    }
                    break;


            }
        }
    }
}
