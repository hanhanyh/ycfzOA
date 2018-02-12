namespace UI
{
    partial class gongwenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gongwenForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.txtDetail = new CCWin.SkinControl.SkinTextBox();
            this.btn_submit = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnisaccept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.查看详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnsh = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.skinContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(55, 24);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "公文申请：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(47, 246);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(80, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "我提交的公文";
            // 
            // txtDetail
            // 
            this.txtDetail.BackColor = System.Drawing.Color.Transparent;
            this.txtDetail.DownBack = null;
            this.txtDetail.Icon = null;
            this.txtDetail.IconIsButton = false;
            this.txtDetail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDetail.IsPasswordChat = '\0';
            this.txtDetail.IsSystemPasswordChar = false;
            this.txtDetail.Lines = new string[] {
        "skinTextBox1"};
            this.txtDetail.Location = new System.Drawing.Point(50, 44);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(0);
            this.txtDetail.MaxLength = 32767;
            this.txtDetail.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtDetail.MouseBack = null;
            this.txtDetail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.NormlBack = null;
            this.txtDetail.Padding = new System.Windows.Forms.Padding(5);
            this.txtDetail.ReadOnly = false;
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetail.Size = new System.Drawing.Size(779, 152);
            // 
            // 
            // 
            this.txtDetail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDetail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDetail.SkinTxt.Multiline = true;
            this.txtDetail.SkinTxt.Name = "BaseText";
            this.txtDetail.SkinTxt.Size = new System.Drawing.Size(769, 142);
            this.txtDetail.SkinTxt.TabIndex = 0;
            this.txtDetail.SkinTxt.Text = "skinTextBox1";
            this.txtDetail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDetail.SkinTxt.WaterText = "";
            this.txtDetail.TabIndex = 2;
            this.txtDetail.Text = "skinTextBox1";
            this.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDetail.WaterText = "";
            this.txtDetail.WordWrap = true;
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Transparent;
            this.btn_submit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_submit.BackgroundImage")));
            this.btn_submit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_submit.DownBack = null;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_submit.IsDrawBorder = false;
            this.btn_submit.IsDrawGlass = false;
            this.btn_submit.Location = new System.Drawing.Point(754, 202);
            this.btn_submit.MouseBack = null;
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.NormlBack = null;
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
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
            this.Columnisaccept,
            this.Column4});
            this.skinDataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.ContextMenuStrip = this.skinContextMenuStrip1;
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
            this.skinDataGridView1.Location = new System.Drawing.Point(50, 266);
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
            this.skinDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView1.Size = new System.Drawing.Size(779, 166);
            this.skinDataGridView1.TabIndex = 4;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.skinDataGridView1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "qid";
            this.Column1.HeaderText = "公文ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "time";
            this.Column2.HeaderText = "时间";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Columnisaccept
            // 
            this.Columnisaccept.DataPropertyName = "isaccept";
            this.Columnisaccept.HeaderText = "批准";
            this.Columnisaccept.Name = "Columnisaccept";
            this.Columnisaccept.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "hk";
            this.Column4.HeaderText = "意见";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // skinContextMenuStrip1
            // 
            this.skinContextMenuStrip1.Arrow = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.Back = System.Drawing.Color.White;
            this.skinContextMenuStrip1.BackRadius = 4;
            this.skinContextMenuStrip1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.skinContextMenuStrip1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.skinContextMenuStrip1.Fore = System.Drawing.Color.Black;
            this.skinContextMenuStrip1.HoverFore = System.Drawing.Color.White;
            this.skinContextMenuStrip1.ItemAnamorphosis = true;
            this.skinContextMenuStrip1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemBorderShow = true;
            this.skinContextMenuStrip1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.ItemRadius = 4;
            this.skinContextMenuStrip1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看详情ToolStripMenuItem});
            this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
            this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            this.skinContextMenuStrip1.SkinAllColor = true;
            this.skinContextMenuStrip1.TitleAnamorphosis = true;
            this.skinContextMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinContextMenuStrip1.TitleRadius = 4;
            this.skinContextMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 查看详情ToolStripMenuItem
            // 
            this.查看详情ToolStripMenuItem.Name = "查看详情ToolStripMenuItem";
            this.查看详情ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查看详情ToolStripMenuItem.Text = "查看详情";
            this.查看详情ToolStripMenuItem.Click += new System.EventHandler(this.查看详情ToolStripMenuItem_Click);
            // 
            // btnsh
            // 
            this.btnsh.BackColor = System.Drawing.Color.Transparent;
            this.btnsh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsh.BackgroundImage")));
            this.btnsh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnsh.DownBack = null;
            this.btnsh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsh.IsDrawBorder = false;
            this.btnsh.IsDrawGlass = false;
            this.btnsh.Location = new System.Drawing.Point(754, 9);
            this.btnsh.MouseBack = null;
            this.btnsh.Name = "btnsh";
            this.btnsh.NormlBack = null;
            this.btnsh.Size = new System.Drawing.Size(75, 23);
            this.btnsh.TabIndex = 5;
            this.btnsh.Text = "公文审核";
            this.btnsh.UseVisualStyleBackColor = false;
            this.btnsh.Click += new System.EventHandler(this.btnsh_Click);
            // 
            // gongwenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 505);
            this.Controls.Add(this.btnsh);
            this.Controls.Add(this.skinDataGridView1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gongwenForm";
            this.Text = "公文申请";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.skinContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox txtDetail;
        private CCWin.SkinControl.SkinButton btn_submit;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnisaccept;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看详情ToolStripMenuItem;
        private CCWin.SkinControl.SkinButton btnsh;
    }
}