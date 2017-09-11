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

//用户点击“记账”，然后点击“支出”或“收入”，接着可以记账
namespace AccountBook
{
    public partial class WriteDownForm : Form
    {
        private CostControl costControl;      //支出的控件
        private GetControl getControl;         //收入的控件

        public WriteDownForm(string name)
        {
            InitializeComponent();

            //左上角显示"welcome,用户昵称“
            labelName.Text = "welcome,"+name;

            costControl = new CostControl();
            costControl.Dock = DockStyle.Fill;

            getControl = new GetControl();
            getControl.Dock = DockStyle.Fill;
        }

        //点击收入按钮，按钮变色表示选中，然后可以输入收入的相关数据
        private void buttonGet_Click(object sender, EventArgs e)
        {
            buttonGet.BackColor = Color.LightBlue;
            buttonCost.BackColor = default(Color);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(getControl);
        }

        //点击支出按钮，按钮变色表示选中，然后可以输入支出的相关数据
        private void buttonCost_Click(object sender, EventArgs e)
        {
            buttonCost.BackColor = Color.LightBlue;
            buttonGet.BackColor = default(Color);
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(costControl);
        }

        //加载窗体，默认先出现记录收入的界面，收入的按钮变成蓝色
        private void WriteDown_Load(object sender, EventArgs e)
        {
            panelContainer.Controls.Add(getControl);
            buttonGet.BackColor = Color.LightBlue;
        }

        //点击关闭，窗体关闭
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
