using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class Local
    {
        private static  int _uid=5;
       public  static string _uname = "邱于涵";
        private Local() { }
        public static int getCurrentUid()
        {
            return _uid;
        }
        public static void setCurrentUid(int uid)
        {
            _uid = uid;
        }
        public static int authLevel = 2;//1普通员工，2部门经理，3总经理
        //推送服务客户端
        private static  GGClient _client;
        public static  GGClient getClientInstance()//单例模式
        {
            if (_client == null)
            {
                _client = new GGClient();
            }
            return _client;
        }
    }
}
