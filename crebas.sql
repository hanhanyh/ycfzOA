/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     2018/1/3 10:15:56                            */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Gongggao') and o.name = 'FK_GONGGGAO_REFERENCE_USERINFO')
alter table Gongggao
   drop constraint FK_GONGGGAO_REFERENCE_USERINFO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Htgl') and o.name = 'FK_HTGL_REFERENCE_USERINFO')
alter table Htgl
   drop constraint FK_HTGL_REFERENCE_USERINFO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Jxgl') and o.name = 'FK_JXGL_REFERENCE_USERINFO')
alter table Jxgl
   drop constraint FK_JXGL_REFERENCE_USERINFO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SignIn') and o.name = 'FK_SIGNIN_REFERENCE_USERINFO')
alter table SignIn
   drop constraint FK_SIGNIN_REFERENCE_USERINFO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('UserInfo') and o.name = 'FK_USERINFO_REFERENCE_DEPARTJO')
alter table UserInfo
   drop constraint FK_USERINFO_REFERENCE_DEPARTJO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Wage') and o.name = 'FK_WAGE_REFERENCE_USERINFO')
alter table Wage
   drop constraint FK_WAGE_REFERENCE_USERINFO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('departjob') and o.name = 'FK_DEPARTJO_REFERENCE_DEPARTME')
alter table departjob
   drop constraint FK_DEPARTJO_REFERENCE_DEPARTME
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('gongwen') and o.name = 'FK_GONGWEN_REFERENCE_USERINFO')
alter table gongwen
   drop constraint FK_GONGWEN_REFERENCE_USERINFO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('worklog') and o.name = 'FK_WORKLOG_REFERENCE_USERINFO')
alter table worklog
   drop constraint FK_WORKLOG_REFERENCE_USERINFO
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Gongggao')
            and   type = 'U')
   drop table Gongggao
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Htgl')
            and   type = 'U')
   drop table Htgl
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Jxgl')
            and   type = 'U')
   drop table Jxgl
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SignIn')
            and   type = 'U')
   drop table SignIn
go

if exists (select 1
            from  sysobjects
           where  id = object_id('UserInfo')
            and   type = 'U')
   drop table UserInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Wage')
            and   type = 'U')
   drop table Wage
go

if exists (select 1
            from  sysobjects
           where  id = object_id('departjob')
            and   type = 'U')
   drop table departjob
go

if exists (select 1
            from  sysobjects
           where  id = object_id('department')
            and   type = 'U')
   drop table department
go

if exists (select 1
            from  sysobjects
           where  id = object_id('gongwen')
            and   type = 'U')
   drop table gongwen
go

if exists (select 1
            from  sysobjects
           where  id = object_id('worklog')
            and   type = 'U')
   drop table worklog
go

