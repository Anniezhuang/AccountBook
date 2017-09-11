using AccountBook.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//预算表
namespace AccountBook
{
    public partial class GuessForm : Form
    {
        public GuessForm()
        {
            InitializeComponent();
        }

        //点击“关闭”，窗体关闭
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //提取数据库数据，输入到列表
        private void BindListView(List<GuessReminder> list)
        {
            listViewReminder.Items.Clear();

            if (list == null)
            {
                return;
            }

            foreach (GuessReminder reminder in list)
            {
                ListViewItem item = new ListViewItem(reminder.ID.ToString());

                item.SubItems.Add(reminder.Class);
                item.SubItems.Add(reminder.Time);
                item.SubItems.Add(reminder.Money);
                item.SubItems.Add(reminder.Remark);

                listViewReminder.Items.Add(item);
            }
        }

        //加载列表数据
        private void GuessForm_Load(object sender, EventArgs e)
        {
            GuessReminder.LoadAll();
            BindListView(GlobalData.Guess);
        }

        //双击一行数据，出现新的窗体“GuessUpdatReminderForm”
        //“GuessUpdatReminderForm”显示具体的数据信息，用户可以删除或更新数据
        private void listViewReminder_ItemActivate(object sender, EventArgs e)
        {
            string id = listViewReminder.SelectedItems[0].Text;
            GuessReminder reminder = new GuessReminder();
            reminder.ID = Guid.Parse(id);
            reminder.Load();
            GuessUpdateReminder form = new GuessUpdateReminder(reminder);
            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                BindListView(GlobalData.Guess);
            }
        }

        //点击"确定“，用户输入的数据导入数据库，并且在下方的列表显示
        private void buttonOK_Click(object sender, EventArgs e)
        {
            GuessReminder reminder = new GuessReminder();
            reminder.ID=Guid.NewGuid();
            reminder.Money = textBoxMon.Text;
            reminder.Remark = textBoxRemark.Text;
            reminder.Class = textBoxClass.Text;
            reminder.Time = dateTimePicker.Text;
            reminder.Add();
            BindListView(GlobalData.Guess);
        }
    }
}