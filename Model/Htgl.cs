using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Htgl
    {
        private int hid;

        public int Hid
        {
            get { return hid; }
            set { hid = value; }
        }
        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private String detail;

        public String Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private string time;//失效时间

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        private string _startTime;

        public string WriteTime { get => _writeTime; set => _writeTime = value; }
        public string Htbh { get => _htbh; set => _htbh = value; }
        public string StartTime { get => _startTime; set => _startTime = value; }

        private string _htbh;
        private string _Detail;
        private string _writeTime;

    }
}