/*==============================================================*/
/* Table: Gongggao                                              */
/*==============================================================*/
create table Gongggao (
   gid                  int                  identity,
   uid                  int                  null,
   title                nvarchar(16)         not null,
   detail               ntext                not null,
   time                 datetime             not null,
   constraint PK_GONGGGAO primary key (gid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '公告管理',
   'user', @CurrentUser, 'table', 'Gongggao'
go

/*==============================================================*/
/* Table: Htgl                                                  */
/*==============================================================*/
create table Htgl (
   hid                  int                  identity,
   htbh                 nvarchar(6)          null,
   uid                  int                  not null,
   startTime            datetime             not null,
   endTime              datetime             not null,
   Detail               nvarchar(max)        null,
   writeTime            datetime             null,
   constraint PK_HTGL primary key (hid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '合同管理',
   'user', @CurrentUser, 'table', 'Htgl'
go

/*==============================================================*/
/* Table: Jxgl                                                  */
/*==============================================================*/
create table Jxgl (
   jid                  numeric              identity,
   uid                  int                  not null,
   yj                   int                  not null,
   detail               ntext                null,
   time                 datetime             not null,
   constraint PK_JXGL primary key (jid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '绩效管理',
   'user', @CurrentUser, 'table', 'Jxgl'
go

/*==============================================================*/
/* Table: SignIn                                                */
/*==============================================================*/
create table SignIn (
   sid                  int                  identity,
   uid                  int                  not null,
   time                 datetime             not null,
   type                 bit                  not null,
   constraint PK_SIGNIN primary key (sid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '签到表',
   'user', @CurrentUser, 'table', 'SignIn'
go

/*==============================================================*/
/* Table: UserInfo                                              */
/*==============================================================*/
create table UserInfo (
   uid                  int                  identity,
   name                 nvarchar(16)         not null,
   password             nvarchar(16)         not null,
   sex                  bit                  not null default 1,
   birthday             datetime             null,
   qq                   bigint               null,
   phone                nvarchar(20)         null,
   address              nvarchar(50)         null,
   enable               bit                  null default 1,
   jobid                int                  not null,
   detail               text                 null,
   idCard               nvarchar(18)         null,
   headImgUrl           nvarchar(50)         null,
   isManager            bit                  null,
   constraint PK_USERINFO primary key (uid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '用户信息表',
   'user', @CurrentUser, 'table', 'UserInfo'
go

/*==============================================================*/
/* Table: Wage                                                  */
/*==============================================================*/
create table Wage (
   wid                  int                  identity,
   uid                  int                  not null,
   bs                   int                  not null,
   com                  int                  not null,
   total                int                  not null,
   time                 datetime             not null,
   constraint PK_WAGE primary key (wid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '薪酬管理',
   'user', @CurrentUser, 'table', 'Wage'
go

/*==============================================================*/
/* Table: departjob                                             */
/*==============================================================*/
create table departjob (
   jobid                int                  identity,
   did                  int                  not null,
   jobname              nvarchar(16)         not null,
   dx                   int                  not null,
   constraint PK_DEPARTJOB primary key (jobid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   ' 部门内，职位表',
   'user', @CurrentUser, 'table', 'departjob'
go

/*==============================================================*/
/* Table: department                                            */
/*==============================================================*/
create table department (
   did                  int                  identity,
   name                 nvarchar(16)         not null,
   constraint PK_DEPARTMENT primary key (did)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '部门表',
   'user', @CurrentUser, 'table', 'department'
go

/*==============================================================*/
/* Table: gongwen                                               */
/*==============================================================*/
create table gongwen (
   qid                  int                  identity,
   uid                  int                  not null,
   season               ntext                not null,
   time                 datetime             not null,
   isaccept             bit                  not null,
   acceptuid            int                  null,
   constraint PK_GONGWEN primary key (qid)
)
go

declare @CurrentUser sysname
select @CurrentUser = user_name()
execute sp_addextendedproperty 'MS_Description', 
   '请假',
   'user', @CurrentUser, 'table', 'gongwen'
go

/*==============================================================*/
/* Table: worklog                                               */
/*==============================================================*/
create table worklog (
   logid                int                  identity,
   uid                  int                  not null,
   detail               text                 not null,
   time                 datetime             not null,
   constraint PK_WORKLOG primary key (logid)
)
go

alter table Gongggao
   add constraint FK_GONGGGAO_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

alter table Htgl
   add constraint FK_HTGL_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

alter table Jxgl
   add constraint FK_JXGL_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

alter table SignIn
   add constraint FK_SIGNIN_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

alter table UserInfo
   add constraint FK_USERINFO_REFERENCE_DEPARTJO foreign key (jobid)
      references departjob (jobid)
go

alter table Wage
   add constraint FK_WAGE_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

alter table departjob
   add constraint FK_DEPARTJO_REFERENCE_DEPARTME foreign key (did)
      references department (did)
go

alter table gongwen
   add constraint FK_GONGWEN_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

alter table worklog
   add constraint FK_WORKLOG_REFERENCE_USERINFO foreign key (uid)
      references UserInfo (uid)
go

