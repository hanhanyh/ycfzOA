using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class richeng
    {
        private int _rid;
        private int _uid;
        private string _detail;
        private int _zyLevel;
        private string _time;
        private int isFinished;
        //日程ID
        public int Rid { get => _rid; set => _rid = value; }
        //用户ID
        public int Uid { get => _uid; set => _uid = value; }
        //详情安排
        public string Detail { get => _detail; set => _detail = value; }
        //重要等级（重要3，中等2，一般1）
        public int ZyLevel { get => _zyLevel; set => _zyLevel = value; }
        //时间
        public string Time { get => _time; set => _time = value; }
        //是否完成
        public int IsFinished { get => isFinished; set => isFinished = value; }
    }
}
