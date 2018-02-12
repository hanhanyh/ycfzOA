using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class UserServer
    {
        public static string sqltext;
        //登陆操作
        public static int Login(UserInfo user)
        {
            sqltext = "SELECT COUNT(*) FROM UserInfo Where uid='" + user.Uid + "' AND  password='" + user.Password + "'AND enable='1'";
            int i = (int)SQLHELPER.ExecuteScalar(sqltext);
            return i;
        }
        //注册(添加用户)
        public static object Register(UserInfo userinfo)
        {
            sqltext = "insert into dbo.UserInfo(name,password,sex,birthday,qq,phone,address,enable,jobid)values('" + userinfo.Name + "','" + userinfo.Password + "'," + userinfo.Sex + ",'" + userinfo.Birthday + "','" + userinfo.Qq + "','" + userinfo.Phone + "','" + userinfo.Address + "','1'," + userinfo.Jobid + ")";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;

        }
        //查询所有用户的通讯录
        public static DataTable selectallComm()
        {
            sqltext = "select  [name] as 员工名称,[phone] as 手机号码 from [dbo].[UserInfo] order by uid asc";
            return SQLHELPER.ExecuteDataSet(sqltext).Tables[0];
        }
        //模糊查询通讯录
        public static DataTable selectCommLike(string key)
        {
            sqltext = "select  [name] as 员工名称,[phone] as 手机号码 from [dbo].[UserInfo] where name like '%" + key + "%' order by uid asc";
            return SQLHELPER.ExecuteDataSet(sqltext).Tables[0];
        }
        /// <summary>
        /// 查询自己资料
        public static DataSet selectMYInfo(int uid)
        {
            sqltext = " select [uid],[name],[sex],[birthday],[qq],[phone],[address],[idCard],[headImgUrl] from [dbo].[UserInfo] where uid='"+uid+"'";
            return SQLHELPER.ExecuteDataSet(sqltext);
        }
        //更新
        public static object updateMYInfo(UserInfo uinfo)
        {
            sqltext = "  update [dbo].[UserInfo] set [name]='"+uinfo.Name+"',[sex]='"+uinfo.Sex+"',[birthday]='"+uinfo.Birthday+"',[qq]='"+uinfo.Qq+"',[phone]='"+uinfo.Phone+"',[address]='"+uinfo.Address+"' where uid='"+uinfo.Uid+"'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //查询某一用户的头像url
        public static object selectMyHeader(int uid)
        {
            sqltext = "  select [headImgUrl] from [dbo].[UserInfo] where uid='" + uid + "'";
            return SQLHELPER.ExecuteScalar(sqltext);
        }
        //更新头像
        public static object updateMyHeader(UserInfo info)
        {
            sqltext = "  update [dbo].[UserInfo] set  [headImgUrl]='"+info.HeadImgUrl+"' where [uid]='"+info.Uid+"'";
            return SQLHELPER.ExecuteNonQuery(sqltext);
        }
        //公告
        //public static object gonggao(Gonggao gonggao)
        //{
        //    sqltext = "insert into Gongggao(uid,title,detail,time)values('" + gonggao.Uid + "','" + gonggao.Title + "','" + gonggao.Detail + "','" + gonggao.Datetime + "')";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        //公文
        //public static object gongwen(gongwen gongwen)
        //{
        //    sqltext = "insert into gongwen (uid,season,time,isaccept)values ('" + gongwen.Uid + "','" + gongwen.Season + "','" + gongwen.Datetime + "','" + gongwen.Isaccept + "')";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;

        //}
        ////职位表添加
        //public static object departjob_1(departjob de)
        //{
        //    sqltext = "insert into departjob(did,jobname,dx)values ('" + de.Did + "','" + de.Jobname + "','" + de.Dx + "')";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        ////职位表假删除
        //public static int departjob_2(UserInfo uf)
        //{
        //    sqltext = "update   UserInfo  set  enable='0' where uid='" + uf.Uid + "'";
        //    int i = (int)SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;

        //}
        ////职位表的查询(通过部门ID)
        //public static DataSet departjob_3(departjob de)
        //{
        //    sqltext = "select  did as 职务编号,jobname as 职务,dx as 底薪 from departjob where did ='" + de.Did + "'";
        //    DataSet jb = DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //    return jb;
        //}
        ////职位表的所有信息
        //public static DataSet departjob_suoyou()
        //{
        //    sqltext = "select *from departjob";
        //    return SQLHELPER.ExecuteDataSet(sqltext);


        //}
        ////部门表添加
        //public static object department_ADD(department me)
        //{
        //    sqltext = "insert into department (name)values('" + me.Name + "')";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        ////部门表假删除
        ////部门表查询
        //public static DataSet selectByDID(department me)
        //{
        //    sqltext = "select did as 职务编号,name as 职务 from  department where did='" + me.Did + "'";
        //    DataSet met = DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //    return met;
        //}
        //签到
        //public static object Signln(SignIn si)
        //{
        //    sqltext = "insert into    SignIn(uid,time,type)    values('" + si.Uid + "','" + si.Datetime + "','" + si.Type + "')";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        //合同管理添加
     /*   public static object Htgl_1(Htgl htgl)
        {
            sqltext = "insert into    Htgl(htbh,uid,startTime,endTime)    values('" + htgl.Htbh + "','" + htgl.Uid + "','" + htgl.SrartTime + "','" + htgl.EndTime + "')";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }*/
        //合同管理删除
        //合同管理查询
        /*public static DataSet Htgl_3(Htgl htgl)
        {
            sqltext = "select htbh as 合同编号,uid as   用户编号  ,startTime  as 开始时间 , endTime  as  结束时间   from  Htgl where htbh='" + htgl.Htbh + "'";
            DataSet ht = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return ht;
        }*/
        ////绩效管理查询
        //public static DataSet Jxgl_1(Jxgl jxgl)
        //{
        //    sqltext = "select jid as 员工职务 ,uid as 员工编号, yj as 业绩,detail as 说明 ,time as 时间  from  Jxgl where uid ='" + jxgl.Uid + "'and time='" + jxgl.Datetime + "'";
        //    DataSet jx = DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //    return jx;
        //}
        ////绩效管理添加
        //public static object Jxgl_2(Jxgl jxgl)
        //{
        //    sqltext = "insert  into Jxgl( uid,yj,detail,time)values( '" + jxgl.Uid + "','" + jxgl.Yj + "','" + jxgl.Detail + "','" + jxgl.Datetime + "');";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        //查询绩效
        //工资添加
        //工资删除
        //工作查询
        //工作日志添加
        //public static object worklog_1(worklog log)
        //{
        //    sqltext = "insert  into worklog( uid , detail , time )  values('" + log.Uid + "','" + log.Detail + "','" + log.Datetime + "')";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        //工作日志删除
        //工作日志查询
        //public static DataSet selectWorkLogByWid(worklog log)
        //{
        //    sqltext = "select  logid as 日志编号,uid as 员工编号,detail as 详细信息 ,time as 时间 from  worklog where  uid='" + log.Uid + "';";
        //    DataSet work = DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //    return work;

        //}
        //员工表总表
        public static DataSet staffAll()
        {
            sqltext = "select  a.uid as 员工编号,a.name as 员工名字, b.did as 部门编号,b.jobname as 职务      from   UserInfo as a inner join departjob as b on a.jobid=b.jobid where enable='1'";
            DataSet st = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return st;
        }
        //员工分表
        public static DataSet staffListAPart()
        {
            sqltext = "select  a.uid as 员工编号,a.name as员工名字, b.did as部门编号,b.jobname as 职务,a.qq as QQ,a.sex as 性别,a.birthday as 生日,a.phone as 手机号码, a.address as 地址 ,  detail as 人事档案   from   UserInfo as a inner join departjob as b on a.jobid=b.jobid";
            DataSet st = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return st;
        }
        //根据ID查询员工信息(精确查找)
        public static DataSet selectOneByUID(UserInfo userinfo)
        {
            sqltext = "select  a.uid as 员工编号,a.jobid as 职位ID,a.name as 员工名字,a.sex as 性别,a.birthday as 生日,a.qq as QQ号码,a.phone as 手机号, b.did as 部门编号,b.jobname as 职务,a.address 地址,a.enable 是否禁用      from   UserInfo as a inner join departjob as b on a.jobid=b.jobid where a.uid='" + userinfo.Uid + "';";
            DataSet st = SQLHELPER.ExecuteDataSet(sqltext);
            return st;
        }
        //根据员工名字查询模糊查询
        public static DataSet SelectStaffByLikeName(String key)
        {
            sqltext = " select  a.uid as 员工编号,a.name as员工名字, b.did as部门编号,b.jobname as 职务      from   UserInfo as a inner join departjob as b on a.jobid=b.jobid where a.name like '%" + key + "%'";
            DataSet st = DAL.SQLHELPER.ExecuteDataSet(sqltext);
            return st;
        }
        //删除员工真删除
        public static int deleteStaffTrue(UserInfo userinfo)
        {
            sqltext = "delete     from   UserInfo  where  uid='" + userinfo.Uid + "';";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        ////修改员工部门+职务
        //public static int staff_5(UserInfo userinfo)
        //{
        //    sqltext = "update UserInfo set  jobid='" + userinfo.Jobid + "'  ";
        //    int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //    return i;
        //}
        ////通过用户ID查询职位
        //public static String SelectJobByUid(UserInfo uinfo)
        //{
        //    sqltext = "SELECT [jobname] FROM departjob,UserInfo WHERE UserInfo.jobid=departjob.jobid  AND UserInfo.uid='" + uinfo.Uid + "'";
        //    return Convert.ToString(DAL.SQLHELPER.ExecuteScalar(sqltext));
        //}
        //修改用户信息
        public static int updateJobByUid(UserInfo uinfo)
        {
            sqltext = "update  UserInfo  set name='" + uinfo.Name + "',sex='" + uinfo.Sex + "',birthday='" + uinfo.Birthday + "',qq='" + uinfo.Qq + "',phone='" + uinfo.Phone + "',address='" + uinfo.Address + "',enable='" + uinfo.Enable + "',jobid='"+uinfo.Jobid+"' WHERE uid='"+uinfo.Uid+"'";
            int i = (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
            return i;
        }
        ////查询员工 员工编号 职务 底薪 返回DataSet
        //public static DataSet SelectAllStaffJobDx()
        //{
        //    sqltext = "SELECT UserInfo.name as 员工,UserInfo.uid as 员工编号,departjob.jobname as 职务,departjob.dx as 底薪 FROM UserInfo ,departjob  where UserInfo.jobid=departjob.jobid";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////查询用户id 底薪 业绩 提成百分比
        //public static DataSet SelectOneStaffJobDx(UserInfo uin)
        //{
        //    sqltext = "SELECT UserInfo.uid as 用户ID, departjob.dx as 底薪,jxgl.yj as 业绩 ,jxgl.percentage as 提成百分比 FROM departjob,jxgl,UserInfo   WHERE jxgl.uid=UserInfo.uid AND UserInfo.jobid=departjob.jobid And UserInfo.uid='" + uin.Uid + "'";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////根据jobid 修改底薪
        //public static int UpdateDxById(Model.UserInfo uinfo,int dx)
        //{
        //    sqltext = "UPDATE departjob SET dx='"+dx+"' WHERE jobid='"+uinfo.Uid+"'";
        //    return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        //}
        ////查询员工 员工编号 职务 底薪 返回DataSet
        //public static DataSet SelectAStaffJobDxById(Model.UserInfo uinfo)
        //{
        //    sqltext = "SELECT UserInfo.name as 员工,UserInfo.uid as 员工编号,departjob.jobname as 职务,departjob.dx as 底薪 FROM UserInfo ,departjob  where UserInfo.jobid=departjob.jobid AND UserInfo.uid='"+uinfo.Uid+"'";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////查询所有职务表
        //public static DataSet SelectAllJob()
        //{
        //    sqltext = "select * from departjob";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////底薪修改 
        //public static int UpdateDx(int jobbid,int dx)
        //{
        //    sqltext="update departjob SET dx='"+dx+"' WHERE jobid='"+jobbid+"'";
        //    return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        //}
        ////查询员工，员工编号，业绩，提成百分比
        //public static DataSet Selectjxcx()
        //{
        //    sqltext = "select  a.name as 员工,a.uid as 员工编号,b.yj as 业绩,b.percentage as 提成百分比     from  UserInfo as a    inner    join Jxgl as b     on a.uid=b.uid";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////通过员工ID查询绩效表内容
        //public static DataSet Selectjxdc(UserInfo userinfo)
        //{
        //    sqltext = "select  a.name as 员工,a.uid as 员工编号,b.yj as 业绩,b.percentage as 提成百分比     from  UserInfo as a    inner    join Jxgl as b     on a.uid=b.uid AND a.uid='"+userinfo.Uid+"'";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
       // 增加公文
       //public static int Insertgw(gongwen gw)
       // {
       //     sqltext = "insert into gongwen (uid,season,time,isaccept,hk) values('" + gw.Uid + "','" + gw.Season + "','" + gw.Datetime + "','" + gw.Isaccept + "','" + gw.Hk + "')";
       //     return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
       // }
       // 已审批公文
       // public static DataSet Selectgwnotaccept()
       // {
       //     sqltext = "select UserInfo.name as 员工,gongwen.qid as 公文编号, UserInfo.uid as 员工编号,gongwen.season as 公文,gongwen .time as 申请时间 from UserInfo, gongwen WHERE UserInfo.uid=gongwen.uid AND gongwen.isaccept='0' AND DATALENGTH(gongwen.hk)=0";
       //     return DAL.SQLHELPER.ExecuteDataSet(sqltext);
       // }
       // 更新公文
       // public static int Updategongwen(int qid, int isaccept, String hk)
       // {
       //     sqltext = "UPDATE gongwen SET isaccept='" + isaccept + "',hk='" + hk + "' WHERE qid='" + qid + "'";
       //     return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);

       // }
       // 反馈
       // public static DataSet Selectfeedback()
       // {
       //     sqltext = "SELECT qid as 公文ID ,isaccept as 是否通过,hk as 反馈 FROM gongwen  where uid='1' AND DATALENGTH(hk)!=0 ";
       //     return DAL.SQLHELPER.ExecuteDataSet(sqltext);
       // }
       // 根据公文ID查询公文内容
       // public static string SelectgwContent(int id)
       // {
       //     sqltext = "select gongwen.[season] FROM gongwen WHERE qid='" + id + "'";
       //     return (string)DAL.SQLHELPER.ExecuteScalar(sqltext);
       // }
        /******************************
         * 签到签退功能
         * 2017年6月4日17:45:57
         * *************************************/
        ////签到功能
        //public static int signIn(UserInfo uin)
        //{
        //     String datetime=DateTime.Now.ToString();
        //    //1是签到 0是签退
        //    sqltext = "insert into SignIn ( uid,time,type) VALUES ('"+uin.Uid+"','"+datetime+"','"+1+"'); ";
        //    return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //}
        ////签退
        //public static int signOut(UserInfo uin)
        //{
        //    String datetime = DateTime.Now.ToString();
        //    //1是签到 0是签退
        //    sqltext = "insert into SignIn ( uid,time,type) VALUES ('" + uin.Uid + "','" + datetime + "','" + 0 + "'); ";
        //    return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //}
        ////判断用户ID为xx  用户今天是否签到 如果为0表示没有  1表示有
        //public static int isSignIned(int uid)
        //{
        //    //根据TOP 1查询上一次签到记录
        //    //根据datediff 与现在时间比较 判断当天是否签到
        //    sqltext = "SELECT TOP 1 COUNT(*) FROM SignIn WHERE datediff(day,time,GETDATE())<=0 AND type='1' AND uid='"+uid+"'";
        //    return (int)DAL.SQLHELPER.ExecuteScalar(sqltext);
        //}
        ////判断当天是否签退 是就返回1
        //public static int isSignOut(int uid)
        //{
        //    //根据TOP 1查询上一次签到记录
        //    //根据datediff 与现在时间比较 判断当天是否签到
        //    sqltext = "SELECT TOP 1 COUNT(*) FROM SignIn WHERE datediff(day,time,GETDATE())<=0 AND type='0' AND uid='" + uid + "'";
        //    return (int)DAL.SQLHELPER.ExecuteScalar(sqltext);
        //}
        ////-----------------------
        /////查询所有考勤
        //public static DataSet SelectAllkq()
        //{
        //    sqltext = "SELECT  u.name as 员工名,u.uid as 用户ID,s.type as 类型,s.time as 时间  FROM UserInfo as u,SignIn as s WHERE u.uid=s.uid ORDER BY s.time desc";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////增加合同
        //public static int addHt(Htgl h)
        //{
        //    sqltext="INSERT INTO htgl(uid,detail,time)VALUES('"+h.Uid+"','"+h.Detail+"','"+h.Time+"')";
        //    return (int)DAL.SQLHELPER.ExecuteNonQuery(sqltext);
        //}
        //public static DataSet SelectAllHt()
        //{
        //    sqltext = "SELECT   UserInfo.name as 员工名字,Htgl.detail as 合同编号,Htgl.time as 失效时间 FROM Htgl,UserInfo where Htgl.uid=UserInfo.uid";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////查询所有工作日志 （简约）
        //public static DataSet SelectAllWorklog()
        //{
        //    sqltext = "SELECT w.logid as 工作日志ID, u.name as 员工名字,w.time as 时间 from  UserInfo as u,worklog as w WHERE u.uid=w.uid";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}
        ////添加工作日志
        //public static int addWorklog(worklog log)
        //{
        //    sqltext="INSERT INTO worklog(uid,detail,time)VALUES('"+log.Uid+"','"+log.Detail+"','"+log.Datetime+"')";
        //    return Convert.ToInt32(DAL.SQLHELPER.ExecuteNonQuery(sqltext));
        //}
        ////查询工作日志详情
        //public static string selectworklogDetail(int id)
        //{
        //    sqltext = "SELECT detail FROM worklog where logid='" + id + "'";
        //    return Convert.ToString(DAL.SQLHELPER.ExecuteScalar(sqltext));
        //}
        ////根据用户ID查询用户 职位，id,相别，名称
        //public static DataSet selectJobNameSex(int uid)
        //{
        //    sqltext = "SELECT u.uid as 员工ID,u.name as 员工名字,u.sex 性别,d.jobname as 职位 FROM UserInfo as u,departjob  as d where u.jobid=d.jobid AND u.uid='" + uid + "'";
        //    return DAL.SQLHELPER.ExecuteDataSet(sqltext);
        //}


    }
}
