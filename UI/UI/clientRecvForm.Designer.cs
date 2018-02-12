namespace UI
{
    partial class clientRecvForm
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
            this.txtDetail = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
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
            this.txtDetail.Location = new System.Drawing.Point(16, 34);
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
            this.txtDetail.Size = new System.Drawing.Size(281, 176);
            // 
            // 
            // 
            this.txtDetail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDetail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDetail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtDetail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtDetail.SkinTxt.Multiline = true;
            this.txtDetail.SkinTxt.Name = "BaseText";
            this.txtDetail.SkinTxt.Size = new System.Drawing.Size(271, 166);
            this.txtDetail.SkinTxt.TabIndex = 0;
            this.txtDetail.SkinTxt.Text = "skinTextBox1";
            this.txtDetail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDetail.SkinTxt.WaterText = "";
            this.txtDetail.TabIndex = 0;
            this.txtDetail.Text = "skinTextBox1";
            this.txtDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDetail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtDetail.WaterText = "";
            this.txtDetail.WordWrap = true;
            // 
            // clientRecvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 224);
            this.Controls.Add(this.txtDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "clientRecvForm";
            this.Text = "公告";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox txtDetail;
    }
}