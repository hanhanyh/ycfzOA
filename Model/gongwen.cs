using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class gongwen
    {
        private static int qid;

        public static int Qid
        {
            get { return gongwen.qid; }
            set { gongwen.qid = value; }
        }
        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private String season;

        public String Season
        {
            get { return season; }
            set { season = value; }
        }
        private String datetime;

        public String Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
        private  int isaccept;

        public  int Isaccept
        {
            get { return isaccept; }
            set { isaccept = value; }
        }
        private String hk;

        public String Hk
        {
            get { return hk; }
            set { hk = value; }
        }
        public int Acceptuid { get => _Acceptuid; set => _Acceptuid = value; }
        private int _Acceptuid;
    }
}
