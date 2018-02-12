using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Wage
    {
        private int wid;

        public int Wid
        {
            get { return wid; }
            set { wid = value; }
        }
        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private int bs;

        public int Bs
        {
            get { return bs; }
            set { bs = value; }
        }
        private int com;

        public int Com
        {
            get { return com; }
            set { com = value; }
        }
        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }
        private String datetime;

        public String Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
    }
}
