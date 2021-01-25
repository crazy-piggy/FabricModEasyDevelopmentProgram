using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabricModEasyDevelopmentProgram
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void FormNew_FormClosing(object sender, CancelEventArgs e)
        {
            Close();
        }

        private void TextboxPath_TextChanged(object sender, EventArgs e)
        {
            var path = TextboxPath.Text;

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Hide();
            PublicClassse.FM.Show();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击\"下载\"按钮或按D键开始下载\n点击\"关闭并回到主页\"按钮或按B键返回主页\n点击\"退出\"按钮或按E键退出程序\n点击\"帮助\"按钮或按H键显示此对话框\n\n请注意两个奇妙的bug:\n\t此窗口点击关闭按钮并不能退出程序!(已修复,此处留彩蛋)\n\t前面提到的快捷操作没有用!");
        }
        #region 知道点关闭按钮不能退出程序用什么方法解决吗?正是如下代码!这个东西我钻研了半个小时!
        private void FormNew_Closing(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            FormClosing += new FormClosingEventHandler(FormNew_Closing);
        }
        // 感谢 https://blog.csdn.net/dreamdonghui/article/details/84842768 !
        #endregion
    }
}
