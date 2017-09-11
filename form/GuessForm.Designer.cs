namespace AccountBook
{
    partial class GuessForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.listViewReminder = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chClass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chRemark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.label_mon = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.textBoxMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(291, 503);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
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
            this.listViewReminder.Location = new System.Drawing.Point(12, 299);
            this.listViewReminder.MultiSelect = false;
            this.listViewReminder.Name = "listViewReminder";
            this.listViewReminder.Size = new System.Drawing.Size(630, 198);
            this.listViewReminder.TabIndex = 7;
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
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(249, 201);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(222, 21);
            this.dateTimePicker.TabIndex = 30;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("幼圆", 25F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTitle.Location = new System.Drawing.Point(266, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(151, 34);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "我的预算";
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(249, 158);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(222, 21);
            this.textBoxRemark.TabIndex = 28;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(306, 240);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 27;
            this.buttonOK.Text = "确定";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(249, 73);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(222, 21);
            this.textBoxClass.TabIndex = 26;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRemark.Location = new System.Drawing.Point(113, 159);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(59, 20);
            this.labelRemark.TabIndex = 25;
            this.labelRemark.Text = "备注:";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClass.Location = new System.Drawing.Point(113, 74);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(99, 20);
            this.labelClass.TabIndex = 24;
            this.labelClass.Text = "消费类别:";
            // 
            // label_mon
            // 
            this.label_mon.AutoSize = true;
            this.label_mon.Location = new System.Drawing.Point(490, 115);
            this.label_mon.Name = "label_mon";
            this.label_mon.Size = new System.Drawing.Size(17, 12);
            this.label_mon.TabIndex = 23;
            this.label_mon.Text = "元";
            // 
            // labelMon
            // 
            this.labelMon.AutoSize = true;
            this.labelMon.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMon.Location = new System.Drawing.Point(113, 118);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(109, 20);
            this.labelMon.TabIndex = 22;
            this.labelMon.Text = "预算金额：";
            // 
            // textBoxMon
            // 
            this.textBoxMon.Location = new System.Drawing.Point(248, 115);
            this.textBoxMon.Name = "textBoxMon";
            this.textBoxMon.Size = new System.Drawing.Size(223, 21);
            this.textBoxMon.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(113, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "消费日期：";
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.label_mon);
            this.Controls.Add(this.labelMon);
            this.Controls.Add(this.textBoxMon);
            this.Controls.Add(this.listViewReminder);
            this.Controls.Add(this.buttonClose);
            this.Name = "GuessForm";
            this.Text = "预算表";
            this.Load += new System.EventHandler(this.GuessForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListView listViewReminder;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chClass;
        private System.Windows.Forms.ColumnHeader chTime;
        private System.Windows.Forms.ColumnHeader chCost;
        private System.Windows.Forms.ColumnHeader chRemark;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxClass;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label label_mon;
        private System.Windows.Forms.Label labelMon;
        public System.Windows.Forms.TextBox textBoxMon;
        private System.Windows.Forms.Label label1;
    }
}