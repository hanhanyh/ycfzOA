using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Jxgl
    {
        private int jid;

        public int Jid
        {
            get { return jid; }
            set { jid = value; }
        }
        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private int yj;

        public int Yj
        {
            get { return yj; }
            set { yj = value; }
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
