namespace AccountBook
{
    partial class SearchCostControl
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listViewReminder = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(22, 58);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker.TabIndex = 0;
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
            this.listViewReminder.Location = new System.Drawing.Point(22, 95);
            this.listViewReminder.MultiSelect = false;
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(605, 157);
            this.listViewReminder.TabIndex = 3;
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
            this.chClass.Text = "消费类别";
            this.chClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chClass.Width = 75;
            // 
            // chTime
            // 
            this.chTime.Text = "消费日期";
            this.chTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTime.Width = 153;
            // 
            // chCost
            // 
            this.chCost.Text = "消费金额（元）";
            this.chCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCost.Width = 159;
            // 
            // chRemark
            // 
            this.chRemark.Text = "备注";
            this.chRemark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chRemark.Width = 137;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(272, 58);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "查询";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.Font = new System.Drawing.Font("华文行楷", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.Location = new System.Drawing.Point(231, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(148, 29);
            this.labeltitle.TabIndex = 9;
            this.labeltitle.Text = "日支出查询";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(2, 258);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(319, 300);
            this.chart.TabIndex = 10;
            this.chart.Text = "chart";
            // 
            // pie
            // 
            chartArea2.Name = "ChartArea1";
            this.pie.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.pie.Legends.Add(legend2);
            this.pie.Location = new System.Drawing.Point(327, 258);
            this.pie.Name = "pie";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.pie.Series.Add(series2);
            this.pie.Size = new System.Drawing.Size(300, 300);
            this.pie.TabIndex = 11;
            this.pie.Text = "pie";
            // 
            // SearchCostControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pie);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.listViewReminder);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "SearchCostControl";
            this.Size = new System.Drawing.Size(646, 590);
            this.Load += new System.EventHandler(this.SearchCostControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ListView listViewReminder;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chClass;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
    }
}
