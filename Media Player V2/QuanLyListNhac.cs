using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Media_Player_V2
{
    public class QuanLyListNhac
    {
        public List<ListNhac> DSList_Nhac { get; set; }
        public ListNhac this[int index]
        {
            get
            {
                return DSList_Nhac[index] as ListNhac;
            }
            set
            {
                DSList_Nhac[index] = value;
            }
        }
        public QuanLyListNhac()
        {
            DSList_Nhac = new List<ListNhac>();
        }
        public void themList(ListNhac a)
        {
            DSList_Nhac.Add(a);
        }
        public void XoaList(int vt)
        {
            DSList_Nhac.RemoveAt(vt);
        }
        public void GhiXuongFile_List()
        {
            StreamWriter sw = new StreamWriter(@"../List.txt");
            for (int i = 0; i < DSList_Nhac.Count; i++)
            {
                sw.Write(DSList_Nhac[i].tenListNhac+"=");
                for (int j = 0; j < DSList_Nhac[i].DanhSachBaiHat.Count; j++)
                {
                    sw.Write(DSList_Nhac[i].DanhSachBaiHat[j].name + "?" + DSList_Nhac[i].DanhSachBaiHat[j].path+"|");
                }
                sw.Write("\n");
            }
            sw.Close();
        }
        
        public int soLuongList()
        {
            return DSList_Nhac.Count;
        }
        public int TimViTriList(string name)
        {
            int kq = -1;
            for (int i = 0; i < DSList_Nhac.Count; i++)
            {
                if (DSList_Nhac[i].tenListNhac.ToUpper().CompareTo(name.ToUpper()) == 0)
                    kq = i;
            }

            return kq;
        }


    }
}
