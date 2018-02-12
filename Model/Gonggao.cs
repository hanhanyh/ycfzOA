using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Gonggao
    {
        private int gid;

        public int Gid
        {
            get { return gid; }
            set { gid = value; }
        }
        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private String title;

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        private String detail;

        public String Detail
        {
            get { return detail; }
            set { detail = value; }
        }
        private String datetime;

        public String Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
    }
}
