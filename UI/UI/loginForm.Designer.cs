namespace UI
{
    partial class loginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.control1 = new System.Windows.Forms.Control();
            this.control2 = new System.Windows.Forms.Control();
            this.btnsubmit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxpwd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnsubmit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // control1
            // 
            this.control1.Location = new System.Drawing.Point(0, 0);
            this.control1.Name = "control1";
            this.control1.Size = new System.Drawing.Size(0, 0);
            this.control1.TabIndex = 0;
            this.control1.Text = "control1";
            // 
            // control2
            // 
            this.control2.Location = new System.Drawing.Point(0, 0);
            this.control2.Name = "control2";
            this.control2.Size = new System.Drawing.Size(0, 0);
            this.control2.TabIndex = 0;
            this.control2.Text = "control2";
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnsubmit.Image")));
            this.btnsubmit.Location = new System.Drawing.Point(238, 272);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(195, 40);
            this.btnsubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.TabStop = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(240, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 33);
            this.panel1.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtID.Location = new System.Drawing.Point(12, 4);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(163, 26);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "请输入ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.textBoxpwd);
            this.panel2.Location = new System.Drawing.Point(240, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 33);
            this.panel2.TabIndex = 9;
            // 
            // textBoxpwd
            // 
            this.textBoxpwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(237)))));
            this.textBoxpwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxpwd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxpwd.Location = new System.Drawing.Point(12, 4);
            this.textBoxpwd.Multiline = true;
            this.textBoxpwd.Name = "textBoxpwd";
            this.textBoxpwd.Size = new System.Drawing.Size(163, 26);
            this.textBoxpwd.TabIndex = 0;
            this.textBoxpwd.Text = "请输入密码";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(287, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "记住密码";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 470);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工登录";
            ((System.ComponentModel.ISupportInitialize)(this.btnsubmit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Control control1;
        private System.Windows.Forms.Control control2;
        private System.Windows.Forms.PictureBox btnsubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxpwd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

