namespace AccountBook
{
    partial class SearchForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidayget = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiweekget = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimonthget = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmidaycost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiweekcost = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmimonthcost = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(760, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGet,
            this.tsmiCost});
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.查询ToolStripMenuItem.Text = "查询";
            // 
            // tsmiGet
            // 
            this.tsmiGet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmidayget,
            this.tsmiweekget,
            this.tsmimonthget});
            this.tsmiGet.Name = "tsmiGet";
            this.tsmiGet.Size = new System.Drawing.Size(100, 22);
            this.tsmiGet.Text = "收入";
            // 
            // tsmidayget
            // 
            this.tsmidayget.Name = "tsmidayget";
            this.tsmidayget.Size = new System.Drawing.Size(100, 22);
            this.tsmidayget.Text = "每天";
            this.tsmidayget.Click += new System.EventHandler(this.tsmidayget_Click);
            // 
            // tsmiweekget
            // 
            this.tsmiweekget.Name = "tsmiweekget";
            this.tsmiweekget.Size = new System.Drawing.Size(100, 22);
            this.tsmiweekget.Text = "每周";
            this.tsmiweekget.Click += new System.EventHandler(this.tsmiweekget_Click);
            // 
            // tsmimonthget
            // 
            this.tsmimonthget.Name = "tsmimonthget";
            this.tsmimonthget.Size = new System.Drawing.Size(100, 22);
            this.tsmimonthget.Text = "每月";
            this.tsmimonthget.Click += new System.EventHandler(this.tsmimonthget_Click);
            // 
            // tsmiCost
            // 
            this.tsmiCost.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmidaycost,
            this.tsmiweekcost,
            this.tsmimonthcost});
            this.tsmiCost.Name = "tsmiCost";
            this.tsmiCost.Size = new System.Drawing.Size(100, 22);
            this.tsmiCost.Text = "支出";
            // 
            // tsmidaycost
            // 
            this.tsmidaycost.Name = "tsmidaycost";
            this.tsmidaycost.Size = new System.Drawing.Size(100, 22);
            this.tsmidaycost.Text = "每天";
            this.tsmidaycost.Click += new System.EventHandler(this.tsmidaycost_Click);
            // 
            // tsmiweekcost
            // 
            this.tsmiweekcost.Name = "tsmiweekcost";
            this.tsmiweekcost.Size = new System.Drawing.Size(100, 22);
            this.tsmiweekcost.Text = "每周";
            this.tsmiweekcost.Click += new System.EventHandler(this.tsmiweekcost_Click);
            // 
            // tsmimonthcost
            // 
            this.tsmimonthcost.Name = "tsmimonthcost";
            this.tsmimonthcost.Size = new System.Drawing.Size(100, 22);
            this.tsmimonthcost.Text = "每月";
            this.tsmimonthcost.Click += new System.EventHandler(this.tsmimonthcost_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(760, 562);
            this.panel.TabIndex = 1;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 587);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGet;
        private System.Windows.Forms.ToolStripMenuItem tsmiCost;
        private System.Windows.Forms.ToolStripMenuItem tsmimonthcost;
        private System.Windows.Forms.ToolStripMenuItem tsmidayget;
        private System.Windows.Forms.ToolStripMenuItem tsmiweekget;
        private System.Windows.Forms.ToolStripMenuItem tsmimonthget;
        private System.Windows.Forms.ToolStripMenuItem tsmidaycost;
        private System.Windows.Forms.ToolStripMenuItem tsmiweekcost;
        private System.Windows.Forms.Panel panel;
    }
}