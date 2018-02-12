using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using BLL;
using Model;
using System.IO;
namespace UI
{
    public partial class MySelfInfoForm : Skin_DevExpress
    {
        private HomeSubForm _home;
        private string ofilename="";
        public MySelfInfoForm(HomeSubForm home)
        {
            InitializeComponent();
            //保存主界面对象
            _home = home;
            //查询我的资料
            int uid = Local.getCurrentUid();
            DataTable dt = BLL.UserBLL.selectMYInfo(uid);
             labuid.Text= dt.Rows[0]["uid"].ToString();
            txtName.Text = dt.Rows[0]["name"].ToString();
            comboxsex.SelectedIndex = Convert.ToInt32(dt.Rows[0]["sex"]);
            skinDateTimePicker1.text=dt.Rows[0]["birthday"].ToString();
            txtQQ.Text = dt.Rows[0]["qq"].ToString();
            txtPhone.Text = dt.Rows[0]["phone"].ToString();
            txtAddress.Text = dt.Rows[0]["address"].ToString();
            //init header初始化头像
            string headurl = BLL.UserBLL.selectMyHeader(Local.getCurrentUid());
            if (headurl == null || headurl == "")
            {
                this.pictureBox1.Load("img/touxiang.png");
            }
            else
            {
                this.pictureBox1.Load(headurl);
            }
        }

        private void btnopenFile_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // MessageBox.Show(this.openFileDialog1.FileName);
                
                this.pictureBox1.ImageLocation = this.openFileDialog1.FileName;
                ofilename = this.openFileDialog1.FileName;



            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
           
            UserInfo uinfo = new UserInfo();
            uinfo.Uid= Local.getCurrentUid();
            uinfo.Name = txtName.Text;
            uinfo.Sex = comboxsex.SelectedIndex;
            uinfo.Birthday = skinDateTimePicker1.text;
            uinfo.Qq = txtQQ.Text;
            uinfo.Phone = txtPhone.Text;
            uinfo.Address = txtAddress.Text;
            if (BLL.UserBLL.updateMYInfo(uinfo) == 1)
            {
                if (ofilename == "" || ofilename == null)
                {
                    MessageBox.Show("更新成功");
                }
                else {
                    //string headurl = BLL.UserBLL.selectMyHeader(Local.getCurrentUid());
                    //if (headurl == "" || headurl == null)
                    //{
                    //    if (File.Exists(headurl) == true)
                    //    {
                    //        try
                    //        {
                    //            File.Delete(headurl);
                    //        }
                    //        catch (Exception ex)
                    //        {
                    //            MessageBox.Show(ex.Message);
                    //        }

                    //    }
                    //}
                    string afile = this.openFileDialog1.FileName;
                    string filename = afile.Substring(afile.LastIndexOf("\\") + 1);
                    string savepath = "./img/head/" + filename;
                    //复制文件
                    try
                    {
                        File.Copy(afile, savepath);
                        UserInfo u1 = new UserInfo();
                        u1.Uid = Local.getCurrentUid();
                        u1.HeadImgUrl = savepath;
                        if (BLL.UserBLL.updateMyHeader(u1) == 1)
                        {
                            MessageBox.Show("更新成功");
                            _home. bindHead();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
              


            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
