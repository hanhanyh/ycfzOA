namespace UI
{
    partial class KQRecordForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartCD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartcql = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartcql)).BeginInit();
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
            this.Column2,
            this.Column1,
            this.columnType,
            this.Column4});
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
            this.skinDataGridView1.Location = new System.Drawing.Point(12, 10);
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
            this.skinDataGridView1.Size = new System.Drawing.Size(806, 179);
            this.skinDataGridView1.TabIndex = 0;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(236)))));
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.skinDataGridView1_CellFormatting);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "用户ID";
            this.Column2.HeaderText = "员工ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "员工名";
            this.Column1.HeaderText = "员工名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // columnType
            // 
            this.columnType.DataPropertyName = "类型";
            this.columnType.HeaderText = "类型";
            this.columnType.Name = "columnType";
            this.columnType.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "时间";
            this.Column4.HeaderText = "时间";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // chartCD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCD.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chartCD.Legends.Add(legend1);
            this.chartCD.Location = new System.Drawing.Point(12, 195);
            this.chartCD.Name = "chartCD";
            series1.ChartArea = "ChartArea1";
            series1.Label = "#VALX #VAL";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartCD.Series.Add(series1);
            this.chartCD.Size = new System.Drawing.Size(370, 212);
            this.chartCD.TabIndex = 1;
            this.chartCD.Text = "chart1";
            // 
            // chartcql
            // 
            chartArea2.Name = "ChartArea1";
            this.chartcql.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.chartcql.Legends.Add(legend2);
            this.chartcql.Location = new System.Drawing.Point(425, 195);
            this.chartcql.Name = "chartcql";
            series2.ChartArea = "ChartArea1";
            series2.Label = "#VALX #VAL";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartcql.Series.Add(series2);
            this.chartcql.Size = new System.Drawing.Size(393, 212);
            this.chartcql.TabIndex = 2;
            this.chartcql.Text = "chart1";
            // 
            // KQRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 515);
            this.Controls.Add(this.chartcql);
            this.Controls.Add(this.chartCD);
            this.Controls.Add(this.skinDataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KQRecordForm";
            this.Text = "KQRecordForm";
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartcql)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartcql;
    }
}