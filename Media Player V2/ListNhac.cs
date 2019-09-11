using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_V2
{
    public class ListNhac
    {
        public string tenListNhac { get; set; }
        public List<File> DanhSachBaiHat { get; set; }
        public File this[int index]
        {
            get
            {
                return DanhSachBaiHat[index] as File;
            }
            set
            {
                DanhSachBaiHat[index] = value;
            }
        }
        // DanhSachBaiHat[0]
        public ListNhac()
        {
            this.tenListNhac = null;
            this.DanhSachBaiHat = new List<File>();
        }
        public ListNhac(string tenListNhac, List<File> DanhSachBaiHat)
        {
            this.tenListNhac = tenListNhac;
            this.DanhSachBaiHat = DanhSachBaiHat;
        }
      public int SoLuongBaiHat()
        {
            return DanhSachBaiHat.Count;
        }
        public void XoaBaiHat(int vt)
        {
            DanhSachBaiHat.RemoveAt(vt);
        }
        public void ThemBaiHat(File temp)
        {
            DanhSachBaiHat.Add(temp);
        }
        public int TimkiemBaiHat(string tenBH)
        {
            int kq = -1;
            for (int i = 0; i < DanhSachBaiHat.Count; i++)
            {
                if (tenBH.CompareTo(DanhSachBaiHat[i].name) == 0)
                    kq = i;
            }
            return kq;
        }
        public void XoaTatCaBaiHat()
        {
            DanhSachBaiHat.Clear();
        }
    }
}
