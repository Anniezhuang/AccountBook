using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountBook
{
    public partial class SearchGetControl : UserControl
    {
        //设置day,week,month值，表示用户选择何种查询
        private int choice;

        private int day = 0;
        private int week = 1;
        private int month = 2;

        public SearchGetControl()
        {
            InitializeComponent();
        }

        //通过传递int值，得到用户选择查询的状态
        public SearchGetControl(int mychoice)
        {
            InitializeComponent();

            choice = mychoice;
        }

        //点击“查询”，可以进行日收入或周收入或月收入的查询
        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (choice == this.day)
            {
                BindListView(GetReminder.Search(dateTimePicker.Text, this.day));
                draw();
            }
            if (choice == this.week)
            {
                BindListView(GetReminder.Search(dateTimePicker.Text, this.week));
                draw();
            }
            if (choice == this.month)
            {
                BindListView(GetReminder.Search(dateTimePicker.Text, this.month));
                draw();
            }
            
        }

        //提取数据库数据，输入到列表
        //参考了老师上课的代码
        private void BindListView(List<GetReminder> list)
        {
            listViewReminder.Items.Clear();

            if (list == null)
            {
                return;
            }

            foreach (GetReminder reminder in list)
            {
                ListViewItem item = new ListViewItem(reminder.ID.ToString());

                item.SubItems.Add(reminder.Class);
                item.SubItems.Add(reminder.Time);
                item.SubItems.Add(reminder.Money);
                item.SubItems.Add(reminder.Remark);

                listViewReminder.Items.Add(item);
            }
        }

        //通过判断int值表示的状态，显示相应的标题
        private void SearchGetControl_Load(object sender, EventArgs e)
        {
            if (choice == this.day)
                labeltitle.Text = "日收入查询";
            else if (choice == this.week)
                labeltitle.Text = "周收入查询";
            else if (choice == this.month)
                labeltitle.Text = "月收入查询";
        }

        //参考http://www.cnblogs.com/icyJ/archive/2012/10/08/Chart_Pie.html
        //从列表中提取数据，画直方图、饼图
        private void draw()
        {
            List<int> y = new List<int>();
            List<string> x = new List<string>();
            for (int i = 0; i < listViewReminder.Items.Count; i++)
            {
                x.Add(listViewReminder.Items[i].SubItems[1].Text);
                y.Add(Convert.ToInt32(listViewReminder.Items[i].SubItems[3].Text));
            }
            pie.Series[0]["PieLabelStyle"] = "Outside";//将文字移到外侧
            pie.Series[0]["PieLineColor"] = "Black";//绘制黑色的连线。
            chart.Series[0].Points.DataBindXY(x, y);
            pie.Series[0].Points.DataBindXY(x, y);
        }
    }
}
