using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//支出列表
namespace AccountBook
{
    public partial class CostReminderForm : Form
    {
        public CostReminderForm()
        {
            InitializeComponent();
        }

        //加载列表数据
        private void CostReminderForm_Load(object sender, EventArgs e)
        {
            BindListView(GlobalData.Cost);
        }

        //提取数据库数据，输入到列表
        private void BindListView(List<CostReminder> list)
        {
            listViewReminder.Items.Clear();

            if (list == null)
            {
                return;
            }

            foreach (CostReminder reminder in list)
            {
                ListViewItem item = new ListViewItem(reminder.ID.ToString());

                item.SubItems.Add(reminder.Class);
                item.SubItems.Add(reminder.Time);
                item.SubItems.Add(reminder.Money);
                item.SubItems.Add(reminder.Remark);

                listViewReminder.Items.Add(item);
            }
        }

        //点击“关闭”，窗体关闭
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //双击一行数据，出现新的窗体“CostUpdatReminderForm”
        //“CostUpdatReminderForm”显示具体的数据信息，用户可以删除或更新数据
        private void listViewReminder_ItemActivate(object sender, EventArgs e)
        {
            string id = listViewReminder.SelectedItems[0].Text;
            CostReminder reminder = new CostReminder();
            reminder.ID = Guid.Parse(id);
            reminder.Load();
            CostUpdateReminderForm form = new CostUpdateReminderForm(reminder);
            DialogResult result = form.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                BindListView(GlobalData.Cost);
            }
        }

        //点击“查询”。
        //出现新的窗体SearchForm，可查询支出收入，并显示相应的直方图和饼图
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.ShowDialog();
        }
    }
}
