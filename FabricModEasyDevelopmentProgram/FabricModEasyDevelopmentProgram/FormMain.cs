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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击\"打开\"按钮或按O键打开本地项目文件夹\n点击\"新建\"按钮或按N键新建项目文件夹\n点击\"退出\"按钮或按E键退出程序\n点击\"帮助\"按钮或按H键显示此对话框");
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.Description = "请选择文件夹路径";
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                string foldPath = FBD.SelectedPath;
                MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            Hide();
            PublicClassse.FN.Show();
        }
    }
}
