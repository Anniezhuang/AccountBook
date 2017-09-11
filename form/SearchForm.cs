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
    public partial class SearchForm : Form
    {
        //设置day,week,month值，表示用户选择何种查询
        private int day=0,week=1,month=2;


        private SearchGetControl searchGetday;
        private SearchGetControl searchGetweek;
        private SearchGetControl searchGetmonth;
        private SearchCostControl searchCostday;
        private SearchCostControl searchCostweek;
        private SearchCostControl searchCostmonth;

        //初始化查询的控件
        public SearchForm()
        {
            InitializeComponent();

            searchCostday = new SearchCostControl(day);
            searchCostday.Dock = DockStyle.Fill;

            searchCostweek = new SearchCostControl(week);
            searchCostweek.Dock = DockStyle.Fill;

            searchCostmonth = new SearchCostControl(month);
            searchCostmonth.Dock = DockStyle.Fill;

            searchGetday = new SearchGetControl(day);
            searchGetday.Dock = DockStyle.Fill;

            searchGetweek = new SearchGetControl(week);
            searchGetweek.Dock = DockStyle.Fill;

            searchGetmonth = new SearchGetControl(month);
            searchGetweek.Dock = DockStyle.Fill;

        }

        //显示日收入查询的控件，供用户查询日收入清单
        private void tsmidayget_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(searchGetday);
        }

        //显示周收入查询的控件，供用户查询周收入清单
        private void tsmiweekget_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(searchGetweek);
        }

        //显示月收入查询的控件，供用户查询月收入清单
        private void tsmimonthget_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(searchGetmonth);
        }

        //显示日支出查询的控件，供用户查询日支出清单
        private void tsmidaycost_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(searchCostday);
        }

        //初始化时，显示日收入查询的控件，供用户查询日收入清单
        private void SearchForm_Load(object sender, EventArgs e)
        {
            panel.Controls.Add(searchGetday);
        }

        //显示周支出查询的控件，供用户查询周支出清单
        private void tsmiweekcost_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(searchCostweek);
        }

        //显示月支出查询的控件，供用户查询月支出清单
        private void tsmimonthcost_Click(object sender, EventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(searchCostmonth);
        }
    }
}
