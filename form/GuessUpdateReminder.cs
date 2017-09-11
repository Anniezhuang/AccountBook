using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//一项预算数据的具体信息，可以删除或更改数据
namespace AccountBook
{
    public partial class GuessUpdateReminder : Form
    {
        private GuessReminder reminder;

        public GuessUpdateReminder()
        {
            InitializeComponent();
        }

        //显示具体的数据
        public GuessUpdateReminder(GuessReminder reminder)
        {
            InitializeComponent();

            this.reminder = reminder;
            dateTimePicker.Text = reminder.Time;
            textBoxClass.Text = reminder.Class;
            textBoxMon.Text = reminder.Money;
            textBoxRemark.Text = reminder.Remark;
        }

        //修改完数据，点击“更新”，把更改的数据保存，关闭窗体
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            reminder.Remark = textBoxRemark.Text;
            reminder.Money = textBoxMon.Text;
            reminder.Class = textBoxClass.Text;
            reminder.Time = dateTimePicker.Text;

            reminder.Update();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        //点击“删除”，删除该项数据，窗体关闭
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.reminder.Delete();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        //点击“取消”，关闭窗体
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
