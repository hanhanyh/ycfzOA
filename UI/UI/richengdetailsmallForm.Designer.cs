namespace UI
{
    partial class richengdetailsmallForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(richengdetailsmallForm));
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.btnok = new CCWin.SkinControl.SkinButton();
            this.btnno = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Enabled = false;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "skinTextBox1"};
            this.skinTextBox1.Location = new System.Drawing.Point(36, 50);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = true;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(387, 258);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Multiline = true;
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(377, 248);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "skinTextBox1";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 0;
            this.skinTextBox1.Text = "skinTextBox1";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.Transparent;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnok.BaseColor = System.Drawing.Color.Transparent;
            this.btnok.BorderColor = System.Drawing.Color.Transparent;
            this.btnok.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnok.DownBack = null;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnok.IsDrawBorder = false;
            this.btnok.IsDrawGlass = false;
            this.btnok.Location = new System.Drawing.Point(327, 320);
            this.btnok.MouseBack = null;
            this.btnok.Name = "btnok";
            this.btnok.NormlBack = null;
            this.btnok.Size = new System.Drawing.Size(96, 29);
            this.btnok.TabIndex = 1;
            this.btnok.Text = "我已完成";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnno
            // 
            this.btnno.BackColor = System.Drawing.Color.Transparent;
            this.btnno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnno.BackgroundImage")));
            this.btnno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnno.BaseColor = System.Drawing.Color.Transparent;
            this.btnno.BorderColor = System.Drawing.Color.Transparent;
            this.btnno.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnno.DownBack = null;
            this.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnno.IsDrawBorder = false;
            this.btnno.IsDrawGlass = false;
            this.btnno.Location = new System.Drawing.Point(224, 320);
            this.btnno.MouseBack = null;
            this.btnno.Name = "btnno";
            this.btnno.NormlBack = null;
            this.btnno.Size = new System.Drawing.Size(86, 29);
            this.btnno.TabIndex = 2;
            this.btnno.Text = "关闭窗口";
            this.btnno.UseVisualStyleBackColor = false;
            this.btnno.Click += new System.EventHandler(this.btnno_Click);
            // 
            // richengdetailsmallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 368);
            this.Controls.Add(this.btnno);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.skinTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "richengdetailsmallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日程详情";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinButton btnok;
        private CCWin.SkinControl.SkinButton btnno;
    }
}