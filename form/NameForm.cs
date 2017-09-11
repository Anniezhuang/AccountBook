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
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        //点击“确定”，窗体关闭
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
