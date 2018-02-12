using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class worklog
    {
        private int logid;

        public int Logid
        {
            get { return logid; }
            set { logid = value; }
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
        private String datetime;

        public String Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
    }
}
