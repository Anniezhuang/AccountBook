using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //点击左上角的“昵称”，可以编辑昵称。用户输入的文本替代“昵称”文本。
        private void buttonName_Click(object sender, EventArgs e)
        {
            NameForm personName = new NameForm();
            personName.ShowDialog();
            buttonName.Text = personName.textBoxName.Text;
        }

        //点击“预算”，出现新的窗体"GuessForm"，显示预算表等信息
        private void buttonGuessMoney_Click(object sender, EventArgs e)
        {
            GuessForm guessMoney = new GuessForm();
            guessMoney.ShowDialog();
        }

        //加载所有数据
        private void MainForm_Load(object sender, EventArgs e)
        {
            GetReminder.LoadAll();
            GuessReminder.LoadAll();
            CostReminder.LoadAll();
        }

        //点击“记账”，出现新的窗体"WriteDownForm"，可以记录收入支出
        private void buttonWrite_Click(object sender, EventArgs e)
        {
            string name = buttonName.Text;
            WriteDownForm writedown = new WriteDownForm(name);
            writedown.ShowDialog();
        }

        //点击“收入”，出现新的窗体"GetReminderForm"，显示收入列表
        private void buttonGet_Click(object sender, EventArgs e)
        {
            GetReminderForm getReminderForm = new GetReminderForm();
            getReminderForm.ShowDialog();
        }

        //点击“支出”，出现新的窗体"CostReminderForm"，显示支出列表
        private void buttonCost_Click(object sender, EventArgs e)
        {
            CostReminderForm costReminderForm = new CostReminderForm();
            costReminderForm.ShowDialog();
        }
    }
}
