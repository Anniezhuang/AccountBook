using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//用户控件，支持用户自主输入在各类方面的支出
//用户也可以点击分类项，而不用输入类别
namespace AccountBook.Control
{
    public partial class CostControl : UserControl
    {
        public CostControl()
        {
            InitializeComponent();
        }

        //点击“吃喝”，所有textbox变成空，lable文本变成“吃喝”
        private void BEating_Click(object sender, EventArgs e)
        {
            labelClass.Text = BEating.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“交通”，所有textbox变成空，lable文本变成“交通”
        private void BTransport_Click(object sender, EventArgs e)
        {
            labelClass.Text = BTransport.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“服饰”，所有textbox变成空，lable文本变成“服饰”
        private void BClouth_Click(object sender, EventArgs e)
        {
            labelClass.Text = BClouth.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“日用品”，所有textbox变成空，lable文本变成“日用品”
        private void BArticles_Click(object sender, EventArgs e)
        {
            labelClass.Text = BArticles.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“红包”，所有textbox变成空，lable文本变成“红包”
        private void BRedMon_Click(object sender, EventArgs e)
        {
            labelClass.Text = BRedMon.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“买菜”，所有textbox变成空，lable文本变成“买菜”
        private void BFood_Click(object sender, EventArgs e)
        {
            labelClass.Text = BFood.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“孩子”，所有textbox变成空，lable文本变成“孩子”
        private void BKids_Click(object sender, EventArgs e)
        {
            labelClass.Text = BKids.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“网购”，所有textbox变成空，lable文本变成“话费”
        private void BWeb_Click(object sender, EventArgs e)
        {
            labelClass.Text = BWeb.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“话费”，所有textbox变成空，lable文本变成“话费”
        private void BTele_Click(object sender, EventArgs e)
        {
            labelClass.Text = BTele.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“娱乐”，所有textbox变成空，lable文本变成“娱乐”
        private void BPlay_Click(object sender, EventArgs e)
        {
            labelClass.Text = BPlay.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“医疗”，所有textbox变成空，lable文本变成“医疗”
        private void BMedical_Click(object sender, EventArgs e)
        {
            labelClass.Text = BMedical.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“化妆”，所有textbox变成空，lable文本变成“化妆”
        private void BSkincare_Click(object sender, EventArgs e)
        {
            labelClass.Text = BSkincare.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
        }

        //点击“取消”，所有textbox变成空，lable文本初始化为“吃喝”
        private void buttonNo_Click(object sender, EventArgs e)
        {
            tbRemark.Text = null;
            labelClass.Text = BEating.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
            tbCost.Text = null;
        }

        //点击“确定”
        private void buttonYes_Click(object sender, EventArgs e)
        {
            //存储数据
            CostReminder reminder = new CostReminder();
            reminder.ID = Guid.NewGuid();                                       //id
            reminder.Remark = tbRemark.Text;                                //备注
            reminder.Money = tbCost.Text;                                       //支出的金额
            reminder.Class= labelClass.Text;                                   //消费类别
            reminder.Time = dateTimePicker.Text;                           //消费时间
            reminder.Add();

            //所有textbox变成空，类别初始化为“吃喝”
            labelClass.Text = BEating.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
            reminder = null;
        }

        //在“其他”中，用户自主输入类别
        private void tbOthers_TextChanged(object sender, EventArgs e)
        {
            labelClass.Text = tbOthers.Text;
        }
        
    }
}
