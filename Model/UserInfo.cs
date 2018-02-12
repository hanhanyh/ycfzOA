using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public   class UserInfo
    {
        private int uid;

        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private int sex;

        public int Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private String qq;

        public String Qq
        {
            get { return qq; }
            set { qq = value; }
        }
        private String phone;

        public String Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private String address;

        public String Address
        {
            get { return address; }
            set { address = value; }
        }
        private int enable;

        public int Enable
        {
            get { return enable; }
            set { enable = value; }
        }
        private int jobid;

        public int Jobid
        {
            get { return jobid; }
            set { jobid = value; }
        }
        private String birthday;

        public String Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        private String detail;

        public String Detail
        {
            get { return detail; }
            set { detail = value; }
        }

        public string IdCard { get => _idCard; set => _idCard = value; }
        public string HeadImgUrl { get => _headImgUrl; set => _headImgUrl = value; }
        public int IsManager { get => _isManager; set => _isManager = value; }

        private int _isManager;
        private string _idCard;
        private string _headImgUrl;
       
    }
}
