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
    public partial class FRM_LISTNHAC : Form
    {
        public FRM_LISTNHAC()
        {
            InitializeComponent();
        }

        string tenlistnhac = "";
        List<int> MangViTriDaChon = new List<int>();

        bool ChonNgheList = false, CoChinhSua = false;
        int index = -1, oldindex = -1;
        public string TenListNhac
        {
            get { return tenlistnhac; }
        }
        public bool ChonNgheListNay
        {
            get { return ChonNgheList; }
        }
        int vt = -1;
        public int ViTriCuaList
        {
            get { return vt; }
        }
        private void FRM_Listnhac_Load(object sender, EventArgs e)
        {
            if (FRM_MAIN.data.NgonNguHienTai.CompareTo("VN") == 0)
                VN();
            else
                En();
            Reset_List();
            this.button_Save.Enabled = false;
        }
        private bool KiemTraDaCoTrongListBox(string tenlist)
        {
            for (int i = 0; i < this.listBox1.Items.Count; i++)
            {
                if (tenlist.CompareTo(this.listBox1.Items[i]) == 0)
                {
                    return true;
                }
            }
            return false;
        }
        private void ThemMotBaiHatVaoListView(File file)
        {

            ListViewItem item = new ListViewItem(file.name);
            item.SubItems.Add(file.size);
            item.SubItems.Add(file.path);
            listView1.Items.Add(item);
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedIndex >= 0)
            {
                MangViTriDaChon.Add(this.listBox1.SelectedIndex);
                if (MangViTriDaChon.Count - 1 == 0)
                    oldindex = MangViTriDaChon[MangViTriDaChon.Count - 1];
                else
                    oldindex = MangViTriDaChon[MangViTriDaChon.Count - 2];
                if (CoChinhSua == true && this.listBox1.SelectedIndex != oldindex)
                {
                    DialogResult ret = MessageBox.Show("Bạn chưa lưu những gì đã sửa,bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (ret == DialogResult.Yes)
                    {
                        LoadTuListViewVaoDS(oldindex);
                        MessageBox.Show("Đã lưu!!!", "Thông báo");
                    }

                    CoChinhSua = false;
                }
                //this.Text = this.Text.Substring(0,10); 
                int SoLuongBH = FRM_MAIN.QLListNhac.DSList[this.listBox1.SelectedIndex].SoLuongBaiHat();
                this.Text = "Danh sách đang chọn : ";
                this.Text = this.Text + "   " + FRM_MAIN.QLListNhac.DSList[this.listBox1.SelectedIndex].tenListNhac + " ( " + SoLuongBH + " bài )";
                this.index = this.listBox1.SelectedIndex;
                if (this.listView1.Items.Count != 0)
                    this.listView1.Items.Clear();
                for (int i = 0; i < FRM_MAIN.QLListNhac.DSList.DSList_Nhac[this.listBox1.SelectedIndex].SoLuongBaiHat(); i++)
                {

                    File tempfile = FRM_MAIN.QLListNhac.DSList.DSList_Nhac[this.listBox1.SelectedIndex].DanhSachBaiHat[i];
                    ThemMotBaiHatVaoListView(tempfile);
                }
            }


        }
        private void En()
        {
            this.Text = "List play";
            this.button_NgheListDuocChon.Text = "Play this list";
            this.columnHeader_Name.Text = "Name";
            this.columnHeader_Size.Text = "Size";
            this.columnHeader_Path.Text = "Patch";
            this.button_XoaListNhac.Text = "Delete this list";
            this.button_Them.Text = "Add";
            this.button_Xoa.Text = "Delete";
            this.button_XoaHet.Text = "Delete all";
            this.button_Save.Text = "Save";
            this.button_Thoat.Text = "Exit";
        }
        private void VN()
        {
            this.Text = "Danh sách nhạc";
            this.button_NgheListDuocChon.Text = "Chơi list này";
            this.columnHeader_Name.Text = "Tên bài hát";
            this.columnHeader_Size.Text = "Kích thước";
            this.columnHeader_Path.Text = "Đường dẫn";
            this.button_XoaListNhac.Text = "Xóa list này";
            this.button_Them.Text = "Thêm bài";
            this.button_Xoa.Text = "Xóa";
            this.button_XoaHet.Text = "Xóa hết";
            this.button_Save.Text = "Lưu lại";
            this.button_Thoat.Text = "Thoát";
        }

        private void button_NgheListDuocChon_Click(object sender, EventArgs e)
        {
            this.tenlistnhac = this.listBox1.Items[this.listBox1.SelectedIndex].ToString();
            this.ChonNgheList = true;
            this.vt = FRM_MAIN.QLListNhac.DSList.TimViTriList(tenlistnhac);
            this.Close();
        }

        private void button_XoaListNhac_Click(object sender, EventArgs e)
        {
            this.tenlistnhac = this.listBox1.Items[this.listBox1.SelectedIndex].ToString();
            int vt = FRM_MAIN.QLListNhac.DSList.TimViTriList(tenlistnhac);
            FRM_MAIN.QLListNhac.DSList.XoaList(vt);
            Reset_List();

        }
        private void Reset_List()
        {
            this.listView1.Items.Clear();
            this.listBox1.Items.Clear();
            for (int i = 0; i < FRM_MAIN.QLListNhac.DSList.soLuongList(); i++)
            {
                if (!KiemTraDaCoTrongListBox(FRM_MAIN.QLListNhac.DSList[i].tenListNhac))
                    listBox1.Items.Add(FRM_MAIN.QLListNhac.DSList[i].tenListNhac);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            this.button_Save.Enabled = true;
            CoChinhSua = true;
            if (this.listView1.SelectedItems.Count > 0)
            {

                //Xoá trên listview
                int vt = this.listView1.Items.IndexOf(this.listView1.SelectedItems[0]);
                int t = FRM_MAIN.QLListNhac.DSList.DSList_Nhac[index].TimkiemBaiHat(this.listView1.SelectedItems[0].Text);
                this.listView1.Items.RemoveAt(vt);
                //Xóa trong mảng
                //Form1.QLListNhac.DSList.DSList_Nhac[this.listBox1.SelectedIndex].XoaBaiHat(vt);

            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            this.button_Save.Enabled = true;
            CoChinhSua = true;
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

                    File temp = new File(this.openFileDialog1.SafeFileNames[i], this.openFileDialog1.FileNames[i]);
                    ThemMotBaiHatVaoListView(temp);

                }

            }
        }

        private void button_XoaHet_Click(object sender, EventArgs e)
        {
            this.button_Save.Enabled = true;
            CoChinhSua = true;
            // Form1.QLListNhac.DSList[this.listBox1.SelectedIndex].XoaTatCaBaiHat();
            this.listView1.Items.Clear();
        }
        private void LoadTuListViewVaoDS()
        {
            FRM_MAIN.QLListNhac.DSList[this.listBox1.SelectedIndex].XoaTatCaBaiHat();
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                string name = "", path = "";
                name = this.listView1.Items[i].SubItems[0].Text;
                path = this.listView1.Items[i].SubItems[2].Text;
                File temp = new File(name, path);
                FRM_MAIN.QLListNhac.DSList[this.listBox1.SelectedIndex].ThemBaiHat(temp);
            }
        }

        private void FRM_Listnhac_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CoChinhSua)
            {
                DialogResult ret = MessageBox.Show("Bạn chưa lưu những gì đã sửa,bạn có muốn lưu lại không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (ret == DialogResult.Yes)
                {
                    LoadTuListViewVaoDS(oldindex);
                    MessageBox.Show("Đã lưu!!!", "Thông báo");
                }
            }


            CoChinhSua = false;
            FRM_MAIN.QLListNhac.DSList.GhiXuongFile_List();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                File temp = new File(name, s[i]);
                ThemMotBaiHatVaoListView(temp);

            }

        }
        private void LoadTuListViewVaoDS(int vt)
        {
            FRM_MAIN.QLListNhac.DSList[vt].XoaTatCaBaiHat();
            for (int i = 0; i < this.listView1.Items.Count; i++)
            {
                string name = "", path = "";
                name = this.listView1.Items[i].SubItems[0].Text;
                path = this.listView1.Items[i].SubItems[2].Text;
                File temp = new File(name, path);
                FRM_MAIN.QLListNhac.DSList[vt].ThemBaiHat(temp);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            CoChinhSua = false;
            if (ret == DialogResult.Yes)
            {
                LoadTuListViewVaoDS();
                MessageBox.Show("Đã lưu!!!", "Thông báo");
            }

            this.button_Save.Enabled = false;
        }
    }
}
