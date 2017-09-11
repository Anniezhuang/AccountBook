namespace AccountBook
{
    partial class SearchGetControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonOK = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listViewReminder = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labeltitle = new System.Windows.Forms.Label();
            this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(272, 55);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "查询";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(20, 57);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker.TabIndex = 5;
            // 
            // listViewReminder
            // 
            this.listViewReminder.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewReminder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chClass,
            this.chTime,
            this.chCost,
            this.chRemark});
            this.listViewReminder.FullRowSelect = true;
            this.listViewReminder.GridLines = true;
            this.listViewReminder.Location = new System.Drawing.Point(20, 92);
            this.listViewReminder.MultiSelect = false;
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(603, 159);
            this.listViewReminder.TabIndex = 7;
            this.listViewReminder.UseCompatibleStateImageBehavior = false;
            this.listViewReminder.View = System.Windows.Forms.View.Details;
            // 
            // chID
            // 
            this.chID.Text = "ID";
            this.chID.Width = 73;
            // 
            // chClass
            // 
            this.chClass.Text = "收入类别";
            this.chClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chClass.Width = 75;
            // 
            // chTime
            // 
            this.chTime.Text = "收入日期";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 153;
            // 
            // chCost
            // 
            this.chCost.Text = "收入金额（元）";
            this.chCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCost.Width = 159;
            // 
            // chRemark
            // 
            this.chRemark.Text = "备注";
            this.chRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRemark.Width = 137;
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("华文行楷", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.Location = new System.Drawing.Point(242, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(148, 29);
            this.labeltitle.TabIndex = 8;
            this.labeltitle.Text = "日收入查询";
            // 
            // pie
            // 
            chartArea1.BorderColor = System.Drawing.Color.DarkRed;
            chartArea1.Name = "ChartArea1";
            this.pie.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.pie.Legends.Add(legend1);
            this.pie.Location = new System.Drawing.Point(333, 277);
            this.pie.Name = "pie";
            series1.BorderColor = System.Drawing.Color.Brown;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pie.Series.Add(series1);
            this.pie.Size = new System.Drawing.Size(300, 300);
            this.pie.TabIndex = 13;
            this.pie.Text = "pie";
            // 
            // chart
            // 
            chartArea2.BorderColor = System.Drawing.Color.IndianRed;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Maroon;
            this.chart.ChartAreas.Add(chartArea2);
            legend2.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.Indigo;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Red;
            legend2.Name = "Legend1";
            legend2.ShadowColor = System.Drawing.Color.Blue;
            legend2.ShadowOffset = 1;
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(8, 277);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(319, 300);
            this.chart.TabIndex = 12;
            this.chart.Text = "chart";
            // 
            // SearchGetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pie);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.listViewReminder);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "SearchGetControl";
            this.Size = new System.Drawing.Size(650, 590);
            this.Load += new System.EventHandler(this.SearchGetControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListView listViewReminder;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chClass;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}
