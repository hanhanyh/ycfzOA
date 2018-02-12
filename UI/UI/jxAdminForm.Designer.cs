namespace UI
{
    partial class jxAdminForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jxAdminForm));
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.txtjx = new CCWin.SkinControl.SkinTextBox();
            this.txtsm = new CCWin.SkinControl.SkinTextBox();
            this.btnsubmit = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // skinDataGridView1
            // 
            this.skinDataGridView1.AllowUserToAddRows = false;
            this.skinDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView1.ColumnFont = null;
            this.skinDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.skinDataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView1.EnableHeadersVisualStyles = false;
            this.skinDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.Location = new System.Drawing.Point(24, 169);
            this.skinDataGridView1.Name = "skinDataGridView1";
            this.skinDataGridView1.ReadOnly = true;
            this.skinDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView1.RowTemplate.Height = 23;
            this.skinDataGridView1.Size = new System.Drawing.Size(465, 188);
            this.skinDataGridView1.TabIndex = 0;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "jid";
            this.Column1.HeaderText = "JID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "uid";
            this.Column2.HeaderText = "uid";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "yj";
            this.Column3.HeaderText = "业绩";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "detail";
            this.Column4.HeaderText = "详情";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "time";
            this.Column5.HeaderText = "时间";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.Location = new System.Drawing.Point(114, 54);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(121, 21);
            this.skinComboBox1.TabIndex = 1;
            this.skinComboBox1.WaterText = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(46, 56);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "员工姓名：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(46, 91);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(68, 17);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "绩      效：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(46, 127);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "说      明：";
            // 
            // txtjx
            // 
            this.txtjx.BackColor = System.Drawing.Color.Transparent;
            this.txtjx.DownBack = null;
            this.txtjx.Icon = null;
            this.txtjx.IconIsButton = false;
            this.txtjx.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtjx.IsPasswordChat = '\0';
            this.txtjx.IsSystemPasswordChar = false;
            this.txtjx.Lines = new string[] {
        "skinTextBox1"};
            this.txtjx.Location = new System.Drawing.Point(114, 83);
            this.txtjx.Margin = new System.Windows.Forms.Padding(0);
            this.txtjx.MaxLength = 32767;
            this.txtjx.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtjx.MouseBack = null;
            this.txtjx.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtjx.Multiline = false;
            this.txtjx.Name = "txtjx";
            this.txtjx.NormlBack = null;
            this.txtjx.Padding = new System.Windows.Forms.Padding(5);
            this.txtjx.ReadOnly = false;
            this.txtjx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtjx.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtjx.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjx.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtjx.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtjx.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtjx.SkinTxt.Name = "BaseText";
            this.txtjx.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtjx.SkinTxt.TabIndex = 0;
            this.txtjx.SkinTxt.Text = "skinTextBox1";
            this.txtjx.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtjx.SkinTxt.WaterText = "";
            this.txtjx.TabIndex = 5;
            this.txtjx.Text = "skinTextBox1";
            this.txtjx.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtjx.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtjx.WaterText = "";
            this.txtjx.WordWrap = true;
            // 
            // txtsm
            // 
            this.txtsm.BackColor = System.Drawing.Color.Transparent;
            this.txtsm.DownBack = null;
            this.txtsm.Icon = null;
            this.txtsm.IconIsButton = false;
            this.txtsm.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtsm.IsPasswordChat = '\0';
            this.txtsm.IsSystemPasswordChar = false;
            this.txtsm.Lines = new string[] {
        "skinTextBox2"};
            this.txtsm.Location = new System.Drawing.Point(114, 119);
            this.txtsm.Margin = new System.Windows.Forms.Padding(0);
            this.txtsm.MaxLength = 32767;
            this.txtsm.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtsm.MouseBack = null;
            this.txtsm.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtsm.Multiline = false;
            this.txtsm.Name = "txtsm";
            this.txtsm.NormlBack = null;
            this.txtsm.Padding = new System.Windows.Forms.Padding(5);
            this.txtsm.ReadOnly = false;
            this.txtsm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsm.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.txtsm.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsm.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsm.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtsm.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtsm.SkinTxt.Name = "BaseText";
            this.txtsm.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.txtsm.SkinTxt.TabIndex = 0;
            this.txtsm.SkinTxt.Text = "skinTextBox2";
            this.txtsm.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtsm.SkinTxt.WaterText = "";
            this.txtsm.TabIndex = 6;
            this.txtsm.Text = "skinTextBox2";
            this.txtsm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsm.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtsm.WaterText = "";
            this.txtsm.WordWrap = true;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsubmit.BackgroundImage")));
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsubmit.BaseColor = System.Drawing.Color.Transparent;
            this.btnsubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnsubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsubmit.DownBack = null;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsubmit.IsDrawBorder = false;
            this.btnsubmit.IsDrawGlass = false;
            this.btnsubmit.Location = new System.Drawing.Point(315, 122);
            this.btnsubmit.MouseBack = null;
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.NormlBack = null;
            this.btnsubmit.Size = new System.Drawing.Size(86, 27);
            this.btnsubmit.TabIndex = 7;
            this.btnsubmit.Text = "添加绩效";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // jxAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 383);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtsm);
            this.Controls.Add(this.txtjx);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinComboBox1);
            this.Controls.Add(this.skinDataGridView1);
            this.MaximizeBox = false;
            this.Name = "jxAdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "绩效管理";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox txtjx;
        private CCWin.SkinControl.SkinTextBox txtsm;
        private CCWin.SkinControl.SkinButton btnsubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}