namespace AccountBook
{
    partial class CostUpdateReminderForm
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
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelOthers = new System.Windows.Forms.Label();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.labelMon = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNo = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMoney.Location = new System.Drawing.Point(40, 134);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(99, 19);
            this.labelMoney.TabIndex = 60;
            this.labelMoney.Text = "消费金额:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(131, 297);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(162, 23);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.Text = "删除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(40, 85);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(109, 19);
            this.labelTime.TabIndex = 58;
            this.labelTime.Text = "消费日期：";
            // 
            // labelOthers
            // 
            this.labelOthers.AutoSize = true;
            this.labelOthers.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelOthers.Location = new System.Drawing.Point(40, 35);
            this.labelOthers.Name = "labelOthers";
            this.labelOthers.Size = new System.Drawing.Size(109, 19);
            this.labelOthers.TabIndex = 57;
            this.labelOthers.Text = "消费类别：";
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(165, 33);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(185, 21);
            this.tbClass.TabIndex = 56;
            // 
            // tbRemark
            // 
            this.tbRemark.Location = new System.Drawing.Point(165, 189);
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(185, 21);
            this.tbRemark.TabIndex = 55;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRemark.Location = new System.Drawing.Point(80, 185);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(69, 19);
            this.labelRemark.TabIndex = 54;
            this.labelRemark.Text = "备注：";
            // 
            // labelMon
            // 
            this.labelMon.AutoSize = true;
            this.labelMon.Location = new System.Drawing.Point(356, 142);
            this.labelMon.Name = "labelMon";
            this.labelMon.Size = new System.Drawing.Size(17, 12);
            this.labelMon.TabIndex = 53;
            this.labelMon.Text = "元";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(131, 255);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(162, 23);
            this.buttonUpdate.TabIndex = 52;
            this.buttonUpdate.Text = "更新";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonNo
            // 
            this.buttonNo.Location = new System.Drawing.Point(131, 339);
            this.buttonNo.Name = "buttonNo";
            this.buttonNo.Size = new System.Drawing.Size(162, 23);
            this.buttonNo.TabIndex = 51;
            this.buttonNo.Text = "取消";
            this.buttonNo.UseVisualStyleBackColor = true;
            this.buttonNo.Click += new System.EventHandler(this.buttonNo_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(165, 85);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(185, 21);
            this.dateTimePicker.TabIndex = 50;
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(165, 137);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(185, 21);
            this.tbCost.TabIndex = 49;
            // 
            // CostUpdateReminderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 395);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelOthers);
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.tbRemark);
            this.Controls.Add(this.labelRemark);
            this.Controls.Add(this.labelMon);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonNo);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.tbCost);
            this.Name = "CostUpdateReminderForm";
            this.Text = "支出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelOthers;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.Label labelMon;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox tbCost;
    }
}