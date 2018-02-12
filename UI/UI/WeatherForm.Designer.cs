namespace UI
{
    partial class WeatherForm
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
            this.cont = new System.Windows.Forms.WebBrowser();
            this.skinProgressIndicator1 = new CCWin.SkinControl.SkinProgressIndicator();
            this.SuspendLayout();
            // 
            // cont
            // 
            this.cont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cont.Location = new System.Drawing.Point(4, 34);
            this.cont.MinimumSize = new System.Drawing.Size(20, 20);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(443, 162);
            this.cont.TabIndex = 0;
            this.cont.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.cont_DocumentCompleted);
            // 
            // skinProgressIndicator1
            // 
            this.skinProgressIndicator1.AutoStart = true;
            this.skinProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressIndicator1.CircleColor = System.Drawing.Color.DodgerBlue;
            this.skinProgressIndicator1.Location = new System.Drawing.Point(139, 50);
            this.skinProgressIndicator1.Name = "skinProgressIndicator1";
            this.skinProgressIndicator1.Percentage = 0F;
            this.skinProgressIndicator1.Size = new System.Drawing.Size(133, 133);
            this.skinProgressIndicator1.TabIndex = 1;
            this.skinProgressIndicator1.Text = "skinProgressIndicator1";
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 200);
            this.Controls.Add(this.skinProgressIndicator1);
            this.Controls.Add(this.cont);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeatherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "天气";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser cont;
        private CCWin.SkinControl.SkinProgressIndicator skinProgressIndicator1;
    }
}