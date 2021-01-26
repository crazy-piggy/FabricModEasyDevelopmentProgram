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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        private void FormEdit_Closing(object sender, CancelEventArgs e)
        {
            Application.Exit();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            FormClosing += new FormClosingEventHandler(FormEdit_Closing);
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
