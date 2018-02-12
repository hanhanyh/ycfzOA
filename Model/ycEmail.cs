using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class ycEmail
    {
        private int _EID;
        private string _Title;
        private string _detail;
        private string _sendtime;
        private int _writer;//发送者id
        private int _receiver;//接受者id
        private int _isRead;//是否已读
        private int _isDelete;//是否删除
        private int _isOwner;//发送的邮件有两份 如果owner为1，表示是发件箱里，否则是收件箱里

        public int EID { get => _EID; set => _EID = value; }
        public string Title { get => _Title; set => _Title = value; }
        public string Detail { get => _detail; set => _detail = value; }
        public string Sendtime { get => _sendtime; set => _sendtime = value; }
        public int Writer { get => _writer; set => _writer = value; }
        public int Receiver { get => _receiver; set => _receiver = value; }
        public int IsRead { get => _isRead; set => _isRead = value; }
        public int IsDelete { get => _isDelete; set => _isDelete = value; }
        public int IsOwner { get => _isOwner; set => _isOwner = value; }
    }
}
