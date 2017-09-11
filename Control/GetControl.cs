using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//用户控件，支持用户自主输入在各类方面的收入
//用户也可以点击分类项，而不用输入类别
namespace AccountBook.Control
{
    public partial class GetControl : UserControl
    {
        public GetControl()
        {
            InitializeComponent();
        }

        //点击“工资”,lable文本变成“工资”
        private void BSalary_Click(object sender, EventArgs e)
        {
            labelClass.Text = BSalary.Text;
        }

        //点击“红包”,lable文本变成“红包”
        private void BRedMoney_Click(object sender, EventArgs e)
        {
            labelClass.Text = BRedMoney.Text;
        }

        //点击“兼职”,lable文本变成“兼职”
        private void BOtherJob_Click(object sender, EventArgs e)
        {
            labelClass.Text = BOtherJob.Text;
        }

        //点击“投资”,lable文本变成“投资”
        private void BInvest_Click(object sender, EventArgs e)
        {
            labelClass.Text = BInvest.Text;
        }

        //点击“奖金”,lable文本变成“奖金”
        private void BBonus_Click(object sender, EventArgs e)
        {
            labelClass.Text = BBonus.Text;
        }

        //点击“取消”,所有textbox变成空，类别初始化为“工资”
        private void buttonNo_Click(object sender, EventArgs e)
        {
            tbRemark.Text = null;
            labelClass.Text = BSalary.Text;
            tbCost.Text = null;
            tbRemark.Text = null;
            tbOthers.Text = null;
            tbCost.Text = null;
        }

        //点击“确定”
        private void buttonYes_Click(object sender, EventArgs e)
        {
            //存储数据
            GetReminder reminder = new GetReminder();
            reminder.ID = Guid.NewGuid();                                       //id
            reminder.Remark = tbRemark.Text;                                //备注
            reminder.Money = tbCost.Text;                                       //收入的金额
            reminder.Class = labelClass.Text;                                   //收入类别             
            reminder.Time = dateTimePicker.Text;                           //消费时间
            reminder.Add();

            ////所有textbox变成空，类别初始化为“工资”
            tbRemark.Text = null;
            labelClass.Text = BSalary.Text;
            tbOthers.Text = null;
            tbCost.Text = null;
            reminder = null;
        }

        //在“其他”中，用户自主输入类别
        private void tbOthers_TextChanged(object sender, EventArgs e)
        {
            labelClass.Text = tbOthers.Text;
        }

    }
}
