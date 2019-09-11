using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Media_Player_V2
{
  public  class File
    {
        public string name { get; set; }
        public string size { get; set; }
        public string path { get; set; }

        public string length { get; set; }
        public File()
        {

        }
        public File(string name,string path)
        {
            this.name = name;
            this.path = path;
            this.size = GetSize(path);
        }
        private string GetSize(string path)
        {
            string kq = null;
            FileInfo finfo = new FileInfo(this.path);
            double SizeInMB = finfo.Length / 1024;//lấy KB
            SizeInMB = Math.Round(SizeInMB / 1024, 2);// lấy MB làm tròn 2 số
            kq=((SizeInMB).ToString() + "MB");
            return kq;
        }
    }
}
