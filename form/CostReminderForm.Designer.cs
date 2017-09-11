namespace AccountBook
{
    partial class CostReminderForm
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
            this.listViewReminder = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listViewReminder.Location = new System.Drawing.Point(13, 23);
            this.listViewReminder.MultiSelect = false;
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(622, 198);
            this.listViewReminder.TabIndex = 2;
            this.listViewReminder.UseCompatibleStateImageBehavior = false;
            this.listViewReminder.View = System.Windows.Forms.View.Details;
            this.listViewReminder.ItemActivate += new System.EventHandler(this.listViewReminder_ItemActivate);
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
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(357, 254);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(194, 254);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "查询";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // CostReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 289);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listViewReminder);
            this.Name = "CostReminderForm";
            this.Text = "支出清单";
            this.Load += new System.EventHandler(this.CostReminderForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewReminder;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chClass;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.Button buttonSearch;
    }
}