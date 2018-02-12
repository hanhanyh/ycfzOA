namespace UI
{
    partial class LoginProgressBarForm
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
            this.skinProgressIndicator1 = new CCWin.SkinControl.SkinProgressIndicator();
            this.SuspendLayout();
            // 
            // skinProgressIndicator1
            // 
            this.skinProgressIndicator1.AutoStart = true;
            this.skinProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressIndicator1.CircleColor = System.Drawing.Color.Blue;
            this.skinProgressIndicator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.skinProgressIndicator1.Location = new System.Drawing.Point(26, 12);
            this.skinProgressIndicator1.Name = "skinProgressIndicator1";
            this.skinProgressIndicator1.Percentage = 0F;
            this.skinProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.skinProgressIndicator1.TabIndex = 0;
            this.skinProgressIndicator1.Text = "skinProgressIndicator1";
            // 
            // LoginProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(142, 124);
            this.Controls.Add(this.skinProgressIndicator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginProgressBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginProgressBarForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinProgressIndicator skinProgressIndicator1;
    }
}