namespace UI
{
    partial class WorklogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorklogForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtWorklog = new CCWin.SkinControl.SkinTextBox();
            this.btnSubmit = new CCWin.SkinControl.SkinButton();
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.skinContextMenuStrip1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.查看详情ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.skinContextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWorklog
            // 
            this.txtWorklog.BackColor = System.Drawing.Color.Transparent;
            this.txtWorklog.DownBack = null;
            this.txtWorklog.Icon = null;
            this.txtWorklog.IconIsButton = false;
            this.txtWorklog.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtWorklog.IsPasswordChat = '\0';
            this.txtWorklog.IsSystemPasswordChar = false;
            this.txtWorklog.Lines = new string[] {
        "skinTextBox1"};
            this.txtWorklog.Location = new System.Drawing.Point(50, 34);
            this.txtWorklog.Margin = new System.Windows.Forms.Padding(0);
            this.txtWorklog.MaxLength = 32767;
            this.txtWorklog.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtWorklog.MouseBack = null;
            this.txtWorklog.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtWorklog.Multiline = true;
            this.txtWorklog.Name = "txtWorklog";
            this.txtWorklog.NormlBack = null;
            this.txtWorklog.Padding = new System.Windows.Forms.Padding(5);
            this.txtWorklog.ReadOnly = false;
            this.txtWorklog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWorklog.Size = new System.Drawing.Size(771, 136);
            // 
            // 
            // 
            this.txtWorklog.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorklog.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorklog.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtWorklog.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtWorklog.SkinTxt.Multiline = true;
            this.txtWorklog.SkinTxt.Name = "BaseText";
            this.txtWorklog.SkinTxt.Size = new System.Drawing.Size(761, 126);
            this.txtWorklog.SkinTxt.TabIndex = 0;
            this.txtWorklog.SkinTxt.Text = "skinTextBox1";
            this.txtWorklog.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtWorklog.SkinTxt.WaterText = "";
            this.txtWorklog.TabIndex = 2;
            this.txtWorklog.Text = "skinTextBox1";
            this.txtWorklog.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWorklog.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtWorklog.WaterText = "";
            this.txtWorklog.WordWrap = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.BaseColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSubmit.DownBack = null;
            this.btnSubmit.IsDrawBorder = false;
            this.btnSubmit.IsDrawGlass = false;
            this.btnSubmit.Location = new System.Drawing.Point(729, 174);
            this.btnSubmit.MouseBack = null;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NormlBack = null;
            this.btnSubmit.Size = new System.Drawing.Size(92, 26);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "提交工作日志";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // skinDataGridView1
            // 
            this.skinDataGridView1.AllowUserToAddRows = false;
            this.skinDataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.skinDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView1.ColumnFont = null;
            this.skinDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.skinDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.ContextMenuStrip = this.skinContextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.skinDataGridView1.EnableHeadersVisualStyles = false;
            this.skinDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.Location = new System.Drawing.Point(47, 214);
            this.skinDataGridView1.Name = "skinDataGridView1";
            this.skinDataGridView1.ReadOnly = true;
            this.skinDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.skinDataGridView1.RowTemplate.Height = 23;
            this.skinDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.skinDataGridView1.Size = new System.Drawing.Size(771, 221);
            this.skinDataGridView1.TabIndex = 4;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
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
            this.查看详情ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.skinContextMenuStrip1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.skinContextMenuStrip1.Name = "skinContextMenuStrip1";
            this.skinContextMenuStrip1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinContextMenuStrip1.Size = new System.Drawing.Size(125, 48);
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
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.White;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(41, 10);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(56, 17);
            this.skinLabel1.TabIndex = 5;
            this.skinLabel1.Text = "工作日志";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.skinDataGridView1);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 499);
            this.panel1.TabIndex = 6;
            // 
            // WorklogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 511);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtWorklog);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorklogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorklogForm";
            this.Load += new System.EventHandler(this.WorklogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.skinContextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinTextBox txtWorklog;
        private CCWin.SkinControl.SkinButton btnSubmit;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private CCWin.SkinControl.SkinContextMenuStrip skinContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看详情ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.Panel panel1;
    }
}