namespace AccountBook
{
    partial class MainForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonName = new System.Windows.Forms.Button();
            this.buttonGuessMoney = new System.Windows.Forms.Button();
            this.buttonGet = new System.Windows.Forms.Button();
            this.buttonCost = new System.Windows.Forms.Button();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labeltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonName
            // 
            this.buttonName.Location = new System.Drawing.Point(12, 9);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(66, 25);
            this.buttonName.TabIndex = 0;
            this.buttonName.Text = "昵称";
            this.buttonName.UseVisualStyleBackColor = true;
            this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
            // 
            // buttonGuessMoney
            // 
            this.buttonGuessMoney.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGuessMoney.Font = new System.Drawing.Font("华文行楷", 18F);
            this.buttonGuessMoney.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGuessMoney.Location = new System.Drawing.Point(113, 190);
            this.buttonGuessMoney.Name = "buttonGuessMoney";
            this.buttonGuessMoney.Size = new System.Drawing.Size(47, 60);
            this.buttonGuessMoney.TabIndex = 1;
            this.buttonGuessMoney.Text = "预算";
            this.buttonGuessMoney.UseVisualStyleBackColor = false;
            this.buttonGuessMoney.Click += new System.EventHandler(this.buttonGuessMoney_Click);
            // 
            // buttonGet
            // 
            this.buttonGet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonGet.Font = new System.Drawing.Font("华文行楷", 18F);
            this.buttonGet.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonGet.Location = new System.Drawing.Point(212, 250);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(42, 63);
            this.buttonGet.TabIndex = 2;
            this.buttonGet.Text = "收入";
            this.buttonGet.UseVisualStyleBackColor = false;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // buttonCost
            // 
            this.buttonCost.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCost.Font = new System.Drawing.Font("华文行楷", 18F);
            this.buttonCost.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonCost.Location = new System.Drawing.Point(293, 190);
            this.buttonCost.Name = "buttonCost";
            this.buttonCost.Size = new System.Drawing.Size(49, 63);
            this.buttonCost.TabIndex = 15;
            this.buttonCost.Text = "支出";
            this.buttonCost.UseVisualStyleBackColor = false;
            this.buttonCost.Click += new System.EventHandler(this.buttonCost_Click);
            // 
            // buttonWrite
            // 
            this.buttonWrite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonWrite.Font = new System.Drawing.Font("华文行楷", 18F);
            this.buttonWrite.ForeColor = System.Drawing.SystemColors.Highlight;
            this.buttonWrite.Location = new System.Drawing.Point(408, 147);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(47, 68);
            this.buttonWrite.TabIndex = 16;
            this.buttonWrite.Text = "记账";
            this.buttonWrite.UseVisualStyleBackColor = false;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.labeltitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeltitle.Font = new System.Drawing.Font("华文新魏", 40F);
            this.labeltitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labeltitle.Location = new System.Drawing.Point(147, 9);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(240, 55);
            this.labeltitle.TabIndex = 17;
            this.labeltitle.Text = "个人账本";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 340);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.buttonCost);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.buttonGuessMoney);
            this.Controls.Add(this.buttonName);
            this.Name = "MainForm";
            this.Text = "个人账本";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Button buttonGuessMoney;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.Button buttonCost;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.Label labeltitle;
    }
}

