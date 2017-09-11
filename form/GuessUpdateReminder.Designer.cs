namespace AccountBook
{
    partial class GuessUpdateReminder
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRemark = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.label_mon = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxRemark = new System.Windows.Forms.TextBox();
            this.textBoxClass = new System.Windows.Forms.TextBox();
            this.textBoxMon = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("幼圆", 25F);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTitle.Location = new System.Drawing.Point(100, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(151, 34);
            this.labelTitle.TabIndex = 29;
            this.labelTitle.Text = "我的预算";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(106, 372);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(143, 23);
            this.buttonClose.TabIndex = 27;
            this.buttonClose.Text = "取消";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRemark.Location = new System.Drawing.Point(40, 178);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(59, 20);
            this.labelRemark.TabIndex = 25;
            this.labelRemark.Text = "备注:";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelClass.Location = new System.Drawing.Point(40, 93);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(99, 20);
            this.labelClass.TabIndex = 24;
            this.labelClass.Text = "消费类别:";
            // 
            // label_mon
            // 
            this.label_mon.AutoSize = true;
            this.label_mon.Location = new System.Drawing.Point(262, 145);
            this.label_mon.Name = "label_mon";
            this.label_mon.Size = new System.Drawing.Size(17, 12);
            this.label_mon.TabIndex = 23;
            this.label_mon.Text = "元";
            // 
            // labelMon
            // 
            this.labelMon.AutoSize = true;
            this.labelMon.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMon.Location = new System.Drawing.Point(40, 137);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(109, 20);
            this.labelMon.TabIndex = 22;
            this.labelMon.Text = "预算金额：";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("宋体", 15F);
            this.labelTime.Location = new System.Drawing.Point(40, 225);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(109, 20);
            this.labelTime.TabIndex = 35;
            this.labelTime.Text = "消费日期：";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(106, 300);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(143, 23);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(106, 336);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(143, 23);
            this.buttonDelete.TabIndex = 37;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxRemark
            // 
            this.textBoxRemark.Location = new System.Drawing.Point(149, 178);
            this.textBoxRemark.Name = "textBoxRemark";
            this.textBoxRemark.Size = new System.Drawing.Size(100, 21);
            this.textBoxRemark.TabIndex = 40;
            // 
            // textBoxClass
            // 
            this.textBoxClass.Location = new System.Drawing.Point(149, 97);
            this.textBoxClass.Name = "textBoxClass";
            this.textBoxClass.Size = new System.Drawing.Size(99, 21);
            this.textBoxClass.TabIndex = 39;
            // 
            // textBoxMon
            // 
            this.textBoxMon.Location = new System.Drawing.Point(149, 139);
            this.textBoxMon.Name = "textBoxMon";
            this.textBoxMon.Size = new System.Drawing.Size(100, 21);
            this.textBoxMon.TabIndex = 38;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(149, 225);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker.TabIndex = 41;
            // 
            // GuessUpdateReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 421);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.textBoxRemark);
            this.Controls.Add(this.textBoxClass);
            this.Controls.Add(this.textBoxMon);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.label_mon);
            this.Controls.Add(this.labelMon);
            this.Name = "GuessUpdateReminder";
            this.Text = "预算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label label_mon;
        private System.Windows.Forms.Label labelMon;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        public System.Windows.Forms.TextBox textBoxRemark;
        private System.Windows.Forms.TextBox textBoxClass;
        public System.Windows.Forms.TextBox textBoxMon;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}