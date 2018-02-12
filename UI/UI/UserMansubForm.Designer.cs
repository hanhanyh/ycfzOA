namespace UI
{
    partial class UserMansubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMansubForm));
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new CCWin.SkinControl.SkinTextBox();
            this.btnSearch = new CCWin.SkinControl.SkinButton();
            this.btnadd = new CCWin.SkinControl.SkinButton();
            this.btndepartman = new CCWin.SkinControl.SkinButton();
            this.btnManagejob = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.skinContextMenuStrip1.SuspendLayout();
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
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
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
            this.skinDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.skinDataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView1.HeadSelectBackColor = System.Drawing.SystemColors.HotTrack;
            this.skinDataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.Location = new System.Drawing.Point(12, 44);
            this.skinDataGridView1.MouseCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
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
            this.skinDataGridView1.Size = new System.Drawing.Size(808, 441);
            this.skinDataGridView1.SkinGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(233)))));
            this.skinDataGridView1.TabIndex = 0;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "员工编号";
            this.Column1.HeaderText = "员工编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "员工名字";
            this.Column2.HeaderText = "员工名字";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "部门编号";
            this.Column3.HeaderText = "部门编号";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "职务";
            this.Column4.HeaderText = "职务";
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
            this.详细信息ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
            this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            this.skinContextMenuStrip1.SkinAllColor = true;
            this.skinContextMenuStrip1.TitleAnamorphosis = true;
            this.skinContextMenuStrip1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.skinContextMenuStrip1.TitleRadius = 4;
            this.skinContextMenuStrip1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.详细信息ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.DownBack = null;
            this.txtSearch.Icon = null;
            this.txtSearch.IconIsButton = false;
            this.txtSearch.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSearch.IsPasswordChat = '\0';
            this.txtSearch.IsSystemPasswordChar = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(12, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtSearch.MouseBack = null;
            this.txtSearch.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.NormlBack = null;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(5);
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.Size = new System.Drawing.Size(275, 28);
            // 
            // 
            // 
            this.txtSearch.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtSearch.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtSearch.SkinTxt.Name = "BaseText";
            this.txtSearch.SkinTxt.Size = new System.Drawing.Size(265, 18);
            this.txtSearch.SkinTxt.TabIndex = 0;
            this.txtSearch.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSearch.SkinTxt.WaterText = "员工名称";
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtSearch.WaterText = "员工名称";
            this.txtSearch.WordWrap = true;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BaseColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderInflate = new System.Drawing.Size(0, 0);
            this.btnSearch.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSearch.DownBack = null;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.IsDrawGlass = false;
            this.btnSearch.Location = new System.Drawing.Point(322, 15);
            this.btnSearch.MouseBack = null;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.NormlBack = null;
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Transparent;
            this.btnadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadd.BackgroundImage")));
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.BaseColor = System.Drawing.Color.Transparent;
            this.btnadd.BorderColor = System.Drawing.Color.Transparent;
            this.btnadd.BorderInflate = new System.Drawing.Size(0, 0);
            this.btnadd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnadd.DownBack = null;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnadd.IsDrawGlass = false;
            this.btnadd.Location = new System.Drawing.Point(402, 15);
            this.btnadd.MouseBack = null;
            this.btnadd.Name = "btnadd";
            this.btnadd.NormlBack = null;
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 3;
            this.btnadd.Text = "添加员工";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btndepartman
            // 
            this.btndepartman.BackColor = System.Drawing.Color.Transparent;
            this.btndepartman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndepartman.BackgroundImage")));
            this.btndepartman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndepartman.BaseColor = System.Drawing.Color.Transparent;
            this.btndepartman.BorderColor = System.Drawing.Color.Transparent;
            this.btndepartman.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btndepartman.DownBack = null;
            this.btndepartman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndepartman.IsDrawBorder = false;
            this.btndepartman.IsDrawGlass = false;
            this.btndepartman.Location = new System.Drawing.Point(484, 15);
            this.btndepartman.MouseBack = null;
            this.btndepartman.Name = "btndepartman";
            this.btndepartman.NormlBack = null;
            this.btndepartman.Size = new System.Drawing.Size(75, 22);
            this.btndepartman.TabIndex = 4;
            this.btndepartman.Text = "管理部门";
            this.btndepartman.UseVisualStyleBackColor = false;
            this.btndepartman.Click += new System.EventHandler(this.btndepartman_Click);
            // 
            // btnManagejob
            // 
            this.btnManagejob.BackColor = System.Drawing.Color.Transparent;
            this.btnManagejob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManagejob.BackgroundImage")));
            this.btnManagejob.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManagejob.BaseColor = System.Drawing.Color.Transparent;
            this.btnManagejob.BorderColor = System.Drawing.Color.Transparent;
            this.btnManagejob.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnManagejob.DownBack = null;
            this.btnManagejob.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManagejob.IsDrawBorder = false;
            this.btnManagejob.IsDrawGlass = false;
            this.btnManagejob.Location = new System.Drawing.Point(566, 15);
            this.btnManagejob.MouseBack = null;
            this.btnManagejob.Name = "btnManagejob";
            this.btnManagejob.NormlBack = null;
            this.btnManagejob.Size = new System.Drawing.Size(75, 21);
            this.btnManagejob.TabIndex = 5;
            this.btnManagejob.Text = "管理职位";
            this.btnManagejob.UseVisualStyleBackColor = false;
            this.btnManagejob.Click += new System.EventHandler(this.btnManagejob_Click);
            // 
            // UserMansubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 552);
            this.Controls.Add(this.btnManagejob);
            this.Controls.Add(this.btndepartman);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.skinDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserMansubForm";
            this.Text = "UserMansubForm";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.skinContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private CCWin.SkinControl.SkinTextBox txtSearch;
        private CCWin.SkinControl.SkinButton btnSearch;
        private CCWin.SkinControl.SkinButton btnadd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private CCWin.SkinControl.SkinButton btndepartman;
        private CCWin.SkinControl.SkinButton btnManagejob;
    }
}