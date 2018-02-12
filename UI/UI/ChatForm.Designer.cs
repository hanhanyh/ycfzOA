namespace UI
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.chatbox = new System.Windows.Forms.WebBrowser();
            this.skinButtonSubmit = new CCWin.SkinControl.SkinButton();
            this.skinTextBoxdetail = new CCWin.SkinControl.SkinTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chatbox
            // 
            this.chatbox.Location = new System.Drawing.Point(5, 29);
            this.chatbox.MinimumSize = new System.Drawing.Size(20, 20);
            this.chatbox.Name = "chatbox";
            this.chatbox.Size = new System.Drawing.Size(613, 240);
            this.chatbox.TabIndex = 0;
            // 
            // skinButtonSubmit
            // 
            this.skinButtonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skinButtonSubmit.BackgroundImage")));
            this.skinButtonSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinButtonSubmit.BaseColor = System.Drawing.Color.Transparent;
            this.skinButtonSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.skinButtonSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonSubmit.DownBack = null;
            this.skinButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.skinButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.skinButtonSubmit.IsDrawBorder = false;
            this.skinButtonSubmit.IsDrawGlass = false;
            this.skinButtonSubmit.Location = new System.Drawing.Point(543, 392);
            this.skinButtonSubmit.MouseBack = null;
            this.skinButtonSubmit.Name = "skinButtonSubmit";
            this.skinButtonSubmit.NormlBack = null;
            this.skinButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.skinButtonSubmit.TabIndex = 2;
            this.skinButtonSubmit.Text = "发送";
            this.skinButtonSubmit.UseVisualStyleBackColor = false;
            this.skinButtonSubmit.Click += new System.EventHandler(this.skinButtonSubmit_Click);
            // 
            // skinTextBoxdetail
            // 
            this.skinTextBoxdetail.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxdetail.DownBack = null;
            this.skinTextBoxdetail.Icon = null;
            this.skinTextBoxdetail.IconIsButton = false;
            this.skinTextBoxdetail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxdetail.IsPasswordChat = '\0';
            this.skinTextBoxdetail.IsSystemPasswordChar = false;
            this.skinTextBoxdetail.Lines = new string[0];
            this.skinTextBoxdetail.Location = new System.Drawing.Point(5, 293);
            this.skinTextBoxdetail.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxdetail.MaxLength = 32767;
            this.skinTextBoxdetail.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxdetail.MouseBack = null;
            this.skinTextBoxdetail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxdetail.Multiline = true;
            this.skinTextBoxdetail.Name = "skinTextBoxdetail";
            this.skinTextBoxdetail.NormlBack = null;
            this.skinTextBoxdetail.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxdetail.ReadOnly = false;
            this.skinTextBoxdetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxdetail.Size = new System.Drawing.Size(613, 82);
            // 
            // 
            // 
            this.skinTextBoxdetail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxdetail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxdetail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxdetail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxdetail.SkinTxt.Multiline = true;
            this.skinTextBoxdetail.SkinTxt.Name = "BaseText";
            this.skinTextBoxdetail.SkinTxt.Size = new System.Drawing.Size(603, 72);
            this.skinTextBoxdetail.SkinTxt.TabIndex = 0;
            this.skinTextBoxdetail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxdetail.SkinTxt.WaterText = "";
            this.skinTextBoxdetail.TabIndex = 3;
            this.skinTextBoxdetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxdetail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxdetail.WaterText = "";
            this.skinTextBoxdetail.WordWrap = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(631, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 413);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(182, 357);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(116, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(140)))), ((int)(((byte)(188)))));
            this.btnsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsearch.BackgroundImage")));
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(126, 6);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(62, 23);
            this.btnsearch.TabIndex = 2;
            this.btnsearch.Text = "搜索";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 398);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(631, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(199, 424);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(191, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.btnsearch);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.txtSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(191, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "员工通讯录";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(840, 445);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.skinTextBoxdetail);
            this.Controls.Add(this.skinButtonSubmit);
            this.Controls.Add(this.chatbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser chatbox;
        private CCWin.SkinControl.SkinButton skinButtonSubmit;
        private CCWin.SkinControl.SkinTextBox skinTextBoxdetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}